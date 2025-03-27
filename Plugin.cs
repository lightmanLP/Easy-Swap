using BepInEx;
using BepInEx.Logging;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using HarmonyLib;
using PluginConfig.API.Fields;

namespace EasySwap {
    [BepInPlugin(GUID, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin {
        public const string GUID = "com.the_cat.EasySwap";
        public const string PluginName = "EasySwap";
        public const string VersionString = "1.3.0";

        public static string AssemblyFolder = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";

        public static ManualLogSource Log = new ManualLogSource(PluginName);

        protected bool _configCreated = false;
        public bool configCreated { get => _configCreated; }

        // Equip the specified weapon (plus variant)
        public static void EquipWeapon(Swap.Guns WeaponEnum) {
            string weaponID = null;
            AssetReference[] assetRef = null;

            switch (WeaponEnum) {
                case Swap.Guns.RevolverBlue:
                    weaponID = "rev0";
                    assetRef = GunSetter.Instance.revolverRicochet;
                    break;
                case Swap.Guns.RevolverGreen:
                    weaponID = "rev2";
                    assetRef = GunSetter.Instance.revolverPierce;
                    break;
                case Swap.Guns.RevolverRed:
                    weaponID = "rev1";
                    assetRef = GunSetter.Instance.revolverTwirl;
                    break;

                case Swap.Guns.ShotgunBlue:
                    weaponID = "sho0";
                    assetRef = GunSetter.Instance.shotgunGrenade;
                    break;
                case Swap.Guns.ShotgunGreen:
                    weaponID = "sho1";
                    assetRef = GunSetter.Instance.shotgunPump;
                    break;
                case Swap.Guns.ShotgunRed:
                    weaponID = "sho2";
                    assetRef = GunSetter.Instance.shotgunRed;
                    break;

                case Swap.Guns.NailgunBlue:
                    weaponID = "nai0";
                    assetRef = GunSetter.Instance.nailMagnet;
                    break;
                case Swap.Guns.NailgunGreen:
                    weaponID = "nai1";
                    assetRef = GunSetter.Instance.nailOverheat;
                    break;
                case Swap.Guns.NailgunRed:
                    weaponID = "nai2";
                    assetRef = GunSetter.Instance.nailRed;
                    break;

                case Swap.Guns.RailBlue:
                    weaponID = "rai0";
                    assetRef = GunSetter.Instance.railCannon;
                    break;
                case Swap.Guns.RailGreen:
                    weaponID = "rai1";
                    assetRef = GunSetter.Instance.railHarpoon;
                    break;
                case Swap.Guns.RailRed:
                    weaponID = "rai2";
                    assetRef = GunSetter.Instance.railMalicious;
                    break;

                case Swap.Guns.RocketBlue:
                    weaponID = "rock0";
                    assetRef = GunSetter.Instance.rocketBlue;
                    break;
                case Swap.Guns.RocketGreen:
                    weaponID = "rock1";
                    assetRef = GunSetter.Instance.rocketGreen;
                    break;
                case Swap.Guns.RocketRed:
                    weaponID = "rock2";
                    assetRef = GunSetter.Instance.rocketRed;
                    break;
            }

            if (weaponID == null) {
                Log.LogError($"Invalid weapon!");
                return;
            }

            int num = (MonoSingleton<PrefsManager>.Instance.GetInt("weapon." + weaponID, 0) == 2) ? 1 : 0;
            GunControl.Instance.ForceWeapon(assetRef[num].ToAsset(), true);
        }

        }

        // "Initialize" the mod
        private void Awake() {
            Logger.LogInfo($"{PluginName},V{VersionString} is loading...");

            // Sets up our static Log, so it can be used elsewhere in code.
            Log = Logger;
            Harmony.CreateAndPatchAll(typeof(Plugin));

            Logger.LogInfo($"{PluginName},V{VersionString} is loaded.");
        }

        // Retrieve the variant colors from the players color customization settings
        public static Color[] GetVariantColors() {
            Color[] variantColors = MonoSingleton<ColorBlindSettings>.Instance.variationColors;

            Color blue = new Color(variantColors[0].r, variantColors[0].g, variantColors[0].b);
            Color green = new Color(variantColors[1].r, variantColors[1].g, variantColors[1].b);
            Color red = new Color(variantColors[2].r, variantColors[2].g, variantColors[2].b);

            Color[] colors = {blue, green, red};
            return colors;
        }

        // Runs Every Frame. Here we check if the player presses any of the keybinds assigned.
        private void Update() {
            // Create config
            if (!_configCreated && MonoSingleton<ColorBlindSettings>.Instance != null) {
                PluginConfig.InitConfig();
                Log.LogInfo($"{PluginName},V{VersionString} Plugin Config is loaded.");
                _configCreated = true;
            }

            // Input
            Swap.SwapOnKeypress();
        }


    }
}
