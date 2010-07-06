using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DMS.Shared;
using System.IO;
namespace DMS.Core
{
    [Serializable]
    public class GlobalPaths
    {
        /// <summary>
        /// Initialize
        /// </summary>
        public GlobalPaths() { }
        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="startuppath">path to main application</param>
        public GlobalPaths(string startuppath)
            : this()
        {
            this.StartupPath = startuppath;
            SetSystemFolderPaths();
        }
        /// <summary>
        /// path where system icon and images are kept
        /// </summary>
        public string PlaceholderPath { get; private set; }


        public string StartupPath { get; private set; }      //application startup path

        /*top folder structure*/
        /// <summary>
        ///path to save logs
        /// </summary>
        public string LogPath { get; private set; }
        /// <summary>
        /// path to save help files
        /// </summary>
        public string HelpPath { get; private set; }
        /// <summary>
        /// path to manual
        /// </summary>
        public string ManualPath { get; private set; }
        /// <summary>
        /// path to save plugins/modules
        /// </summary>
        public string SystemPluginPath { get; set; }
        /// <summary>
        /// path to save plugins/modules
        /// </summary>
        public string OtherPluginPath { get; private set; }
        /// <summary>
        /// path to save configuration files / settings
        /// </summary>
        public string ConfigPath { get; private set; }
        /// <summary>
        /// image file to show on startup
        /// </summary>
        public string StartupImage { get; private set; }

        /// <summary>
        /// datafolder path
        /// </summary>
        public string DataFolderPath { get; private set; }

        /// <summary>
        /// selected path to put backup files
        /// </summary>
        public string CandidateBackupPath { get; set; }
        /// <summary>
        /// selected path to fetch import files
        /// </summary>
        private void SetSystemFolderPaths()
        {
            HelpPath = Path.Combine(StartupPath, @"Help");
            ManualPath = Path.Combine(HelpPath, @"Manual.pdf");
            SystemPluginPath = Path.Combine(StartupPath, "Plugins");
            UtilPath = Path.Combine(StartupPath, "Utils");
            LogPath = Path.Combine(StartupPath, "Logs");
            ConfigPath = Path.Combine(StartupPath, "Config");
            PlaceholderPath = Path.Combine(UtilPath, "Placeholders");
            StartupImage = Path.Combine(UtilPath, @"Startup\____startup.png");
            PlaceholderPDF = Path.Combine(PlaceholderPath, "____DMS____pdf.png");
            PlaceholderTXT = Path.Combine(PlaceholderPath, "____DMS____txt.png");
            PlaceholderWMP = Path.Combine(PlaceholderPath, "____DMS____wmp.png");
            PlaceholderWEB = Path.Combine(PlaceholderPath, "____DMS____web.png");
            PlaceholderUNK = Path.Combine(PlaceholderPath, "____DMS____unk.png");
        }

    }
}
