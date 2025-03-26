using BepInEx;
using BepInEx.Logging;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Easy_Swap
{


    [BepInPlugin(GUID, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        // Mod Details

        public const string GUID = "com.the_cat.Easy_Swap";
        public const string PluginName = "Easy_Swap";
        public const string VersionString = "1.3.0";



        public static string AssemblyFolder = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

        public static ManualLogSource Log = new ManualLogSource(PluginName);




        // Equip the specified weapon (plus variant)
        public static void EquipWeapon(Swap.Guns WeaponEnum)
        {


            /// Revovler \\\

            #region

            if (WeaponEnum == Swap.Guns.RevovlerBlue)
            {
                // Revovler Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rev0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.revolverPierce[num].ToAsset(), true);

            }
            else if (WeaponEnum == Swap.Guns.RevovlerGreen)
            {

                // Revovler Green \\\

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rev2", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.revolverRicochet[num].ToAsset(), true);
            }
            else if (WeaponEnum == Swap.Guns.RevovlerRed)
            {

                // Revovler Red

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rev1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.revolverTwirl[num].ToAsset(), true);
            }

            #endregion

            /// Shotgun \\\

            #region

            if (WeaponEnum == Swap.Guns.ShotgunBlue)
            {
                // Shotgun Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "sho0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.shotgunGrenade[num].ToAsset(), true);

            }
            else if (WeaponEnum == Swap.Guns.ShotgunGreen)
            {

                // Shotgun Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "sho1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.shotgunPump[num].ToAsset(), true);
            }
            else if (WeaponEnum == Swap.Guns.ShotgunRed)
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

            if (WeaponEnum == Swap.Guns.NailgunBlue)
            {
                // Nailgun Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "nai0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.nailMagnet[num].ToAsset(), true);

            }
            else if (WeaponEnum == Swap.Guns.NailgunGreen)
            {

                // Nailgun Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "nai1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.nailOverheat[num].ToAsset(), true);
            }
            else if (WeaponEnum == Swap.Guns.NailgunRed)
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

            if (WeaponEnum == Swap.Guns.RailBlue)
            {
                // Railcannon Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rai0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.railCannon[num].ToAsset(), true);

            }
            else if (WeaponEnum == Swap.Guns.RailGreen)
            {

                // Railcannon Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rai1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.railHarpoon[num].ToAsset(), true);
            }
            else if (WeaponEnum == Swap.Guns.RailRed)
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

            if (WeaponEnum == Swap.Guns.RocketBlue)
            {
                // Rocket Launcher Blue

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rock0", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.rocketBlue[num].ToAsset(), true);

            }
            else if (WeaponEnum == Swap.Guns.RocketGreen)
            {

                // Rocket Launcher Green

                int num = 0;
                if (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + "rock1", 0) == 2)
                {
                    num = 1;
                }

                GunControl.Instance.ForceWeapon(GunSetter.Instance.rocketGreen[num].ToAsset(), true);
            }
            else if (WeaponEnum == Swap.Guns.RocketRed)
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


        // Retrieve the variant colors from the players color customization settings
        public static Color[] GetVariantColors()
        {

            

            Color[] variantColors = MonoSingleton<ColorBlindSettings>.Instance.variationColors;

            Color blue = new Color(variantColors[0].r, variantColors[0].g, variantColors[0].b);
            Color green = new Color(variantColors[1].r, variantColors[1].g, variantColors[1].b);
            Color red = new Color(variantColors[2].r, variantColors[2].g, variantColors[2].b);


            Color[] colors = {blue,green,red };

            return colors;


        }




        // "Initialize" the mod

        private void Awake()
        {

            Logger.LogInfo($"{PluginName},V{VersionString} is loading...");

            

            // Sets up our static Log, so it can be used elsewhere in code.
            Log = Logger;


            Logger.LogInfo($"{PluginName},V{VersionString} is loaded.");
        }



       

        bool configCreated = false;

        // Runs Every Frame. Here we check if the player presses any of the keybinds assigned, and initialize the plugin config if it hasnt.
        private void Update()
        {

            //// Plugin Config Init \\\\

            if (configCreated == false && MonoSingleton<ColorBlindSettings>.Instance != null)
            {

                PluginConfig.InitConfig();

                Log.LogInfo($"{PluginName},V{VersionString} Plugin Config is loaded.");

                configCreated = true;

            }

            //// Input \\\\

            Swap.SwapOnKeypress();


        }


    }
}