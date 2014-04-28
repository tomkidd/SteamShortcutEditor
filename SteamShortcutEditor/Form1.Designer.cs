namespace SteamShortcutEditor
{
    partial class Form1
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
            this.btnSendToSteam = new System.Windows.Forms.Button();
            this.txtGamesDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSteamDir = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chkExclude = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendToSteam
            // 
            this.btnSendToSteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendToSteam.Location = new System.Drawing.Point(425, 390);
            this.btnSendToSteam.Name = "btnSendToSteam";
            this.btnSendToSteam.Size = new System.Drawing.Size(157, 23);
            this.btnSendToSteam.TabIndex = 2;
            this.btnSendToSteam.Text = "Send to Steam";
            this.btnSendToSteam.UseVisualStyleBackColor = true;
            this.btnSendToSteam.Click += new System.EventHandler(this.btnSendToSteam_Click);
            // 
            // txtGamesDir
            // 
            this.txtGamesDir.Location = new System.Drawing.Point(63, 12);
            this.txtGamesDir.Name = "txtGamesDir";
            this.txtGamesDir.Size = new System.Drawing.Size(697, 20);
            this.txtGamesDir.TabIndex = 3;
            this.txtGamesDir.Text = "D:\\games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Games Dir:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(766, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Steam Dir:";
            // 
            // txtSteamDir
            // 
            this.txtSteamDir.Location = new System.Drawing.Point(63, 38);
            this.txtSteamDir.Name = "txtSteamDir";
            this.txtSteamDir.Size = new System.Drawing.Size(697, 20);
            this.txtSteamDir.TabIndex = 6;
            this.txtSteamDir.Text = "D:\\games\\steam";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 316);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScan.Location = new System.Drawing.Point(340, 390);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Location = new System.Drawing.Point(588, 390);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(8, 390);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkExclude
            // 
            this.chkExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkExclude.AutoSize = true;
            this.chkExclude.Checked = true;
            this.chkExclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExclude.Location = new System.Drawing.Point(89, 394);
            this.chkExclude.Name = "chkExclude";
            this.chkExclude.Size = new System.Drawing.Size(245, 17);
            this.chkExclude.TabIndex = 13;
            this.chkExclude.Text = "Exclude previouly established game directories";
            this.chkExclude.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.chkExclude);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSteamDir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGamesDir);
            this.Controls.Add(this.btnSendToSteam);
            this.Name = "Form1";
            this.Text = "Steam Shortcut Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendToSteam;
        private System.Windows.Forms.TextBox txtGamesDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSteamDir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chkExclude;
    }
}

