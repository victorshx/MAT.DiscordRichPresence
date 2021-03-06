﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;
using Console = Colorful.Console;
using EnumsNET;
using MAT.DiscordRichPresence.Core;
using MAT.DiscordRichPresence.Core.Game;
using MAT.DiscordRichPresence.Core.Services;
using MAT.DiscordRichPresence.Helpers;
using MemoryX;

namespace MAT.DiscordRichPresence
{
    class Program
    {
        //Thread
        private static Thread _thGameWatcher;
        private static Thread _thGameRoutine;
        private static Thread _thDebugLog;

        static void Main(string[] args)
        {
            Console.Title = "MAT2 Discord Rich Presence Client by victorshx";
            Console.CursorVisible = false;
            ConsoleWindow.DisableQuickEdit();

            // Listen to close window event, CTRL-C, kill, etc
            _handler += new EventHandler(Handler);
            SetConsoleCtrlHandler(_handler, true);

            Initialize();
        }

        private static void Initialize()
        {
            if (!Utils.IsApplicationInstalled("Discord"))
            {
                Console.WriteLine("I noticed you do not have Discord installed. Please install Discord for this program to work.", Color.Red);
                Console.ReadKey();
            }

            string updateInfo = UpdateCheck.IsAvailable();
            //Empty string means no update available
            if (string.IsNullOrEmpty(updateInfo))
            {
                var client = UpdateCheck.GetGamePatch();
                Console.Title = $"MAT2 Discord Rich Presence Client by victorshx (Patch {client.GameVersion})";
                Mem.bla = client.Base;

                FindGame();

                //Invoke UpdatePresence function every 5 seconds
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Elapsed += new ElapsedEventHandler(Discord.UpdatePresence);
                timer.Interval = 5 * 1000;
                timer.Enabled = true;
            }
            else
            {
                Console.WriteLine($"Update available." + 
                    Environment.NewLine + 
                    $"Information: {updateInfo}", Color.Orange);
                Thread.Sleep(3000);
                Process.Start(Const.REPO_RELEASE_URL);
                Console.ReadKey();
            }
        }

        private static void FindGame()
        {
            bool isPrintedIntro = false;
            while (true)
            {
                Process[] p = Process.GetProcessesByName(Const.GAME_PROCESS);
                //Game process is not found, process array length is 0
                if (p.Length == 0)
                {
                    if (!isPrintedIntro)
                    {
                        About.PrintIntro();
                        isPrintedIntro = true;
                    }
                }
                else if (p.Length == 1)
                {
                    About.PrintCredits();

                    //Initialize DiscordRpc client
                    Console.WriteLine("Establishing connection with your Discord desktop app...", Color.Orange);
                    Discord.Init();

                    //Assign game pid
                    Var.pId = p[0].Id;

                    //Initialize thread to read game structure continously
                    _thGameRoutine = new Thread(GameRoutine);
                    _thGameRoutine.Start();

                    //Initialize thread to watch if game is exit
                    _thGameWatcher = new Thread(GameWatcher);
                    _thGameWatcher.Start();

#if DEBUG
                    _thDebugLog = new Thread(DebugLog);
                    _thDebugLog.Start();
#endif

                    return;
                }
                else //Found more than one game process, unable to get valid game stats because of two game running
                {
                    About.PrintSorry();
                    return;
                }

                Thread.Sleep(2500);
            }
        }

        private static void GameWatcher()
        {
            while (true)
            {
                if (!Proc.IsAlive(Var.pId))
                {
                    Console.WriteLine("Disconnecting from Discord...", Color.Orange);

                    //When user has closed the game, dispose DiscordRpc
                    Discord.Cleanup();
                    Discord.isReady = false;

                    Thread.Sleep(500);

                    FindGame();
                }

                Thread.Sleep(1000);
            }
        }

        private static void GameRoutine()
        {
            Console.WriteLine("Initializing game routine...", Color.Orange);

            Memory memory = new Memory();
            if (memory.GetProcessHandle(Var.pId))
            {
                Console.WriteLine("Game routine is initialized successfully", Color.LimeGreen);

                while (true)
                {
                    //End game routine loop if process is not alive
                    if (!Proc.IsAlive(Var.pId)) return;

                    Var.g1 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off1);
                    Var.g2 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off2);

                    Var.g3 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off8) == 1 ? true : false;
                    Var.g4 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off9) == 76061 ? true : false;

                    if (Var.g3)
                    {
                        Var.g5 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off9) != 73143 ? true : false;

                        Var.g6 = (byte)memory.ReadMemoryPointerInt(Mem.bla, Mem.off3);
                        Var.g7 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off4);
                        Var.g8 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off5);
                        Var.g9 = (byte)memory.ReadMemoryPointerInt(Mem.bla, Mem.off6);
                        Var.g10 = memory.ReadMemoryPointerInt(Mem.bla, Mem.off7);
                    }

                    Thread.Sleep(100);
                }
            }
            else
            {
                Console.WriteLine("Game route has failed to get game handle", Color.Red);
            }
        }

        private static void DebugLog()
        {
            while (true)
            {
                if (Discord.isReady && Proc.IsAlive(Var.pId) && Var.g1 != 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(Environment.NewLine);
                    sb.AppendLine($"Discord Ready: {Discord.isReady}");
                    sb.Append(Environment.NewLine);
                    sb.AppendLine($"R ID: {((Struct.Realm)Var.g1).AsString(EnumFormat.Description)}");
                    sb.AppendLine($"C ID: {((Struct.Channel)Var.g2).AsString(EnumFormat.Description)}");

                    if (Var.g3)
                    {
                        sb.Append(Environment.NewLine);
                        sb.AppendLine($"ID: {Var.g6.ToString().PadLeft(3, '0')}");
                        sb.AppendLine($"Mo ID: {Var.g7}");
                        sb.AppendLine($"Ma ID: {Var.g8}");
                        sb.AppendLine($"P: {Var.g9} {Var.g10}");
                        sb.AppendLine($"S: {(Var.g5 ? "P" : "W")}");
                    }

                    sb.Append(Environment.NewLine);
                    Console.Write(sb);
                }

                Thread.Sleep(5000);
            }
        }

        #region Trap application termination
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

        private delegate bool EventHandler(CtrlType sig);
        static EventHandler _handler;

        enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        private static bool Handler(CtrlType sig)
        {
            Discord.Cleanup();
            return true;
        }
        #endregion

    }
}
