using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_File_Monitoring_App
{
    class FeatureMessage
    {
        #region regular Message
        public const string watcherFolderMsg = @"This is the watcher folder:";
        public const string savingFolderMsg = @"Files will be copy and saves in this folder:";

        #endregion

        #region Dialogue Message
        public const string stopMonitoringDialgMsg = @"Do you want to stop Monitoring? ";

        #endregion

        #region User Messages
        public const string readyForNewMonitoringMsg = @"Ready for a new Monitoring";

        public const string fileChangedMsg = @"Changed :";
        public const string fileCreatedMsg = @"Created :";
        public const string fileDeletedMsg = @"Deleted :";
        public const string fileRenamedMsg = @"Renamed :";
        internal static string copyrightPathMsg = @"Penguin Asi. Copyright @ 2020. All right reserved ";
        internal static string quitMsg = @"Penguin Asi. Copyright @ 2020. All right reserved ";
        #endregion

        #region Help Message

        #endregion

        #region Log Message
        public const string endOfMonitoringdMsg = @"End Monotoring file :";
        public const string startOfMonitoringdMsg = @"Start Monotoring file :";
        public const string copyingLogdMsg = @"Size of datas copied=";
        public const string folderLogdMsg = @"Folder directory= ";
        public const string defaultdFolderLogdMsg = @"Default Folder directory= ";
        public const string fileLogdMsg  = @"File =";

        #endregion

        #region Error Exception
        public const string invalidFolderPathClosingAppMsg = @"Invalid folder path. The App will be close. Try again by chosing the right folder";
        public const string invalidFolderPathMsg = @"Invalid folder path. ";
        public const String netWworkPahtMsg = @"Network communication Error : The network path was not found. The app will close. Check the connection and try";
        #endregion

    }
}
