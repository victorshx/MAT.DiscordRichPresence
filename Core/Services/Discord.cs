using System;
using System.Drawing;
using System.Timers;
using MAT.DiscordRichPresence.Core.Game;
using Console = Colorful.Console;
using EnumsNET;
using MAT.DiscordRichPresence.Helpers;
using DiscordRPC;
using DiscordRPC.Logging;

namespace MAT.DiscordRichPresence.Core.Services
{
    class Discord
    {
        //DiscordRpc client
        private static DiscordRpcClient _client;

        //DiscordRpc constants
        private static Timestamps Timestamps;
        public static bool isReady { get; set; } = false;

        public static void Init()
        {
            //Creates the client
            _client = new DiscordRpcClient(Const.DISCORD_APP_ID);

            //Set the logger
#if DEBUG
            _client.Logger = new ConsoleLogger()
            {
                Level = LogLevel.Info,
                Colored = true
            };
#else
            _client.Logger = new ConsoleLogger()
            {
                Level = LogLevel.Warning,
                Colored = true
            };
#endif

            //Subscribe to ready event
            _client.OnReady += (sender, e) =>
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine($"Discord User ({e.User.Username}#{e.User.Discriminator}) is ready to receive presence update", Color.LimeGreen);

                Timestamps = new Timestamps() { Start = DateTime.UtcNow };
                isReady = true;
            };

            //Subscribe to close event
            _client.OnClose += (sender, e) =>
            {
                Console.WriteLine($"Lost connection to Discord because of {e.Reason}", Color.Red);
                isReady = false;
            };

            //Subscribe to error event
            _client.OnError += (sender, e) =>
            {
                Console.WriteLine($"Error occured within discord. {e.Message}", Color.Red);
                isReady = false;
            };

            //Successful connection to Discord pipe
            _client.OnConnectionEstablished += (sender, e) =>
            {
                Console.WriteLine($"Connection to Discord established", Color.LimeGreen);
            };

            //Failed to connect to Discord pipe(when Discord is not available or Discord has closed)
            _client.OnConnectionFailed += (sender, e) =>
            {
                Console.WriteLine($"Connection to Discord failed. Please restart or open Discord.", Color.Pink);
                isReady = false;
            };

            _client.OnPresenceUpdate += (sender, e) =>
            {
#if DEBUG
                Console.WriteLine("Discord Received Update!", Color.Gold);
#endif
            };

            //Connect to Rpc
            _client.Initialize();
        }

        public static void UpdatePresence(object source, ElapsedEventArgs e)
        {
            if (isReady && Proc.IsAlive(Var.pId) && Var.g1 != 0)
            {
                bool bS = Var.g2 == (int)Struct.Channel.ServerSelection ? true : false;

                string rN = ((Struct.Realm)Var.g1).AsString(EnumFormat.Description),
                    cN = ((Struct.Channel)Var.g2).AsString(EnumFormat.Description);

                string gMo = ((Struct.GameMap)Var.g8).AsString(EnumFormat.Description),
                    gMa = ((Struct.GameMode)Var.g7).AsString(EnumFormat.Description);

                string s1 = Var.g5 ? "Playing" : "Waiting";
                string s2 = Var.g4 ? "Chat Room" : "Lobby";
                string s3 = Var.g3 ? $"{s1} | {Var.g6.ToString().PadLeft(3, '0')}" : s2;

                _client.SetPresence(new RichPresence()
                {
                    Details = bS ? rN : $"{rN} ({cN})",
                    State = s3,
                    Assets = new Assets()
                    {
                        LargeImageKey = Const.DISCORD_LARGE_IMAGE_KEY,
                        LargeImageText = Var.g7 != 0 && Var.g8 != 0 ? $"{gMo}" : Const.GAME_FULL_NAME
                    },
                    Party = new Party()
                    {
                        ID = Var.g3 ? "room" : "",
                        Size = Convert.ToInt32(Var.g9),
                        Max = Var.g10
                    },
                    Timestamps = Timestamps
                });
            }
            else
            {
                _client.SetPresence(new RichPresence()
                {
                    Assets = new Assets()
                    {
                        LargeImageKey = Const.DISCORD_LARGE_IMAGE_KEY,
                        LargeImageText = Const.GAME_FULL_NAME
                    },
                    Timestamps = Timestamps
                });
            }
        }

        //Dispose client
        public static void Cleanup()
        {
            if (isReady) _client.Dispose();
        }
    }
}
