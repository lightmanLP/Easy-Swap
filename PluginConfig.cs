using GameConsole.pcon;
using PluginConfig.API;
using PluginConfig.API.Fields;
using System.IO;
using UnityEngine;


namespace Easy_Swap
{
    public class PluginConfig
    {

        /// Keybinds \\\

        #region

        // Revovler

        public static KeyCodeField RevovlerBlue;

        public static KeyCodeField RevovlerGreen;

        public static KeyCodeField RevovlerRed;


        // Shotgun

        public static KeyCodeField ShotgunBlue;

        public static KeyCodeField ShotgunGreen;

        public static KeyCodeField ShotgunRed;


        // Nailgun

        public static KeyCodeField NailgunBlue;

        public static KeyCodeField NailgunGreen;

        public static KeyCodeField NailgunRed;


        // Railcannon

        public static KeyCodeField RailcannonBlue;

        public static KeyCodeField RailcannonGreen;

        public static KeyCodeField RailcannonRed;


        // Rocket Launcher

        public static KeyCodeField RocketBlue;

        public static KeyCodeField RocketGreen;

        public static KeyCodeField RocketRed;

        #endregion

        public static void InitConfig()
        {
            var config = PluginConfigurator.Create("Easy Swap", Plugin.GUID);
            config.SetIconWithURL($"{Path.Combine(Easy_Swap.Plugin.AssemblyFolder, "icon.png")}");

            
            /// Keybinds \\\

            #region

            Color[] variantColors = Plugin.GetVariantColors();


            // Revovler \\

            ConfigPanel RevovlerContainer = new ConfigPanel(config.rootPanel, "Revovler", "revlovPanelES");


            RevovlerBlue = new KeyCodeField(RevovlerContainer, "Revovler (Piercer)", "RevlovES1", KeyCode.None);
            RevovlerBlue.fieldColor = variantColors[0];

            RevovlerGreen = new KeyCodeField(RevovlerContainer, "Revovler (Marksman)", "RevlovES2", KeyCode.None);
            RevovlerGreen.fieldColor = variantColors[1];

            RevovlerRed = new KeyCodeField(RevovlerContainer, "Revovler (Sharpshooter)", "RevlovES3", KeyCode.None);
            RevovlerRed.fieldColor = variantColors[2];


            // Shotgun \\

            ConfigPanel ShotgunContainer = new ConfigPanel(config.rootPanel, "Shotgun", "ShotPanelES");


            ShotgunBlue = new KeyCodeField(ShotgunContainer, "Shotgun (Core Eject)", "ShotES1", KeyCode.None);
            ShotgunBlue.fieldColor = variantColors[0];

            ShotgunGreen = new KeyCodeField(ShotgunContainer, "Shotgun (Pump)", "ShotES2", KeyCode.None);
            ShotgunGreen.fieldColor = variantColors[1];

            ShotgunRed = new KeyCodeField(ShotgunContainer, "Shotgun (Sawed On)", "ShotES3", KeyCode.None);
            RevovlerRed.fieldColor = variantColors[2];


            // Nailgun \\

            ConfigPanel NailgunContainer = new ConfigPanel(config.rootPanel, "Nailgun", "NailPanelES");


            NailgunBlue = new KeyCodeField(NailgunContainer, "Nailgun (Attractor)", "NailES1", KeyCode.None);
            NailgunBlue.fieldColor = variantColors[0];

            NailgunGreen = new KeyCodeField(NailgunContainer, "Nailgun (Overheat)", "NailES2", KeyCode.None);
            NailgunGreen.fieldColor = variantColors[1];

            NailgunRed = new KeyCodeField(NailgunContainer, "Nailgun (Jumpstart)", "NailES3", KeyCode.None);
            NailgunRed.fieldColor = variantColors[2];


            // Railcannon \\

            ConfigPanel RailcannonContainer = new ConfigPanel(config.rootPanel, "Railcannon", "railPanelES");


            RailcannonBlue = new KeyCodeField(RailcannonContainer, "Railcannon (Electric)", "RailES1", KeyCode.None);
            RailcannonBlue.fieldColor = variantColors[0];

            RailcannonGreen = new KeyCodeField(RailcannonContainer, "Railcannon (Screwdriver)", "RailES2", KeyCode.None);
            RailcannonGreen.fieldColor = variantColors[1];

            RailcannonRed = new KeyCodeField(RailcannonContainer, "Railcannon (Malicious)", "RailES3", KeyCode.None);
            RailcannonRed.fieldColor = variantColors[2];


            // Rocket Launcher \\

            ConfigPanel RocketContainer = new ConfigPanel(config.rootPanel, "Rocket Launcher", "railPanelES");


            RocketBlue = new KeyCodeField(RocketContainer, "Rocket (Freeze Frame)", "RocketES1", KeyCode.None);
            RocketBlue.fieldColor = variantColors[0];

            RocketGreen = new KeyCodeField(RocketContainer, "Rocket (S.R.S)", "RocketlES2", KeyCode.None);
            RocketGreen.fieldColor = variantColors[1];

            RocketRed = new KeyCodeField(RocketContainer, "Rocket (Firestarter)", "RocketES3", KeyCode.None);
            RocketRed.fieldColor = variantColors[2];

            #endregion

        }

    }
}
