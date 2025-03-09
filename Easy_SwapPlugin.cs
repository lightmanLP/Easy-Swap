﻿using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using Easy_Swap.Utils;
using HarmonyLib;
using PluginConfig.API;
using PluginConfig.API.Fields;
using UnityEngine;
using UnityEngine.Windows;

namespace Easy_Swap
{
    // TODO Review this file and update to your own requirements.

    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class Easy_SwapPlugin : BaseUnityPlugin
    {
        // Mod specific details. MyGUID should be unique, and follow the reverse domain pattern
        // e.g.
        // com.mynameororg.pluginname
        // Version should be a valid version string.
        // e.g.
        // 1.0.0
        private const string MyGUID = "com.the_cat.Easy_Swap";
        private const string PluginName = "Easy_Swap";
        private const string VersionString = "1.0.0";



        // Plugin Config

        private PluginConfigurator config;

        // Enums
        enum Keybinds {
            None = 0,
            A = 97,
            B = 98,
            C = 99,
            D = 100,
            E = 101,
            F = 102,
            G = 103,
            H = 104,
            I = 105,
            J = 106,
            K = 107,
            L = 108,
            M = 109,
            N = 110,
            O = 111,
            P = 112,
            Q = 113,
            R = 114,
            S = 115,
            T = 116,
            U = 117,
            V = 118,
            W = 119,
            X = 120,
            Y = 121,
            Z = 122,


            Backspace = 8,
            Delete = 127,
            Tab = 9,
            Clear = 12,
            Return = 13,
            Pause = 19,
            Escape = 27,
            Space = 32,
            Keypad0 = 256,
            Keypad1 = 257,
            Keypad2 = 258,
            Keypad3 = 259,
            Keypad4 = 260,
            Keypad5 = 261,
            Keypad6 = 262,
            Keypad7 = 263,
            Keypad8 = 264,
            Keypad9 = 265,
            KeypadPeriod = 266,
            KeypadDivide = 267,
            KeypadMultiply = 268,
            KeypadMinus = 269,
            KeypadPlus = 270,
            KeypadEnter = 271,
            KeypadEquals = 272,
            UpArrow = 273,
            DownArrow = 274,
            RightArrow = 275,
            LeftArrow = 276,
            Insert = 277,
            Home = 278,
            End = 279,
            PageUp = 280,
            PageDown = 281,
            F1 = 282,
            F2 = 283,
            F3 = 284,
            F4 = 285,
            F5 = 286,
            F6 = 287,
            F7 = 288,
            F8 = 289,
            F9 = 290,
            F10 = 291,
            F11 = 292,
            F12 = 293,
            F13 = 294,
            F14 = 295,
            F15 = 296,
            Alpha0 = 48,
            Alpha1 = 49,
            Alpha2 = 50,
            Alpha3 = 51,
            Alpha4 = 52,
            Alpha5 = 53,
            Alpha6 = 54,
            Alpha7 = 55,
            Alpha8 = 56,
            Alpha9 = 57,
            Exclaim = 33,
            DoubleQuote = 34,
            Hash = 35,
            Dollar = 36,
            Percent = 37,
            Ampersand = 38,
            Quote = 39,
            LeftParen = 40,
            RightParen = 41,
            Asterisk = 42,
            Plus = 43,
            Comma = 44,
            Minus = 45,
            Period = 46,
            Slash = 47,
            Colon = 58,
            Semicolon = 59,
            Less = 60,
            Equals = 61,
            Greater = 62,
            Question = 63,
            At = 64,
            LeftBracket = 91,
            Backslash = 92,
            RightBracket = 93,
            Caret = 94,
            Underscore = 95,
            BackQuote = 96,

        };


        enum Guns
        {
            RevovlerBlue = 11,
            RevovlerGreen = 12,
            RevovlerRed = 13,

            ShotgunBlue = 21,
            ShotgunGreen = 22,
            ShotgunRed = 23,

            NailgunBlue = 31,
            NailgunGreen = 32,
            NailgunRed = 33, 

            RailBlue = 41,
            RailGreen = 42,
            RailRed = 43,

            RocketBlue = 51,
            RocketGreen = 52,
            RocketRed = 53
        }




        /// Keybinds \\\



        // Revovler

        EnumField<Keybinds> RevovlerBlue;

        EnumField<Keybinds> RevovlerGreen;

        EnumField<Keybinds> RevovlerRed;


        // Shotgun

        EnumField<Keybinds> ShotgunBlue;

        EnumField<Keybinds> ShotgunGreen;

        EnumField<Keybinds> ShotgunRed;


        // Nailgun

        EnumField<Keybinds> NailgunBlue;

        EnumField<Keybinds> NailgunGreen;

        EnumField<Keybinds> NailgunRed;


        // Railcannon

        EnumField<Keybinds> RailcannonBlue;

        EnumField<Keybinds> RailcannonGreen;

        EnumField<Keybinds> RailcannonRed;


        // Rocket Launcher

        EnumField<Keybinds> RocketBlue;

        EnumField<Keybinds> RocketGreen;

        EnumField<Keybinds> RocketRed;





        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public static ManualLogSource Log = new ManualLogSource(PluginName);

        /// <summary>
        /// Initialise the configuration settings and patch methods
        /// </summary>


        private void Awake()
        {

            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");

            //// Plugin Config Init \\\\

            config = PluginConfigurator.Create("Easy Swap", MyGUID);

            /// Keybinds \\\

            float ColorValue = 0.7f;

            // Revovler

            ConfigPanel RevovlerContainer = new ConfigPanel(config.rootPanel, "Revovler", "revlovPanelES");


            RevovlerBlue = new EnumField<Keybinds>(RevovlerContainer, "Revovler (Piercer)", "RevlovES1", Keybinds.None);
            RevovlerBlue.fieldColor = new Color(0f, 0f, ColorValue);

            RevovlerGreen = new EnumField<Keybinds>(RevovlerContainer, "Revovler (Marksman)", "RevlovES2", Keybinds.None);
            RevovlerGreen.fieldColor = new Color(0f, ColorValue, 0f);

            RevovlerRed = new EnumField<Keybinds>(RevovlerContainer, "Revovler (Sharpshooter)", "RevlovES3", Keybinds.None);
            RevovlerRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Shotgun

            ConfigPanel ShotgunContainer = new ConfigPanel(config.rootPanel, "Shotgun", "ShotPanelES");


            ShotgunBlue = new EnumField<Keybinds>(ShotgunContainer, "Shotgun (Core Eject)", "ShotES1", Keybinds.None);
            ShotgunBlue.fieldColor = new Color(0f, 0f, ColorValue);

            ShotgunGreen = new EnumField<Keybinds>(ShotgunContainer, "Shotgun (Pump)", "ShotES2", Keybinds.None);
            ShotgunGreen.fieldColor = new Color(0f, ColorValue, 0f);

            ShotgunRed = new EnumField<Keybinds>(ShotgunContainer, "Shotgun (Sawed On)", "ShotES3", Keybinds.None);
            ShotgunRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Nailgun

            ConfigPanel NailgunContainer = new ConfigPanel(config.rootPanel,"Nailgun","NailPanelES");


            NailgunBlue = new EnumField<Keybinds>(NailgunContainer, "Nailgun (Attractor)", "NailES1", Keybinds.None);
            NailgunBlue.fieldColor = new Color(0f, 0f, ColorValue);

            NailgunGreen = new EnumField<Keybinds>(NailgunContainer, "Nailgun (Green)", "NailES2", Keybinds.None);
            NailgunGreen.fieldColor = new Color(0f, ColorValue, 0f);

            NailgunRed = new EnumField<Keybinds>(NailgunContainer, "Nailgun (Jumpstart)", "NailES3", Keybinds.None);
            NailgunRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Railcannon

            ConfigPanel RailcannonContainer = new ConfigPanel(config.rootPanel, "Railcannon", "railPanelES");


            RailcannonBlue = new EnumField<Keybinds>(RailcannonContainer, "Railcannon (Electric)", "RailES1", Keybinds.None);
            RailcannonBlue.fieldColor = new Color(0f, 0f, ColorValue);

            RailcannonGreen = new EnumField<Keybinds>(RailcannonContainer, "Railcannon (Screwdriver)", "RailES2", Keybinds.None);
            RailcannonGreen.fieldColor = new Color(0f, ColorValue, 0f);

            RailcannonRed = new EnumField<Keybinds>(RailcannonContainer, "Railcannon (Malicious)", "RailES3", Keybinds.None);
            RailcannonRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Rocket Launcher

            ConfigPanel RocketContainer = new ConfigPanel(config.rootPanel, "Rocket Launcher", "railPanelES");


            RocketBlue = new EnumField<Keybinds>(RocketContainer, "Rocket (Freeze Frame)", "RocketES1", Keybinds.None);
            RocketBlue.fieldColor = new Color(0f,0f, ColorValue);

            RocketGreen = new EnumField<Keybinds>(RocketContainer, "Rocket (S.R.S)", "RocketlES2", Keybinds.None);
            RocketGreen.fieldColor = new Color(0f, ColorValue, 0f);

            RocketRed = new EnumField<Keybinds>(RocketContainer, "Rocket (Firestarter)", "RocketES3", Keybinds.None);
            RocketRed.fieldColor = new Color(ColorValue, 0f, 0f);



            
           
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");

            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // Easy_SwapPlugin.Log.LogDebug("Debug Message to BepInEx log file");
            Log = Logger;
        }

        

        /// <summary>
        /// Set the current Gun
        /// </summary>
        /// <param name="WeaponEnum"></param>


        private static void SetGun(Guns WeaponEnum)
        {

            
            // Revovler
            if (WeaponEnum == Guns.RevovlerBlue)
            {
                // Revovler Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rev0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.revolverPierce[num].ToAsset(), true);

            } 
            else if (WeaponEnum == Guns.RevovlerGreen)
            {

                // Revovler Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rev1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.revolverRicochet[num].ToAsset(), true);
            }
            else if (WeaponEnum == Guns.RevovlerRed)
            {

                // Revovler Red

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rev2", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.revolverTwirl[num].ToAsset(), true);
            }

            // Shotgun
            if (WeaponEnum == Guns.ShotgunBlue)
            {
                // Shotgun Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "sho0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.shotgunGrenade[num].ToAsset(), true);

            }
            else if (WeaponEnum == Guns.ShotgunGreen)
            {

                // Shotgun Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "sho1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.shotgunPump[num].ToAsset(), true);
            }
            else if (WeaponEnum == Guns.ShotgunRed)
            {

                // Shotgun Red

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "sho2", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.shotgunRed[num].ToAsset(), true);
            }

            // Nailgun
            if (WeaponEnum == Guns.NailgunBlue)
            {
                // Nailgun Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "nai0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.nailMagnet[num].ToAsset(), true);

            }
            else if (WeaponEnum == Guns.NailgunGreen)
            {

                // Nailgun Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "nai1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.nailOverheat[num].ToAsset(), true);
            }
            else if (WeaponEnum == Guns.NailgunRed)
            {

                // Nailgun Red

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "nai2", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.nailRed[num].ToAsset(), true);
            }

            // Railcannon
            if (WeaponEnum == Guns.RailBlue)
            {
                // Railcannon Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rai0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.railCannon[num].ToAsset(), true);

            }
            else if (WeaponEnum == Guns.RailGreen)
            {

                // Railcannon Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rai1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.railHarpoon[num].ToAsset(), true);
            }
            else if (WeaponEnum == Guns.RailRed)
            {

                // Railcannon Red

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rai2", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.railMalicious[num].ToAsset(), true);
            }

            // Rocket Launcher
            if (WeaponEnum == Guns.RocketBlue)
            {
                // Rocket Launcher Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rock0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.rocketBlue[num].ToAsset(), true);

            }
            else if (WeaponEnum == Guns.RocketGreen)
            {

                // Rocket Launcher Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rock1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.rocketGreen[num].ToAsset(), true);
            }
            else if (WeaponEnum == Guns.RocketRed)
            {

                // Rocket Launcher Red

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rock2", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.rocketRed[num].ToAsset(), true);
            }


        }

        

        /// <summary>
        /// Code executed every frame. See below for an example use case
        /// to detect keypress via custom configuration.
        /// </summary>
        

        private void Update()
        {

            // Revovler Piercer (BLUE)
            if (UnityInput.Current.GetKeyDown((KeyCode)RevovlerBlue.value))
            {

                Logger.LogInfo("Keypress detected! (Revovler BLUE)");

                SetGun(Guns.RevovlerBlue);

            }

            // Revovler Marksman (GREEN)
            if (UnityInput.Current.GetKeyDown((KeyCode)RevovlerGreen.value))
            {

                Logger.LogInfo("Keypress detected! (Revovler GREEN)");

                SetGun(Guns.RevovlerGreen);

            }

            // Revovler Sharpshooter (RED)
            if (UnityInput.Current.GetKeyDown((KeyCode)RevovlerRed.value))
            {

                Logger.LogInfo("Keypress detected! (Revovler RED)");

                SetGun(Guns.RevovlerRed);

            }





            // Shotgun Core Eject (BLUE)
            if (UnityInput.Current.GetKeyDown((KeyCode)ShotgunBlue.value))
            {

                Logger.LogInfo("Keypress detected! (Shotgun BLUE)");

                SetGun(Guns.ShotgunBlue);

            }

            // Shotgun Pump (GREEN)
            if (UnityInput.Current.GetKeyDown((KeyCode)ShotgunGreen.value))
            {

                Logger.LogInfo("Keypress detected! (Shotgun GREEN)");

                SetGun(Guns.ShotgunGreen);

            }

            // Shotgun Sawed On (RED)
            if (UnityInput.Current.GetKeyDown((KeyCode)ShotgunRed.value))
            {

                Logger.LogInfo("Keypress detected! (Shotgun RED)");

                SetGun(Guns.ShotgunRed);

            }





            // Nailgun Attractor (BLUE)
            if (UnityInput.Current.GetKeyDown((KeyCode)NailgunBlue.value))
            {

                Logger.LogInfo("Keypress detected! (Nailgun BLUE)");

                SetGun(Guns.NailgunBlue);

            }

            // Nailgun Attractor (GREEN)
            if (UnityInput.Current.GetKeyDown((KeyCode)NailgunGreen.value))
            {

                Logger.LogInfo("Keypress detected! (Nailgun GREEN)");

                SetGun(Guns.NailgunGreen);

            }

            // Nailgun Jumpstart (RED)
            if (UnityInput.Current.GetKeyDown((KeyCode)NailgunRed.value))
            {

                Logger.LogInfo("Keypress detected! (Nailgun RED)");

                SetGun(Guns.NailgunRed);

            }





            // Railcannon Electric (BLUE)
            if (UnityInput.Current.GetKeyDown((KeyCode)RailcannonBlue.value))
            {

                Logger.LogInfo("Keypress detected! (Railcannon BLUE)");

                SetGun(Guns.RailBlue);

            }

            // Railcannon Screwdriver (GREEN)
            if (UnityInput.Current.GetKeyDown((KeyCode)RailcannonGreen.value))
            {

                Logger.LogInfo("Keypress detected! (Railcannon GREEN)");

                SetGun(Guns.RailGreen);

            }

            // Railcannon Malicious (RED)
            if (UnityInput.Current.GetKeyDown((KeyCode)RailcannonRed.value))
            {

                Logger.LogInfo("Keypress detected! (Railcannon RED)");

                SetGun(Guns.RailRed);

            }





            // Rocket Launcher Freezeframe (BLUE)
            if (UnityInput.Current.GetKeyDown((KeyCode)RocketBlue.value))
            {

                Logger.LogInfo("Keypress detected! (Rocket Launcher BLUE)");

                SetGun(Guns.RocketBlue);

            }

            // Rocket Launcher S.R.S (GREEN)
            if (UnityInput.Current.GetKeyDown((KeyCode)RocketGreen.value))
            {

                Logger.LogInfo("Keypress detected! (Rocket Launcher GREEN)");

                SetGun(Guns.RocketGreen);

            }

            // Rocket Launcher Firestarter (RED)
            if (UnityInput.Current.GetKeyDown((KeyCode)RocketRed.value))
            {

                Logger.LogInfo("Keypress detected! (Rocket Launcher RED)");

                SetGun(Guns.RocketRed);

            }

        }


    }
}
