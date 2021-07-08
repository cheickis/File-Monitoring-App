//Main class. Contais all logic to monitor a share folder file into into other folder
//Main gaol of this app is to copy data from the robot computer into to the suite case computer while
//devices (Talin, Velodyne, sick ...) are writing the data to a file.
// We using window filesystemwatcher in this programm

//Created by Cheick Ismael MAIGA: 2020-02-10
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Threading;
using System.Security.Permissions;


namespace Penguin_File_Monitoring_App
{
    public partial class PenguinFileMonitorForm : MetroFramework.Forms.MetroForm
    {
        #region Variable
        private static String watcherFolderPath;
        private static  String destinationFolderDirectoryPath;
        private ObservableCollection<String> mainPagelogStatusCollector;
        private ObservableCollection<String> logCollector;
        private ObservableCollection<String> sourceLogTxtBCollector;
        private ObservableCollection<String> destinationLogTxtBCollector;

        private List<String> files;

        private FileSystemWatcher watcher;

        private delegate void MonitorFiledlg();
        private MonitorFiledlg fileMonitordlg;



        private object m_lockMonitoringThread = new object();
        private bool m_isRunningMonitorinThread = false;
        private bool m_isAbortRequestedMonitoringThread = false;

        delegate void SafeCallDelegate(MetroTextBox txtB, ObservableCollection<string> obs);

        private static Boolean onChangeMonitoringStatus = false;
        #endregion

        #region Winform
        public PenguinFileMonitorForm()
        {
            InitializeComponent();
            fileMonitordlg = new MonitorFiledlg(MonitorsAllFiles);
            InitWacther();
            InitCollectors();
            watcherFolderPath = @"Y:\";
            destinationFolderDirectoryPath = @"X:\";
        }

        private void PenguinFileMonitorForm_Load(object sender, EventArgs e)
        {
            sourceLogTxtB.AppendText(FeatureMessage.defaultdFolderLogdMsg + watcherFolderPath);
            sourceLogTxtB.AppendText(Environment.NewLine);

            destinationLogTxtB.AppendText(FeatureMessage.defaultdFolderLogdMsg + destinationFolderDirectoryPath);
            destinationLogTxtB.AppendText(Environment.NewLine);

           

        }

        #endregion

        #region Button
        private void StartMonitoringtoolStripBtn_Click(object sender, EventArgs e)
        {
            MonitoringThread();
        }
        private void WactcherFolderBtn_Click(object sender, EventArgs e)
        {
            watcherFolderPath = GetAFolderName();
            if (watcherFolderPath != null)
            {
               
                sourceLogTxtB.Clear();
                sourceLogTxtBCollector.Add(FeatureMessage.folderLogdMsg + watcherFolderPath);
                watcher.Path = watcherFolderPath;
            }

        }
        private void SaveFolderBtn_Click(object sender, EventArgs e)
        {
            destinationFolderDirectoryPath = GetAFolderName();
            if (destinationFolderDirectoryPath != null)
            {
                
                destinationLogTxtB.Clear();
                destinationLogTxtBCollector.Add(FeatureMessage.folderLogdMsg + destinationFolderDirectoryPath);
            }
        }
        private String GetAFolderName()
        {
           
                FolderBrowserDialog temp = new FolderBrowserDialog();
                DialogResult result = temp.ShowDialog();
                if (result == DialogResult.OK)
                {

                    try
                    {
                         return temp.SelectedPath;
                     } 
                   
                    catch (IOException)
                    {
                        MessageBox.Show(this, FeatureMessage.invalidFolderPathMsg, "Invalid Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                   
            return null;

        }
        #endregion

        #region Collector
        private void InitCollectors()
        {
            mainPagelogStatusCollector = new ObservableCollection<string>();
            logCollector = new ObservableCollection<string>();
            sourceLogTxtBCollector = new ObservableCollection<string>();
            destinationLogTxtBCollector = new ObservableCollection<string>();

            mainPagelogStatusCollector.CollectionChanged += UpdateMainPageLogTxtB;
            logCollector.CollectionChanged += UpdateLogTxtBox;

            sourceLogTxtBCollector.CollectionChanged += UpdateDirectoryTxtBox;

            destinationLogTxtBCollector.CollectionChanged += UpdateFilesTxtBox;
        }

        private void ClearCollectorDatas()
        {
            mainPagelogStatusCollector.Clear();
            logCollector.Clear();
            sourceLogTxtBCollector.Clear();
            destinationLogTxtBCollector.Clear();
        }

        private void UpdateFilesTxtBox(object sender, NotifyCollectionChangedEventArgs e)
        {
            UpdateTxtBWithDataCollector(destinationLogTxtB, destinationLogTxtBCollector);
        }

        private void UpdateDirectoryTxtBox(object sender, NotifyCollectionChangedEventArgs e)
        {

            UpdateTxtBWithDataCollector(sourceLogTxtB, sourceLogTxtBCollector);
        }

        private void UpdateMainPageLogTxtB(object sender, NotifyCollectionChangedEventArgs e)
        {
            UpdateTxtBWithDataCollector(mainPagelogTxt, mainPagelogStatusCollector);
        }

        private void UpdateLogTxtBox(object sender, NotifyCollectionChangedEventArgs e)
        {
            UpdateTxtBWithDataCollector(logPageTxtB, logCollector);
        }
        #endregion

        #region Watcher

        private void InitWacther()
        {

            files = new List<string>();
            watcher = new FileSystemWatcher();
           
        }
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void RunWatcher()
        {

            try
            {
                watcher.Path = watcherFolderPath;  //can  throw exception if path is invalid
            }
            catch (Exception)
            {
                MessageBox.Show(this,FeatureMessage.invalidFolderPathClosingAppMsg,"Invalid Folder Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

           

            watcher.NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;
            watcher.Created += OnCreated;

            watcher.Filter = "*.txt";
            watcher.EnableRaisingEvents = true;
        }

        /// <summary>
        /// notify when the file was modified. This event happend when the writting buffer are closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            
            if (Path.GetFileName(e.FullPath).Contains("ScanData"))
            {
                watcher.Changed -= OnChanged;
                watcher.Created += OnCreated;
            }
        }
        /// <summary>
        /// Notify when a new file was created in the source folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            files.Add(e.FullPath);
            SetObservableCollectionValuesFromOnCreatedEvent( e);
            if (Path.GetFileName(e.FullPath).Contains("ScanData"))
            {
                watcher.Changed += OnChanged;
                watcher.Created -= OnCreated;
                MonitorsAllFiles();
            }
        }
        #endregion

        #region Monotoring Process
       
        /// <summary>
        /// Fucntion used to process all file in the source folder
        /// For now we copyig Talin file and velodyne file. For more files, the condition have to be change 
        /// and use parralel.for of C# system.threading.Task
        /// </summary>
        private void MonitorsAllFiles()
        { 
            if (files.Count == 2)  
            {
                Thread.Sleep(500);
                try
                {
                    Parallel.Invoke(() => ProcessTalinFile(), () => MonotoriseFile(files.ElementAt(1), 0));
                }
                catch(IOException)
                {

                    MessageBox.Show(this, FeatureMessage.netWworkPahtMsg, "Network Communication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Environment.Exit(0);

                }
              
            }
          
        }

        /// <summary>
        /// This function is use to process (copy talin dans form the robot computer to the suite case computer
        ///Talin talin taking more time to write is data into the file. So we need some delay before starting the reading
        ///The value of the delay sleep is get by tuning the value. So it not 100% accurate
        /// </summary>
        private void ProcessTalinFile()
        {

            Thread.Sleep(700);
            MonotoriseFile(files.ElementAt(0), 150);
        }

        /// <summary>
        /// this is the main function of the processing. In parameter the path of the file that need to be copy and the delay
        /// before starting the reading. the system is just open the file in read and share mode because the file is open by another process
        /// and copy it to another file. In the roboto computer the file is open  by a process which continously writing. for that
        /// we cannont used the readall functio of the system.IO
        /// </summary>
        /// <param name="path"></param>
        /// <param name="time"></param>
        private void MonotoriseFile(String path, int time)
        {

            string filePath = destinationFolderDirectoryPath +"\\" + Path.GetFileName(path);
            Int64 size = 0;
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            using (StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.CreateNew)))
                {
                    string line;
                    destinationLogTxtBCollector.Add(FeatureMessage.fileLogdMsg + filePath);
                    mainPagelogStatusCollector.Add(FeatureMessage.fileCreatedMsg + filePath + " " + new FileInfo(filePath).LastWriteTime);
                    while ((line = sr.ReadLine()) != null)
                    {
                        size += System.Text.Encoding.ASCII.GetByteCount(line);
                        sw.WriteLine(line);
                        logCollector.Add("File: " + filePath + "  " + FeatureMessage.copyingLogdMsg + FormatBytes(size));
                        Thread.Sleep(time);
                    }
                    sw.Close();
                   SetObservableCollectionValueWhenAProcessisFinished(path, filePath, size);
            }
        }

        #endregion

        #region  Monitoring Thread Management


        private void MonitoringThread()
        {
            lock (m_lockMonitoringThread)
            {
                if (m_isRunningMonitorinThread)
                {
                    m_isAbortRequestedMonitoringThread = true;

                }
                else
                {
                    m_isAbortRequestedMonitoringThread = false;
                    m_isRunningMonitorinThread = true;
                    ThreadPool.QueueUserWorkItem(o => MonitoringBackgroundMethod());
                }
            }
        }
        private void MonitoringBackgroundMethod()
        {
            try
            {
                DoMonitoringRealWork();
            }
            finally
            {
                lock (m_lockMonitoringThread)
                {
                    m_isRunningMonitorinThread = false;
                }
            }
        }
        private void DoMonitoringRealWork()
        {
            RunWatcher();

            onChangeMonitoringStatus = true;
            UpdateStatusToolStrioIcon();
            wactcherFolderBtn.Enabled = false;
           destinationFolderBtn.Enabled = false;

            while (true)
            {
               
                if (m_isAbortRequestedMonitoringThread)
                {
                    DialogResult dr = MessageBox.Show(this, FeatureMessage.stopMonitoringDialgMsg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        ClearCollectorDatas();
                        wactcherFolderBtn.Enabled = true;
                        destinationFolderBtn.Enabled = true;
                        onChangeMonitoringStatus = false;
                        wactcherFolderBtn.Enabled = true;
                        destinationFolderBtn.Enabled = true;
                        UpdateStatusToolStrioIcon();
                        return;
                    }
                    else
                    {
                        m_isAbortRequestedMonitoringThread = false;
                    }
                }

            }

        }

        #endregion

        #region Menu Item Click Event
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }


        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, FeatureMessage.copyrightPathMsg, "Invalid Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


        #region Helper

        private string FormatBytes(Int64 bytes)
        {
            if (bytes >= 0x1000000000000000) { return ((double)(bytes >> 50) / 1024).ToString("0.### EB"); }
            if (bytes >= 0x4000000000000) { return ((double)(bytes >> 40) / 1024).ToString("0.### PB"); }
            if (bytes >= 0x10000000000) { return ((double)(bytes >> 30) / 1024).ToString("0.### TB"); }
            if (bytes >= 0x40000000) { return ((double)(bytes >> 20) / 1024).ToString("0.### GB"); }
            if (bytes >= 0x100000) { return ((double)(bytes >> 10) / 1024).ToString("0.### MB"); }
            if (bytes >= 0x400) { return ((double)(bytes) / 1024).ToString("0.###") + " KB"; }
            return bytes.ToString("0 Bytes");
        }

        private void UpdateTxtBWithDataCollector(MetroTextBox txtB, ObservableCollection<string> obs)
        {

            if (txtB.InvokeRequired)
            {

                txtB.Invoke(new MethodInvoker(delegate {

                    if (obs.Count > 0)
                    {
                        
                        txtB.AppendText(obs.ElementAt(obs.Count - 1));
                        txtB.AppendText(Environment.NewLine);
                    }

                }));
            }
            else if (obs.Count > 0)
            {

                txtB.AppendText(obs.ElementAt(obs.Count - 1));
                txtB.AppendText(Environment.NewLine);
            }



            /* if (txtB.InvokeRequired)
              {
                  var d = new SafeCallDelegate(WriteSafetText);

                  txtB.Invoke(d, new object[] { txtB, obs });
              }*/

        }

        private void WriteSafetText(MetroTextBox txtB, ObservableCollection<string> obs)
        {
            if (obs.Count > 0)
            {

                txtB.AppendText(obs.ElementAt(obs.Count - 1));
                txtB.AppendText(Environment.NewLine);
            }
        }

        private void UpdateStatusToolStrioIcon()
        {
            if (onChangeMonitoringStatus == true)
            {
                monitoringStatustoolStripBtn.Enabled = true;
                monitoringStatustoolStripBtn.Image = Properties.Resources.iconfinder_Eye_85364;
                monitoringStatustoolStripBtn.ToolTipText = "Monotoring ...";
            }
            else
            {

                monitoringStatustoolStripBtn.Image = Properties.Resources.iconfinder___Eye_Show_View_Watch_See_Disable_Inactive_Unavailable_Off_3844412;
                monitoringStatustoolStripBtn.ToolTipText = "Stop Monotoring";
                monitoringStatustoolStripBtn.Enabled = false;
            }
        }

        private void SetObservableCollectionValuesFromOnCreatedEvent(FileSystemEventArgs e)
        {
            String message = FeatureMessage.fileCreatedMsg + e.FullPath;
            mainPagelogStatusCollector.Add(message + " " + new FileInfo(e.FullPath).LastWriteTime);
            logCollector.Add(FeatureMessage.fileCreatedMsg + e.FullPath);
            sourceLogTxtBCollector.Add(FeatureMessage.fileLogdMsg + e.FullPath);
        }


        private void SetObservableCollectionValueWhenAProcessisFinished(string path, string filePath ,Int64 size)
        {
            logCollector.Add(FeatureMessage.endOfMonitoringdMsg + path);
            mainPagelogStatusCollector.Add(FeatureMessage.fileChangedMsg + path + " at:" + new FileInfo(filePath).LastWriteTime + " Size: " + FormatBytes(new FileInfo(filePath).Length));
            mainPagelogStatusCollector.Add(FeatureMessage.fileChangedMsg + filePath + " at:" + new FileInfo(filePath).LastWriteTime + " " + FeatureMessage.copyingLogdMsg + FormatBytes(size));

        }
        #endregion

    }
}
