using PluginConfig.API;
using PluginConfig.API.Fields;
using System.IO;
using System.Collections.Generic;
using UnityEngine;


namespace EasySwap
{
    public class PluginConfig
    {
        // Revolver
        public static KeyCodeField RevolverBlue;
        public static KeyCodeField RevolverRed;
        public static KeyCodeField RevolverGreen;
        public static List<BoolField> RevolverRotEnabled;

        // Shotgun
        public static KeyCodeField ShotgunBlue;
        public static KeyCodeField ShotgunGreen;
        public static KeyCodeField ShotgunRed;
        public static List<BoolField> ShotgunRotEnabled;

        // Nailgun
        public static KeyCodeField NailgunBlue;
        public static KeyCodeField NailgunGreen;
        public static KeyCodeField NailgunRed;
        public static List<BoolField> NailgunRotEnabled;

        // Railcannon
        public static KeyCodeField RailcannonBlue;
        public static KeyCodeField RailcannonGreen;
        public static KeyCodeField RailcannonRed;
        public static List<BoolField> RailRotEnabled;

        // Rocket Launcher
        public static KeyCodeField RocketBlue;
        public static KeyCodeField RocketGreen;
        public static KeyCodeField RocketRed;
        public static List<BoolField> RocketRotEnabled;

        // Initialize the Plugin Config
        public static void InitConfig() {
            var config = PluginConfigurator.Create("Easy Swap", Plugin.GUID);
            config.SetIconWithURL($"{Path.Combine(EasySwap.Plugin.AssemblyFolder, "icon.png")}");

            Color[] variantColors = Plugin.GetVariantColors();

            ConfigPanel RevolverContainer = new ConfigPanel(config.rootPanel, "Revolver", "revlovPanelES");
            RevolverRotEnabled = new List<BoolField>();

            RevolverBlue = new KeyCodeField(RevolverContainer, "Revolver (Piercer)", "RevlovES1", KeyCode.None);
            RevolverBlue.fieldColor = variantColors[0];
            RevolverRotEnabled.Add(new BoolField(RevolverContainer, "Allow rotation", "rev0rot", true));

            RevolverGreen = new KeyCodeField(RevolverContainer, "Revolver (Marksman)", "RevlovES2", KeyCode.None);
            RevolverGreen.fieldColor = variantColors[1];
            RevolverRotEnabled.Add(new BoolField(RevolverContainer, "Allow rotation", "rev2rot", true));

            RevolverRed = new KeyCodeField(RevolverContainer, "Revolver (Sharpshooter)", "RevlovES3", KeyCode.None);
            RevolverRed.fieldColor = variantColors[2];
            RevolverRotEnabled.Insert(1, new BoolField(RevolverContainer, "Allow rotation", "rev1rot", true));

            ConfigPanel ShotgunContainer = new ConfigPanel(config.rootPanel, "Shotgun", "ShotPanelES");
            ShotgunRotEnabled = new List<BoolField>();

            ShotgunBlue = new KeyCodeField(ShotgunContainer, "Shotgun (Core Eject)", "ShotES1", KeyCode.None);
            ShotgunBlue.fieldColor = variantColors[0];
            ShotgunRotEnabled.Add(new BoolField(ShotgunContainer, "Allow rotation", "shot0rot", true));

            ShotgunGreen = new KeyCodeField(ShotgunContainer, "Shotgun (Pump)", "ShotES2", KeyCode.None);
            ShotgunGreen.fieldColor = variantColors[1];
            ShotgunRotEnabled.Add(new BoolField(ShotgunContainer, "Allow rotation", "shot1rot", true));

            ShotgunRed = new KeyCodeField(ShotgunContainer, "Shotgun (Sawed On)", "ShotES3", KeyCode.None);
            ShotgunRed.fieldColor = variantColors[2];
            ShotgunRotEnabled.Add(new BoolField(ShotgunContainer, "Allow rotation", "shot2rot", true));

            ConfigPanel NailgunContainer = new ConfigPanel(config.rootPanel, "Nailgun", "NailPanelES");
            NailgunRotEnabled = new List<BoolField>();

            NailgunBlue = new KeyCodeField(NailgunContainer, "Nailgun (Attractor)", "NailES1", KeyCode.None);
            NailgunBlue.fieldColor = variantColors[0];
            NailgunRotEnabled.Add(new BoolField(NailgunContainer, "Allow rotation", "nai0rot", true));

            NailgunGreen = new KeyCodeField(NailgunContainer, "Nailgun (Overheat)", "NailES2", KeyCode.None);
            NailgunGreen.fieldColor = variantColors[1];
            NailgunRotEnabled.Add(new BoolField(NailgunContainer, "Allow rotation", "nai1rot", true));

            NailgunRed = new KeyCodeField(NailgunContainer, "Nailgun (Jumpstart)", "NailES3", KeyCode.None);
            NailgunRed.fieldColor = variantColors[2];
            NailgunRotEnabled.Add(new BoolField(NailgunContainer, "Allow rotation", "nai2rot", true));

            ConfigPanel RailcannonContainer = new ConfigPanel(config.rootPanel, "Railcannon", "railPanelES");
            RailRotEnabled = new List<BoolField>();

            RailcannonBlue = new KeyCodeField(RailcannonContainer, "Railcannon (Electric)", "RailES1", KeyCode.None);
            RailcannonBlue.fieldColor = variantColors[0];
            RailRotEnabled.Add(new BoolField(RailcannonContainer, "Allow rotation", "rai0rot", true));

            RailcannonGreen = new KeyCodeField(RailcannonContainer, "Railcannon (Screwdriver)", "RailES2", KeyCode.None);
            RailcannonGreen.fieldColor = variantColors[1];
            RailRotEnabled.Add(new BoolField(RailcannonContainer, "Allow rotation", "rai1rot", true));

            RailcannonRed = new KeyCodeField(RailcannonContainer, "Railcannon (Malicious)", "RailES3", KeyCode.None);
            RailcannonRed.fieldColor = variantColors[2];
            RailRotEnabled.Add(new BoolField(RailcannonContainer, "Allow rotation", "rai2rot", true));

            ConfigPanel RocketContainer = new ConfigPanel(config.rootPanel, "Rocket Launcher", "railPanelES");
            RocketRotEnabled = new List<BoolField>();

            RocketBlue = new KeyCodeField(RocketContainer, "Rocket (Freeze Frame)", "RocketES1", KeyCode.None);
            RocketBlue.fieldColor = variantColors[0];
            RocketRotEnabled.Add(new BoolField(RocketContainer, "Allow rotation", "rock0rot", true));

            RocketGreen = new KeyCodeField(RocketContainer, "Rocket (S.R.S)", "RocketlES2", KeyCode.None);
            RocketGreen.fieldColor = variantColors[1];
            RocketRotEnabled.Add(new BoolField(RocketContainer, "Allow rotation", "rock1rot", true));

            RocketRed = new KeyCodeField(RocketContainer, "Rocket (Firestarter)", "RocketES3", KeyCode.None);
            RocketRed.fieldColor = variantColors[2];
            RocketRotEnabled.Add(new BoolField(RocketContainer, "Allow rotation", "rock2rot", true));
        }


    }
}
