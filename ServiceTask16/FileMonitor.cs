using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTask16
{
    public class FileMonitor : ServiceBase
    {
        private FileSystemWatcher _watcher;
        private readonly string _folderToWatch = @"F:\temp";
        private readonly string _logFile = @"F:\FileMonitorLog.txt";

        public FileMonitor()
        {
            this.ServiceName = "FileMonitorService";
            this.AutoLog = false;
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
