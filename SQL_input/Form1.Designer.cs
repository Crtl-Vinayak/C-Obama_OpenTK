namespace SQL_input
{
    partial class Main_Form
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.tbx_command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_qeuryresult = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_export_excel = new System.Windows.Forms.Button();
            this.btn_export_txt = new System.Windows.Forms.Button();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qeuryresult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(1111, 108);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(149, 41);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Execute Command";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tbx_command
            // 
            this.tbx_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbx_command.Location = new System.Drawing.Point(169, 108);
            this.tbx_command.Multiline = true;
            this.tbx_command.Name = "tbx_command";
            this.tbx_command.Size = new System.Drawing.Size(936, 37);
            this.tbx_command.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(492, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Input SQL command";
            // 
            // dgv_qeuryresult
            // 
            this.dgv_qeuryresult.AllowUserToAddRows = false;
            this.dgv_qeuryresult.AllowUserToDeleteRows = false;
            this.dgv_qeuryresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_qeuryresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qeuryresult.Location = new System.Drawing.Point(198, 295);
            this.dgv_qeuryresult.Name = "dgv_qeuryresult";
            this.dgv_qeuryresult.ReadOnly = true;
            this.dgv_qeuryresult.Size = new System.Drawing.Size(931, 267);
            this.dgv_qeuryresult.TabIndex = 19;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(198, 164);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(157, 45);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit data";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // switchDatabaseToolStripMenuItem
            // 
            this.switchDatabaseToolStripMenuItem.Name = "switchDatabaseToolStripMenuItem";
            this.switchDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchDatabaseToolStripMenuItem.Text = "Switch Database";
            this.switchDatabaseToolStripMenuItem.Click += new System.EventHandler(this.switchDatabaseToolStripMenuItem_Click);
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.Location = new System.Drawing.Point(405, 164);
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.Size = new System.Drawing.Size(157, 45);
            this.btn_export_excel.TabIndex = 22;
            this.btn_export_excel.Text = "Export Table to Excel";
            this.btn_export_excel.UseVisualStyleBackColor = true;
            // 
            // btn_export_txt
            // 
            this.btn_export_txt.Location = new System.Drawing.Point(596, 164);
            this.btn_export_txt.Name = "btn_export_txt";
            this.btn_export_txt.Size = new System.Drawing.Size(157, 45);
            this.btn_export_txt.TabIndex = 23;
            this.btn_export_txt.Text = "Export Table to txt";
            this.btn_export_txt.UseVisualStyleBackColor = true;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.btn_export_txt);
            this.Controls.Add(this.btn_export_excel);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgv_qeuryresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_command);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qeuryresult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tbx_command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_qeuryresult;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button btn_export_excel;
        private System.Windows.Forms.Button btn_export_txt;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

