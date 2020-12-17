using System.ComponentModel;

namespace MAT.DiscordRichPresence.Core.Game
{
    class Struct
    {
        public enum Realm
        {
            [Description("W1")]
            WarfareI = 4,

            [Description("W2")]
            WarfareII = 1,

            [Description("W3")]
            WarfareIII = 2,

            [Description("Beginner Channel")]
            Beginner = 3,

            [Description("Couple Match Zone")]
            Couple = 5,

            [Description("GB")]
            Guild = 6
        };

        public enum Channel
        {
            [Description("DUEL MODE")]
            DuelMode = 0,

            [Description("DOOMSDAY")]
            Doomsday = 1,

            [Description("MUMMY I")]
            MummyI = 2,

            [Description("MUMMY II")]
            MummyII = 3,

            [Description("G-MISSION")]
            GMission = 4,

            [Description("SNOW WAR")]
            SnowWar = 5,

            [Description("TANK MODE")]
            TankMode = 6,

            [Description("PHANTOM MODE")]
            PhantomMode = 7,

            [Description("EXPLOSION MODE")]
            ExplosionMode = 8,

            [Description("PERSONAL RECOVERY")]
            PersonalRecovery = 9,

            [Description("Selecting")]
            ServerSelection = 100
        }

        public enum GameMode
        {
            /// <summary>
            /// PVP Room
            /// </summary>
            [Description("Team Death Match")]
            Team = 1,

            [Description("Bomb Match")]
            BM = 4,

            [Description("Carrying Plan")]
            CarryingPlan = 104,

            [Description("Ghost Mode")]
            GM = 7,

            [Description("Mummy")]
            Mummy = 10,

            [Description("Hide & Seek Mode")]
            HideSeek = 51,

            [Description("Car Racing")]
            Ride = 54,

            [Description("Phantom Mode")]
            Phantom = 46,

            [Description("Rescue")]
            Rescue = 47,

            [Description("Death Match")]
            Personal = 2,

            [Description("Team Match")]
            TM = 3,

            [Description("PK Normal")]
            PK1 = 25,

            [Description("PK 1v1")]
            PK2 = 30,

            [Description("Occupation Match")]
            Occupy = 5,

            [Description("Snow War Team")]
            Snow = 18,
            /// <summary>
            /// PVE Room
            /// </summary>
            [Description("Normal PVE")]
            Huangpu1 = 116,
            [Description("Hard PVE")]
            Huangpu2 = 117,

            [Description("Normal")]
            G1Normal = 97,

            [Description("Hard")]
            G1Hard = 98,

            [Description("Normal")]
            G2Normal = 100,

            [Description("Hard")]
            G2Hard = 101,

            [Description("Normal")]
            G3Normal = 102,

            [Description("Hard")]
            G3Hard = 103,

            [Description("Normal")]
            G4Normal = 105,

            [Description("Hard")]
            G4Hard = 106,

            [Description("Normal")]
            SC1Normal = 88,

            [Description("Hard")]
            SC1Hard = 89,

            [Description("Normal")]
            SC2Normal = 90,

            [Description("Hard")]
            SC2Hard = 91,

            [Description("Normal")]
            SCLNormal = 94,

            [Description("Hard")]
            SCLHard = 95,

            [Description("Normal")]
            Inf3Normal = 69,

            [Description("Hard")]
            Inf3Hard = 70,
            /// <summary>
            /// Chat Room
            /// </summary>
        }

        public enum GameMap
        {
            /// <summary>
            /// PVP Team
            /// </summary>
            [Description("Rainbow Island")]
            RainbowIsland = 436,

            [Description("Cool Summer's Beach")]
            CoolSummerBeach = 393,

            [Description("Worry Free Castle")]
            WorryFreeCastle = 421,

            [Description("The Joker Laboratory")]
            JokerLab = 409,

            [Description("Tranzor's Legacy")]
            TranzorLegacy = 408,

            [Description("Lego Town")]
            LegoTown = 324,

            [Description("Titan's Office")]
            TitanOffice = 322,

            [Description("South Heaven Gate")]
            SouthHeavenGate = 310,

            [Description("Jiangnan Town")]
            JiangnanTown = 300,

            [Description("Liberation Square")]
            LiberSquare = 296,

            [Description("Panda Park")]
            PandaPark = 293,

            [Description("Sasha's Forbidden Ground")]
            SashaGround = 288,

            [Description("Farm House")]
            FarmHouse = 287,

            [Description("Dragon Boat Falls")]
            DragonBoat = 284,

            [Description("Mini World")]
            MiniWorld = 277,

            [Description("Bell Factory")]
            BellFactory = 272,

            [Description("Suez Altar")]
            SuezAltar = 269,

            [Description("Toy Dream Factory")]
            ToyFactory = 268,
        }

        public enum GameWeaponLimit
        {
            [Description("None")]
            All = 1,

            [Description("ALL Weapons EXCEPT for Transform Gun")]
            NoDistortion = 2,

            [Description("ONLY Conventional Weapons")]
            Conventional = 3,

            [Description("All Conventional Weapons EXCEPT for Sniper")]
            Assault = 4,

            [Description("Only Special & Secondary Weapons")]
            Special = 5,

            [Description("ONLY Snipers & Melee")]
            Sniper = 6,

            [Description("ONLY Melee")]
            Melee = 7,

            [Description("ONLY Fist")]
            Fist = 8,

            [Description("ONLY Pistols & Melee")]
            Pistol = 9,

            [Description("ONLY Melee & Damageable Grenades")]
            Grenade = 10
        }
    }
}
