namespace SQL_input
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_dbname = new System.Windows.Forms.TextBox();
            this.tbx_ipaddress = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port";
            // 
            // tbx_dbname
            // 
            this.tbx_dbname.Location = new System.Drawing.Point(106, 29);
            this.tbx_dbname.Multiline = true;
            this.tbx_dbname.Name = "tbx_dbname";
            this.tbx_dbname.Size = new System.Drawing.Size(139, 28);
            this.tbx_dbname.TabIndex = 5;
            // 
            // tbx_ipaddress
            // 
            this.tbx_ipaddress.Location = new System.Drawing.Point(106, 64);
            this.tbx_ipaddress.Multiline = true;
            this.tbx_ipaddress.Name = "tbx_ipaddress";
            this.tbx_ipaddress.Size = new System.Drawing.Size(139, 28);
            this.tbx_ipaddress.TabIndex = 6;
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(106, 99);
            this.tbx_username.Multiline = true;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(139, 28);
            this.tbx_username.TabIndex = 7;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(106, 133);
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(139, 28);
            this.tbx_password.TabIndex = 8;
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(106, 167);
            this.tbx_port.Multiline = true;
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(139, 28);
            this.tbx_port.TabIndex = 9;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(97, 201);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 34);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(178, 201);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 34);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.loginOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllFieldsToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // clearAllFieldsToolStripMenuItem
            // 
            this.clearAllFieldsToolStripMenuItem.Name = "clearAllFieldsToolStripMenuItem";
            this.clearAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.clearAllFieldsToolStripMenuItem.Text = "Clear all fields";
            this.clearAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.clearAllFieldsToolStripMenuItem_Click);
            // 
            // loginOptionsToolStripMenuItem
            // 
            this.loginOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLoginToolStripMenuItem,
            this.loadLoginToolStripMenuItem});
            this.loginOptionsToolStripMenuItem.Name = "loginOptionsToolStripMenuItem";
            this.loginOptionsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.loginOptionsToolStripMenuItem.Text = "Login options";
            // 
            // saveLoginToolStripMenuItem
            // 
            this.saveLoginToolStripMenuItem.Name = "saveLoginToolStripMenuItem";
            this.saveLoginToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.saveLoginToolStripMenuItem.Text = "Save login";
            this.saveLoginToolStripMenuItem.Click += new System.EventHandler(this.saveLoginToolStripMenuItem_Click);
            // 
            // loadLoginToolStripMenuItem
            // 
            this.loadLoginToolStripMenuItem.Name = "loadLoginToolStripMenuItem";
            this.loadLoginToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.loadLoginToolStripMenuItem.Text = "Load login";
            this.loadLoginToolStripMenuItem.Click += new System.EventHandler(this.loadLoginToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(298, 290);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_port);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.tbx_ipaddress);
            this.Controls.Add(this.tbx_dbname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Database tool - Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_dbname;
        private System.Windows.Forms.TextBox tbx_ipaddress;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_port;
        public System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLoginToolStripMenuItem;
    }
}