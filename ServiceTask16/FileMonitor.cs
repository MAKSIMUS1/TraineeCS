using System;
using System.IO;
using System.ServiceProcess;
using System.Configuration;

namespace ServiceTask16
{
    public class FileMonitor : ServiceBase
    {
        private FileSystemWatcher _watcher;

        private readonly string _folderToWatch;
        private readonly string _logFile;

        public FileMonitor()
        {
            this.ServiceName = "FileMonitorService";
            this.AutoLog = false;

            _folderToWatch = ConfigurationManager.AppSettings["FolderToWatch"];
            _logFile = ConfigurationManager.AppSettings["LogFile"];
        }
        protected override void OnStart(string[] args)
        {
            Directory.CreateDirectory(_folderToWatch);

            _watcher = new FileSystemWatcher(_folderToWatch);
            _watcher.EnableRaisingEvents = true;
            _watcher.IncludeSubdirectories = true;
            _watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;

            _watcher.Deleted += OnDeleted;

            Log("Service started");
        }
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Log($"DELETED: {e.FullPath}");
        }
        private void Log(string text)
        {
            File.AppendAllText(_logFile, $"[{DateTime.Now}] {text}\n");
        }
        protected override void OnStop()
        {
            Log("Service stopped");
            _watcher?.Dispose();
        }

        private void InitializeComponent()
        {
            // 
            // FileMonitor
            // 
            this.ServiceName = "FileMonitorService";

        }
    }
}
