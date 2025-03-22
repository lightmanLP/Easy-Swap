using BepInEx;
using BepInEx.Logging;
using GameConsole.Commands;
using HarmonyLib;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.SceneManagement;

namespace Easy_Swap
{


    [BepInPlugin(GUID, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        // Mod Details

        public const string GUID = "com.the_cat.Easy_Swap";
        public const string PluginName = "Easy_Swap";
        public const string VersionString = "1.3.0";


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



        public static string AssemblyFolder = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

        public static ManualLogSource Log = new ManualLogSource(PluginName);


        // Equip the specified weapon (plus variant)
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


        public static Color[] GetVariantColors()
        {

            

            Color[] variantColors = MonoSingleton<ColorBlindSettings>.Instance.variationColors;

            Color blue = new Color(variantColors[0].r, variantColors[0].g, variantColors[0].b);
            Color green = new Color(variantColors[1].r, variantColors[1].g, variantColors[1].b);
            Color red = new Color(variantColors[2].r, variantColors[2].g, variantColors[2].b);


            Color[] colors = {blue,green,red };

            return colors;


        }

        // Initialize the mod, PluginConfigurator and assign the Keycode variables 

        private void Awake()
        {



            Logger.LogInfo($"{PluginName},V{VersionString} is loading...");

            







            Logger.LogInfo($"{PluginName},V{VersionString} is loaded.");

            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // Easy_SwapPlugin.Log.LogDebug("Debug Message to BepInEx log file");
            Log = Logger;
        }



       

        static bool configCreated = false;

        // Runs Every Frame. Here we check if the player presses any of the keybinds assigned.
        private void Update()
        {

            //// Plugin Config Init \\\\

            if (configCreated == false && MonoSingleton<ColorBlindSettings>.Instance != null)
            {

                PluginConfig.InitConfig();

                configCreated = true;

            }

            //// Input \\\\

            if (MonoSingleton<OptionsManager>.Instance != null && MonoSingleton<NewMovement>.Instance != null)
            {

                

                if (!MonoSingleton<OptionsManager>.Instance.inIntro && !MonoSingleton<OptionsManager>.Instance.paused && !MonoSingleton<NewMovement>.Instance.dead)

                {

                    /// Revovler \\\

                    #region

                    // Piercer (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerBlue.value))
                    {

                        EquipWeapon(Guns.RevovlerBlue);

                    }



                    // Marksman (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerGreen.value))
                    {

                        EquipWeapon(Guns.RevovlerGreen);

                    }



                    // Sharpshooter (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerRed.value))
                    {

                        EquipWeapon(Guns.RevovlerRed);

                    }

                    #endregion


                    /// Shotgun \\\

                    #region

                    // Core Eject (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunBlue.value))
                    {

                        EquipWeapon(Guns.ShotgunBlue);

                    }

                    // Pump (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunGreen.value))
                    {

                        EquipWeapon(Guns.ShotgunGreen);

                    }

                    // Sawed On (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunRed.value))
                    {

                        EquipWeapon(Guns.ShotgunRed);

                    }


                    #endregion


                    /// Nailgun \\\

                    #region

                    // Attractor (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunBlue.value))
                    {

                        EquipWeapon(Guns.NailgunBlue);

                    }

                    // Overheat (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunGreen.value))
                    {

                        EquipWeapon(Guns.NailgunGreen);

                    }

                    // Jumpstart (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunRed.value))
                    {

                        EquipWeapon(Guns.NailgunRed);

                    }

                    #endregion


                    /// Railcannon \\\

                    #region

                    // Electric (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonBlue.value))
                    {

                        EquipWeapon(Guns.RailBlue);

                    }

                    // Screwdriver (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonGreen.value))
                    {

                        EquipWeapon(Guns.RailGreen);

                    }

                    // Malicious (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonRed.value))
                    {

                        EquipWeapon(Guns.RailRed);

                    }


                    #endregion


                    /// Rocket Launcher \\\

                    #region

                    // Freezeframe (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RocketBlue.value))
                    {

                        EquipWeapon(Guns.RocketBlue);

                    }

                    // S.R.S (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RocketGreen.value))
                    {

                        EquipWeapon(Guns.RocketGreen);

                    }

                    // Firestarter (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RocketRed.value))
                    {

                        EquipWeapon(Guns.RocketRed);

                    }


                    #endregion


                }



            }


        }


    }
}