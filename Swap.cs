using BepInEx;


namespace EasySwap {
    public class Swap {
        public enum Guns {
            RevovlerBlue = 10,
            RevovlerRed = 11,
            RevovlerGreen = 12,

            ShotgunBlue = 20,
            ShotgunGreen = 21,
            ShotgunRed = 22,

            NailgunBlue = 30,
            NailgunGreen = 31,
            NailgunRed = 32,

            RailBlue = 40,
            RailGreen = 41,
            RailRed = 42,

            RocketBlue = 50,
            RocketGreen = 51,
            RocketRed = 52
        }

        // Swap to the appropriate weapon when the set bind is pressed
        public static void SwapOnKeypress() {
            if (
                MonoSingleton<OptionsManager>.Instance != null
                && MonoSingleton<NewMovement>.Instance != null
                && !MonoSingleton<OptionsManager>.Instance.inIntro
                && !MonoSingleton<OptionsManager>.Instance.paused
                && !MonoSingleton<NewMovement>.Instance.dead
            ) {
                if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerBlue.value)) {
                    Plugin.EquipWeapon(Guns.RevovlerBlue);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerGreen.value)) {
                    Plugin.EquipWeapon(Guns.RevovlerGreen);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerRed.value)) {
                    Plugin.EquipWeapon(Guns.RevovlerRed);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunBlue.value)) {
                    Plugin.EquipWeapon(Guns.ShotgunBlue);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunGreen.value)) {
                    Plugin.EquipWeapon(Guns.ShotgunGreen);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunRed.value)) {
                    Plugin.EquipWeapon(Guns.ShotgunRed);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunBlue.value)) {
                    Plugin.EquipWeapon(Guns.NailgunBlue);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunGreen.value)) {
                    Plugin.EquipWeapon(Guns.NailgunGreen);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunRed.value)) {
                    Plugin.EquipWeapon(Guns.NailgunRed);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonBlue.value)) {
                    Plugin.EquipWeapon(Guns.RailBlue);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonGreen.value)) {
                    Plugin.EquipWeapon(Guns.RailGreen);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonRed.value)) {
                    Plugin.EquipWeapon(Guns.RailRed);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RocketBlue.value)) {
                    Plugin.EquipWeapon(Guns.RocketBlue);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RocketGreen.value)) {
                    Plugin.EquipWeapon(Guns.RocketGreen);
                } else if (UnityInput.Current.GetKeyDown(PluginConfig.RocketRed.value)) {
                    Plugin.EquipWeapon(Guns.RocketRed);
                }
            }
        }
    }
}
