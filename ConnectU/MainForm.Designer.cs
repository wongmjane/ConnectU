namespace ConnectU
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startpanel = new System.Windows.Forms.Panel();
            this.about_btn = new System.Windows.Forms.Button();
            this.startpage_desc = new System.Windows.Forms.Label();
            this.startpage_header = new System.Windows.Forms.Label();
            this.startpage_cancel_btn = new System.Windows.Forms.Button();
            this.startpage_login_btn = new System.Windows.Forms.Button();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.emailsuffix_box = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startpanel.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startpanel
            // 
            this.startpanel.BackColor = System.Drawing.Color.Transparent;
            this.startpanel.Controls.Add(this.about_btn);
            this.startpanel.Controls.Add(this.startpage_desc);
            this.startpanel.Controls.Add(this.startpage_header);
            this.startpanel.Controls.Add(this.startpage_cancel_btn);
            this.startpanel.Controls.Add(this.startpage_login_btn);
            this.startpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.startpanel, "startpanel");
            this.startpanel.Name = "startpanel";
            // 
            // about_btn
            // 
            resources.ApplyResources(this.about_btn, "about_btn");
            this.about_btn.BackColor = System.Drawing.Color.Transparent;
            this.about_btn.FlatAppearance.BorderSize = 0;
            this.about_btn.ForeColor = System.Drawing.Color.Gray;
            this.about_btn.Name = "about_btn";
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // startpage_desc
            // 
            resources.ApplyResources(this.startpage_desc, "startpage_desc");
            this.startpage_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startpage_desc.Name = "startpage_desc";
            // 
            // startpage_header
            // 
            resources.ApplyResources(this.startpage_header, "startpage_header");
            this.startpage_header.ForeColor = System.Drawing.Color.DodgerBlue;
            this.startpage_header.Name = "startpage_header";
            // 
            // startpage_cancel_btn
            // 
            this.startpage_cancel_btn.BackColor = System.Drawing.Color.Gray;
            this.startpage_cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startpage_cancel_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.startpage_cancel_btn, "startpage_cancel_btn");
            this.startpage_cancel_btn.ForeColor = System.Drawing.Color.White;
            this.startpage_cancel_btn.Name = "startpage_cancel_btn";
            this.startpage_cancel_btn.UseVisualStyleBackColor = false;
            this.startpage_cancel_btn.Click += new System.EventHandler(this.startpage_cancel_btn_Click);
            // 
            // startpage_login_btn
            // 
            resources.ApplyResources(this.startpage_login_btn, "startpage_login_btn");
            this.startpage_login_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.startpage_login_btn.FlatAppearance.BorderSize = 0;
            this.startpage_login_btn.ForeColor = System.Drawing.Color.White;
            this.startpage_login_btn.Name = "startpage_login_btn";
            this.startpage_login_btn.UseVisualStyleBackColor = false;
            this.startpage_login_btn.Click += new System.EventHandler(this.startpage_login_btn_Click);
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Controls.Add(this.button1);
            this.loginpanel.Controls.Add(this.passwordBox);
            this.loginpanel.Controls.Add(this.username_box);
            this.loginpanel.Controls.Add(this.emailsuffix_box);
            resources.ApplyResources(this.loginpanel, "loginpanel");
            this.loginpanel.Name = "loginpanel";
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.ForeColor = System.Drawing.Color.Orange;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.Enter += new System.EventHandler(this.passwordBox_Enter);
            this.passwordBox.Leave += new System.EventHandler(this.passwordBox_Leave);
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.Color.White;
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            resources.ApplyResources(this.username_box, "username_box");
            this.username_box.ForeColor = System.Drawing.Color.Orange;
            this.username_box.Name = "username_box";
            this.username_box.Enter += new System.EventHandler(this.username_box_Enter);
            this.username_box.Leave += new System.EventHandler(this.username_box_Leave);
            // 
            // emailsuffix_box
            // 
            resources.ApplyResources(this.emailsuffix_box, "emailsuffix_box");
            this.emailsuffix_box.ForeColor = System.Drawing.Color.DodgerBlue;
            this.emailsuffix_box.Name = "emailsuffix_box";
            this.emailsuffix_box.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.startpage_cancel_btn;
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.startpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.startpanel.ResumeLayout(false);
            this.startpanel.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startpanel;
        private System.Windows.Forms.Button startpage_cancel_btn;
        private System.Windows.Forms.Label startpage_desc;
        private System.Windows.Forms.Label startpage_header;
        private System.Windows.Forms.Button startpage_login_btn;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.Panel loginpanel;
        private System.Windows.Forms.Label emailsuffix_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;



    }
}

