using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Windows.Forms;


namespace FileMonitorWinForm
{
    public partial class FileMonitorForm : Form
    {
        private readonly string ServiceName = ConfigurationManager.AppSettings["ServiceName"];
        private readonly string LogFile = ConfigurationManager.AppSettings["LogFile"];
        private readonly string ServiceFile = ConfigurationManager.AppSettings["ServiceExecutable"];
        private readonly string InstallUtilFile = ConfigurationManager.AppSettings["InstallUtil"];

        public FileMonitorForm()
        {
            InitializeComponent();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            RunInstallUtil($@"""{ServiceFile}""");
            MessageBox.Show("Служба установлена");
        }
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            RunInstallUtil($@"/u ""{ServiceFile}""");
            MessageBox.Show("Служба удалена");
        }
         private void btnStart_Click(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController(ServiceName);
            sc.Start();
            sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(5));
            MessageBox.Show($"Служба {ServiceName}  запущена");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ServiceController sc = new ServiceController(ServiceName);
            sc.Stop();
            sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(5));
            MessageBox.Show($"Служба {ServiceName}  остановлена");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(LogFile))
                textBoxLog.Text = File.ReadAllText(LogFile);

            FileSystemWatcher watcher = new FileSystemWatcher(Path.GetDirectoryName(LogFile));
            watcher.Filter = Path.GetFileName(LogFile);
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Changed += (s, ev) =>
            {
                Invoke(new Action(() =>
                {
                    textBoxLog.Text = File.ReadAllText(LogFile);
                }));
            };
            watcher.EnableRaisingEvents = true;
        }

        private void RunInstallUtil(string arguments)
        {
            var psi = new ProcessStartInfo
            {
                FileName = InstallUtilFile,          
                Arguments = arguments,               
                Verb = "runas",                      
                UseShellExecute = true,              
                WindowStyle = ProcessWindowStyle.Normal
            };

            using (var process = Process.Start(psi))
            {
                process.WaitForExit();
            }
        }

    }
}
