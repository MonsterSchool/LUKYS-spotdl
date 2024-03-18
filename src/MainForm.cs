using System.Diagnostics;
using System.Reflection;

namespace lukys_spotdl
{
    public partial class MainForm : Form
    {
        private Process cmd1 = new Process();
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            // cmd1.OutputDataReceived += (object sender, System.Diagnostics.DataReceivedEventArgs e) => printText(e.Data);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Process
            cmd1.StartInfo.FileName = "cmd.exe";
            cmd1.StartInfo.RedirectStandardInput = true;
            cmd1.StartInfo.RedirectStandardOutput = true;
            cmd1.StartInfo.CreateNoWindow = true;
            cmd1.StartInfo.UseShellExecute = false;

            cmd1.Start();
            cmd1.BeginOutputReadLine();

            lblVersion.Text = "Version: " + Assembly.GetEntryAssembly().GetName().Version;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }
    }
}
