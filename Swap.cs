using BepInEx;


namespace Easy_Swap
{
    public class Swap
    {

        public enum Guns
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


        // Swap to the appropriate weapon when the set bind is pressed
        public static void SwapOnKeypress()
        {

            if (MonoSingleton<OptionsManager>.Instance != null && MonoSingleton<NewMovement>.Instance != null)
            {



                if (!MonoSingleton<OptionsManager>.Instance.inIntro && !MonoSingleton<OptionsManager>.Instance.paused && !MonoSingleton<NewMovement>.Instance.dead)

                {

                    /// Revovler \\\

                    #region

                    // Piercer (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerBlue.value))
                    {

                        Plugin.EquipWeapon(Guns.RevovlerBlue);

                    }



                    // Marksman (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerGreen.value))
                    {

                        Plugin.EquipWeapon(Guns.RevovlerGreen);

                    }



                    // Sharpshooter (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RevovlerRed.value))
                    {

                        Plugin.EquipWeapon(Guns.RevovlerRed);

                    }

                    #endregion


                    /// Shotgun \\\

                    #region

                    // Core Eject (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunBlue.value))
                    {

                        Plugin.EquipWeapon(Guns.ShotgunBlue);

                    }

                    // Pump (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunGreen.value))
                    {

                        Plugin.EquipWeapon(Guns.ShotgunGreen);

                    }

                    // Sawed On (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.ShotgunRed.value))
                    {

                        Plugin.EquipWeapon(Guns.ShotgunRed);

                    }


                    #endregion


                    /// Nailgun \\\

                    #region

                    // Attractor (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunBlue.value))
                    {

                        Plugin.EquipWeapon(Guns.NailgunBlue);

                    }

                    // Overheat (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunGreen.value))
                    {

                        Plugin.EquipWeapon(Guns.NailgunGreen);

                    }

                    // Jumpstart (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.NailgunRed.value))
                    {

                        Plugin.EquipWeapon(Guns.NailgunRed);

                    }

                    #endregion


                    /// Railcannon \\\

                    #region

                    // Electric (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonBlue.value))
                    {

                        Plugin.EquipWeapon(Guns.RailBlue);

                    }

                    // Screwdriver (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonGreen.value))
                    {

                        Plugin.EquipWeapon(Guns.RailGreen);

                    }

                    // Malicious (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RailcannonRed.value))
                    {

                        Plugin.EquipWeapon(Guns.RailRed);

                    }


                    #endregion


                    /// Rocket Launcher \\\

                    #region

                    // Freezeframe (BLUE)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RocketBlue.value))
                    {

                        Plugin.EquipWeapon(Guns.RocketBlue);

                    }

                    // S.R.S (GREEN)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RocketGreen.value))
                    {

                        Plugin.EquipWeapon(Guns.RocketGreen);

                    }

                    // Firestarter (RED)
                    if (UnityInput.Current.GetKeyDown(PluginConfig.RocketRed.value))
                    {

                        Plugin.EquipWeapon(Guns.RocketRed);

                    }


                    #endregion


                }



            }

        }

    }
}
