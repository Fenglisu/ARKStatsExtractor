﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARKBreedingStats.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastSaveFile {
            get {
                return ((string)(this["LastSaveFile"]));
            }
            set {
                this["LastSaveFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("51")]
        public int consideredStats {
            get {
                return ((int)(this["consideredStats"]));
            }
            set {
                this["consideredStats"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("900, 700")]
        public global::System.Drawing.Size formSize {
            get {
                return ((global::System.Drawing.Size)(this["formSize"]));
            }
            set {
                this["formSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 100")]
        public global::System.Drawing.Point formLocation {
            get {
                return ((global::System.Drawing.Point)(this["formLocation"]));
            }
            set {
                this["formLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int[] columnWidths {
            get {
                return ((int[])(this["columnWidths"]));
            }
            set {
                this["columnWidths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool autosave {
            get {
                return ((bool)(this["autosave"]));
            }
            set {
                this["autosave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int autosaveMinutes {
            get {
                return ((int)(this["autosaveMinutes"]));
            }
            set {
                this["autosaveMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public double[][] customStatWeights {
            get {
                return ((double[][])(this["customStatWeights"]));
            }
            set {
                this["customStatWeights"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string[] customStatWeightNames {
            get {
                return ((string[])(this["customStatWeightNames"]));
            }
            set {
                this["customStatWeightNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int listViewSortCol {
            get {
                return ((int)(this["listViewSortCol"]));
            }
            set {
                this["listViewSortCol"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool listViewSortAsc {
            get {
                return ((bool)(this["listViewSortAsc"]));
            }
            set {
                this["listViewSortAsc"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000-01-01")]
        public global::System.DateTime lastUpdateCheck {
            get {
                return ((global::System.DateTime)(this["lastUpdateCheck"]));
            }
            set {
                this["lastUpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool syncCollection {
            get {
                return ((bool)(this["syncCollection"]));
            }
            set {
                this["syncCollection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool celsius {
            get {
                return ((bool)(this["celsius"]));
            }
            set {
                this["celsius"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string lastSpecies {
            get {
                return ((string)(this["lastSpecies"]));
            }
            set {
                this["lastSpecies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool oxygenForAll {
            get {
                return ((bool)(this["oxygenForAll"]));
            }
            set {
                this["oxygenForAll"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ShooterGame")]
        public string OCRApp {
            get {
                return ((string)(this["OCRApp"]));
            }
            set {
                this["OCRApp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public double[] weaponDamages {
            get {
                return ((double[])(this["weaponDamages"]));
            }
            set {
                this["weaponDamages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string soundStarving {
            get {
                return ((string)(this["soundStarving"]));
            }
            set {
                this["soundStarving"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string soundWakeup {
            get {
                return ((string)(this["soundWakeup"]));
            }
            set {
                this["soundWakeup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string soundBirth {
            get {
                return ((string)(this["soundBirth"]));
            }
            set {
                this["soundBirth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpeechRecognition {
            get {
                return ((bool)(this["SpeechRecognition"]));
            }
            set {
                this["SpeechRecognition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("63")]
        public int weaponDamagesEnabled {
            get {
                return ((int)(this["weaponDamagesEnabled"]));
            }
            set {
                this["weaponDamagesEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int OverlayInfoDuration {
            get {
                return ((int)(this["OverlayInfoDuration"]));
            }
            set {
                this["OverlayInfoDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("160")]
        public int OCRWhiteThreshold {
            get {
                return ((int)(this["OCRWhiteThreshold"]));
            }
            set {
                this["OCRWhiteThreshold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("json/ocr.json")]
        public string ocrFile {
            get {
                return ((string)(this["ocrFile"]));
            }
            set {
                this["ocrFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int waitBeforeScreenCapture {
            get {
                return ((int)(this["waitBeforeScreenCapture"]));
            }
            set {
                this["waitBeforeScreenCapture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{species} {sex_short}{n}")]
        public string sequentialUniqueNamePattern {
            get {
                return ((string)(this["sequentialUniqueNamePattern"]));
            }
            set {
                this["sequentialUniqueNamePattern"] = value;
            }
        }
    }
}
