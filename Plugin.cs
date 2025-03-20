using BepInEx;
using BepInEx.Logging;
using PluginConfig.API;
using PluginConfig.API.Fields;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Easy_Swap
{


    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        // Mod Details

        private const string MyGUID = "com.the_cat.Easy_Swap";
        private const string PluginName = "Easy_Swap";
        private const string VersionString = "1.2.2";



        // Plugin Config

        private PluginConfigurator config;

        // Enums


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

        #region

        // Revovler

        KeyCodeField RevovlerBlue;

        KeyCodeField RevovlerGreen;

        KeyCodeField RevovlerRed;


        // Shotgun

        KeyCodeField ShotgunBlue;

        KeyCodeField ShotgunGreen;

        KeyCodeField ShotgunRed;


        // Nailgun

        KeyCodeField NailgunBlue;

        KeyCodeField NailgunGreen;

        KeyCodeField NailgunRed;


        // Railcannon

        KeyCodeField RailcannonBlue;

        KeyCodeField RailcannonGreen;

        KeyCodeField RailcannonRed;


        // Rocket Launcher

        KeyCodeField RocketBlue;

        KeyCodeField RocketGreen;

        KeyCodeField RocketRed;

        #endregion



        public static string DefaultParentFolder = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

        public static ManualLogSource Log = new ManualLogSource(PluginName);



        /// <summary>
        /// Initialize the mod and PluginConfigurator.
        /// 
        /// 
        /// Assign the Keycode variables 
        /// </summary>


        private void Awake()
        {



            Logger.LogInfo($"{PluginName},V{VersionString} is loading...");

            //// Plugin Config Init \\\\

            config = PluginConfigurator.Create("Easy Swap", MyGUID);



            config.SetIconWithURL($"{Path.Combine(DefaultParentFolder, "icon.png")}");

            /// Keybinds \\\

            #region

            float ColorValue = 0.7f; // Adjusts the brightness of the background color for the keybind field



            // Revovler \\

            ConfigPanel RevovlerContainer = new ConfigPanel(config.rootPanel, "Revovler", "revlovPanelES");


            RevovlerBlue = new KeyCodeField(RevovlerContainer, "Revovler (Piercer)", "RevlovES1", KeyCode.None);
            RevovlerBlue.fieldColor = new Color(0f, 0f, ColorValue);

            RevovlerGreen = new KeyCodeField(RevovlerContainer, "Revovler (Marksman)", "RevlovES2", KeyCode.None);
            RevovlerGreen.fieldColor = new Color(0f, ColorValue, 0f);

            RevovlerRed = new KeyCodeField(RevovlerContainer, "Revovler (Sharpshooter)", "RevlovES3", KeyCode.None);
            RevovlerRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Shotgun \\

            ConfigPanel ShotgunContainer = new ConfigPanel(config.rootPanel, "Shotgun", "ShotPanelES");


            ShotgunBlue = new KeyCodeField(ShotgunContainer, "Shotgun (Core Eject)", "ShotES1", KeyCode.None);
            ShotgunBlue.fieldColor = new Color(0f, 0f, ColorValue);

            ShotgunGreen = new KeyCodeField(ShotgunContainer, "Shotgun (Pump)", "ShotES2", KeyCode.None);
            ShotgunGreen.fieldColor = new Color(0f, ColorValue, 0f);

            ShotgunRed = new KeyCodeField(ShotgunContainer, "Shotgun (Sawed On)", "ShotES3", KeyCode.None);
            ShotgunRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Nailgun \\

            ConfigPanel NailgunContainer = new ConfigPanel(config.rootPanel, "Nailgun", "NailPanelES");


            NailgunBlue = new KeyCodeField(NailgunContainer, "Nailgun (Attractor)", "NailES1", KeyCode.None);
            NailgunBlue.fieldColor = new Color(0f, 0f, ColorValue);

            NailgunGreen = new KeyCodeField(NailgunContainer, "Nailgun (Overheat)", "NailES2", KeyCode.None);
            NailgunGreen.fieldColor = new Color(0f, ColorValue, 0f);

            NailgunRed = new KeyCodeField(NailgunContainer, "Nailgun (Jumpstart)", "NailES3", KeyCode.None);
            NailgunRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Railcannon \\

            ConfigPanel RailcannonContainer = new ConfigPanel(config.rootPanel, "Railcannon", "railPanelES");


            RailcannonBlue = new KeyCodeField(RailcannonContainer, "Railcannon (Electric)", "RailES1", KeyCode.None);
            RailcannonBlue.fieldColor = new Color(0f, 0f, ColorValue);

            RailcannonGreen = new KeyCodeField(RailcannonContainer, "Railcannon (Screwdriver)", "RailES2", KeyCode.None);
            RailcannonGreen.fieldColor = new Color(0f, ColorValue, 0f);

            RailcannonRed = new KeyCodeField(RailcannonContainer, "Railcannon (Malicious)", "RailES3", KeyCode.None);
            RailcannonRed.fieldColor = new Color(ColorValue, 0f, 0f);


            // Rocket Launcher \\

            ConfigPanel RocketContainer = new ConfigPanel(config.rootPanel, "Rocket Launcher", "railPanelES");


            RocketBlue = new KeyCodeField(RocketContainer, "Rocket (Freeze Frame)", "RocketES1", KeyCode.None);
            RocketBlue.fieldColor = new Color(0f, 0f, ColorValue);

            RocketGreen = new KeyCodeField(RocketContainer, "Rocket (S.R.S)", "RocketlES2", KeyCode.None);
            RocketGreen.fieldColor = new Color(0f, ColorValue, 0f);

            RocketRed = new KeyCodeField(RocketContainer, "Rocket (Firestarter)", "RocketES3", KeyCode.None);
            RocketRed.fieldColor = new Color(ColorValue, 0f, 0f);

            #endregion



            Logger.LogInfo($"{PluginName},V{VersionString} is loaded.");

            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // Easy_SwapPlugin.Log.LogDebug("Debug Message to BepInEx log file");
            Log = Logger;
        }



        /// <summary>
        /// Equip the specified weapon (plus variant)
        /// </summary>
        /// <param name="WeaponEnum"></param>


        private static void EquipWeapon(Guns WeaponEnum)
        {


            /// Revovler \\\

            #region

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

                // Revovler Green \\\

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

            #endregion

            /// Shotgun \\\

            #region

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

            #endregion


            /// Nailgun \\\

            #region

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

            #endregion

            /// Railcannon \\\

            #region

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

            #endregion

            /// Rocket Launcher \\\ 

            #region

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

            #endregion

        }



        /// <summary>
        /// Runs Every Frame. 
        /// 
        /// Here we check if the player presses any of the keybinds assigned.
        /// </summary>


        private void Update()
        {

            if (!MonoSingleton<OptionsManager>.Instance.inIntro && !MonoSingleton<OptionsManager>.Instance.paused && !MonoSingleton<NewMovement>.Instance.dead)

            {

                /// Revovler \\\

                #region

                // Piercer (BLUE)
                if (UnityInput.Current.GetKeyDown((KeyCode)RevovlerBlue.value))
                {

                    EquipWeapon(Guns.RevovlerBlue);

                }



                // Marksman (GREEN)
                if (UnityInput.Current.GetKeyDown((KeyCode)RevovlerGreen.value))
                {

                    EquipWeapon(Guns.RevovlerGreen);

                }



                // Sharpshooter (RED)
                if (UnityInput.Current.GetKeyDown((KeyCode)RevovlerRed.value))
                {

                    EquipWeapon(Guns.RevovlerRed);

                }

                #endregion


                /// Shotgun \\\

                #region

                // Core Eject (BLUE)
                if (UnityInput.Current.GetKeyDown((KeyCode)ShotgunBlue.value))
                {

                    EquipWeapon(Guns.ShotgunBlue);

                }

                // Pump (GREEN)
                if (UnityInput.Current.GetKeyDown((KeyCode)ShotgunGreen.value))
                {

                    EquipWeapon(Guns.ShotgunGreen);

                }

                // Sawed On (RED)
                if (UnityInput.Current.GetKeyDown((KeyCode)ShotgunRed.value))
                {

                    EquipWeapon(Guns.ShotgunRed);

                }


                #endregion


                /// Nailgun \\\

                #region

                // Attractor (BLUE)
                if (UnityInput.Current.GetKeyDown((KeyCode)NailgunBlue.value))
                {

                    EquipWeapon(Guns.NailgunBlue);

                }

                // Overheat (GREEN)
                if (UnityInput.Current.GetKeyDown((KeyCode)NailgunGreen.value))
                {

                    EquipWeapon(Guns.NailgunGreen);

                }

                // Jumpstart (RED)
                if (UnityInput.Current.GetKeyDown((KeyCode)NailgunRed.value))
                {

                    EquipWeapon(Guns.NailgunRed);

                }

                #endregion


                /// Railcannon \\\

                #region

                // Electric (BLUE)
                if (UnityInput.Current.GetKeyDown((KeyCode)RailcannonBlue.value))
                {

                    EquipWeapon(Guns.RailBlue);

                }

                // Screwdriver (GREEN)
                if (UnityInput.Current.GetKeyDown((KeyCode)RailcannonGreen.value))
                {

                    EquipWeapon(Guns.RailGreen);

                }

                // Malicious (RED)
                if (UnityInput.Current.GetKeyDown((KeyCode)RailcannonRed.value))
                {

                    EquipWeapon(Guns.RailRed);

                }


                #endregion


                /// Rocket Launcher \\\

                #region

                // Freezeframe (BLUE)
                if (UnityInput.Current.GetKeyDown((KeyCode)RocketBlue.value))
                {

                    EquipWeapon(Guns.RocketBlue);

                }

                // S.R.S (GREEN)
                if (UnityInput.Current.GetKeyDown((KeyCode)RocketGreen.value))
                {

                    EquipWeapon(Guns.RocketGreen);

                }

                // Firestarter (RED)
                if (UnityInput.Current.GetKeyDown((KeyCode)RocketRed.value))
                {

                    EquipWeapon(Guns.RocketRed);

                }


                #endregion


            }




        }


    }
}