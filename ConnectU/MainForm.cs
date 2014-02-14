using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ConnectU
{
    public partial class MainForm : Form
    {
        private AboutBox aboutbox;
        private Panel activePanel;
        private Process process;
        private ProcessStartInfo startInfo;

        public MainForm()
        {
            InitializeComponent();
            activePanel = startpanel;
            loginpanel.Visible = false;
            process = new Process();
        }

        private void switchPanel(Panel panel) {
            activePanel.Visible = false;
            activePanel = panel;
            activePanel.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void startpage_cancel_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            aboutbox = new AboutBox();
            aboutbox.ShowDialog();
        }

        private void username_box_Enter(object sender, EventArgs e)
        {
            if (this.username_box.Text == "[username]")
            {
                this.username_box.Text = "";
            }
        }

        private void username_box_Leave(object sender, EventArgs e)
        {
            if (this.username_box.Text.Length == 0)
            {
                this.username_box.Text = "[username]";
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (this.passwordBox.Text == "password")
            {
                this.passwordBox.Text = "";
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {
            if (this.passwordBox.Text.Length == 0)
            {
                this.passwordBox.Text = "password";
            }
        }

        private void startpage_login_btn_Click(object sender, EventArgs e)
        {
            switchPanel(loginpanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.Arguments = "/C net use U: /delete /YES";
                process.StartInfo = startInfo;
                Process.Start(startInfo);
                startInfo.Arguments = "/C net use U: \\\\134.88.3.184\\studentshares$\\" + username_box.Text + " /USER:UMDAR\\" + username_box.Text + " " + passwordBox.Text;
                process.StartInfo = startInfo;
                Process.Start(startInfo);
                System.Diagnostics.Process.Start("explorer", "U:");
                DialogResult dialogResult = MessageBox.Show("Is this working?", "Just asking...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
