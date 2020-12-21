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
            [Description("TDM")]
            Team = 1,

            [Description("BM")]
            BM = 4,

            [Description("Carrying Plan")]
            CarryingPlan = 104,

            [Description("GM")]
            GM = 7,

            [Description("BM Competitive")]
            BMC = 71,

            [Description("TDM Competitive")]
            TDMC = 68,

            [Description("Mummy")]
            Mummy = 10,

            [Description("Hero")]
            MummyHero = 56,

            [Description("H&S")]
            HideSeek = 51,

            [Description("Car Racing")]
            Ride = 54,

            [Description("Phantom Mode")]
            Phantom = 46,

            [Description("Rescue")]
            Rescue = 47,

            [Description("DM")]
            Personal = 2,

            [Description("TDM")]
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
            Inf1Normal = 48,

            [Description("Normal")]
            Inf1Hard = 49,

            [Description("?")]
            Inf2 = 55,

            [Description("Normal")]
            Inf3Normal = 69,

            [Description("Hard")]
            Inf3Hard = 70,

            [Description("Normal")]
            SKNormal = 40,

            [Description("Hard")]
            SKHard = 41,

            [Description("Normal")]
            DKNormal = 35,

            [Description("Hard")]
            DKHard = 36,

            [Description("Hell")]
            DKValley = 38,

            [Description("Easy")]
            GMissionEasy = 17,

            [Description("Normal")]
            GMissionNormal = 11,

            [Description("Crazy")]
            GMissionCrazy = 14,

            [Description("Nightmare")]
            GMissionNightmare = 15,

            [Description("Easy")]
            LDefendEasy = 23,

            [Description("Normal")]
            LDefendNormal = 20,

            [Description("Crazy")]
            LDefendCrazy = 21,

            [Description("Nightmare")]
            LDefendNightmare = 21,

            [Description("Easy")]
            DoomsEasy = 29,

            [Description("Normal")]
            DoomsNormal = 26,

            [Description("Nightmare")]
            DoomsNightmare = 27,

            [Description("Crazy")]
            DoomsCrazy = 28,

            [Description("Normal")] 
            Galatic = 8
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

            [Description("The Passing Gate")]
            PassingGate = 267,

            [Description("Aden Army Warehouse")]
            ArmyWarehouse = 244,

            [Description("Violet Garden")]
            VioletGarden = 225,

            [Description("Chessboard Resort")]
            Chessboard = 220,

            [Description("Kunlun Platform")]
            Kunlun = 222,

            [Description("Maginot Fortress")]
            Maginot = 234,

            [Description("Snow Arena of Hawkeye")]
            Snow = 210,

            [Description("Cape Town Stadium")]
            CapeTown = 179,

            [Description("Cross Range")]
            CrossRange = 6,

            [Description("Blood Range")]
            BloodRange = 7,

            [Description("Capital Subway Station")]
            Subway = 9,

            [Description("Tianfu Power Station")]
            PowerStation = 10,

            [Description("Tiexi Warehouse")]
            TiexiWarehouse = 11,

            [Description("Houhai Bar")]
            Bar = 12,

            [Description("Mong Kok Terrace")]
            MongKok = 13,

            [Description("Huangpu Terminal")]
            Huangpu = 14,

            [Description("Heishui Site")]
            Heishui = 15,

            [Description("518 Base")]
            Base = 16,

            [Description("Kashi Castle")]
            Castle = 17,

            [Description("Bohai Chemical Plant")]
            ChemPlant = 19,

            [Description("Snowcapped Warehouse")]
            SnowWarehouse = 22,

            [Description("Nile Delta")]
            NileDelta = 23,

            [Description("Western Town")]
            WesternTown = 94,

            [Description("Loulan City")]
            Loulan = 168,

            [Description("Qandahar Sentry")]
            Sentry = 246,
            /// <summary>
            /// PVP Bomb
            /// </summary>
            [Description("Misty Rain Town")]
            Misty = 422,

            [Description("Peninsula Zone")]
            Peninsula = 415,

            [Description("Roman Hotel")]
            RomanHotel = 401,

            [Description("Winner Complex")]
            WinnerComplex = 400,

            [Description("Jonker Walk")]
            Jonker = 383,

            [Description("Taipei 101")]
            Taipei = 381,

            [Description("Oasis Town")]
            OasisTown = 382,

            [Description("Nightingale City")]
            Nightingale = 433,

            [Description("HuaLamphong Station")]
            TrainStation = 323,

            [Description("Huangpu Night")]
            Huangpu1 = 414,

            [Description("Cal. City of Night & Death")]
            NightDeathCity = 315,

            [Description("Giant Classroom")]
            Classroom = 309,

            [Description("Petaling Street")]
            Petaling = 309,

            [Description("Rock and Roll Town")]
            RockNRoll = 294,

            [Description("Eastern Champ City")]
            Eastern = 290,

            [Description("Suez Altar")]
            Altar = 270,

            [Description("Dragon New Lair")]
            Dragon = 261,

            [Description("Church of St. Casey")]
            Church = 259,

            [Description("Maginot Fortress")]
            Fortress = 235,

            [Description("Nile Delta")]
            NileDelta1 = 52,

            [Description("Huangpu Terminal")]
            Huangpu2 = 123,

            [Description("Snowcapped Warehouse")]
            SnowWarehouse1 = 54,

            [Description("Qandahar Sentry")]
            Sentry1 = 247,

            [Description("Kashi Castle")]
            Castle1 = 170,

            [Description("Ancient Town")]
            AncientTown = 430,
            /// <summary>
            /// PVP Ghost
            /// </summary>
            [Description("CPU Underground City")]
            Underground = 390,

            [Description("Phantom")]
            Phantom  = 302,

            [Description("Big Ben")]
            BigBen = 281,

            [Description("Bodleian Library")]
            Library = 258,

            [Description("Federal Aviation")]
            Aviation = 176,

            [Description("Nanyang Armory")]
            Nanyang = 207,

            [Description("Zhujiang Research Institute")]
            Zhujiang = 61,

            [Description("Tianshan Base")]
            Tianshan = 62,

            [Description("Huangpu Terminal")]
            Huangpu3 = 417,

            [Description("Cross Range")]
            CrossRange1 = 416,
            /// <summary>
            /// PVP Mummy
            /// </summary>
            [Description("Sancta Sophia")]
            Sophia = 364,

            [Description("Pharaoh Ancient Tomb")]
            AncientTomb = 438,

            [Description("Epidemic Crossroad")]
            Epidemic = 378,

            [Description("Twilight Burial City")]
            Twilight = 325,

            [Description("Aden Military Warehouse")]
            AdenWarehouse = 312,

            [Description("Scream Park")]
            ScreamPark = 295,

            [Description("Misty Town")]
            MistyTown = 283,

            [Description("Nile Valley 2")]
            Valley2 = 262,

            [Description("Pharaoh Temple 2")]
            Temple2 = 208,

            [Description("Pharaoh Temple")]
            Temple1 = 66,

            [Description("Cal. Night City")]
            NightCity = 209,

            [Description("Nile Valley ")]
            Valley1 = 68,
            /// <summary>
            /// PVP Hide & Seek
            /// </summary>
            [Description("Secret of Chinatown")]
            ChinaTown = 391,

            [Description("The Secret of Child's Paradsie")]
            Paradise = 432,

            [Description("Tuscany's Secret")]
            Tuscany = 313,

            [Description("Speedy Dubai")]
            Dubai = 363,

            [Description("Haunted Crossroad")]
            Crossroad = 308,

            [Description("Phantom Depot Ship")]
            Ship = 301,

            [Description("Imperial College")]
            College = 326,

            [Description("New Railway Line")]
            Railway = 316
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
