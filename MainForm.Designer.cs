using System.Windows.Forms;

namespace ADBDataExtractor
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.btnSaveContacts = new System.Windows.Forms.Button();
            this.btnLoadContacts = new System.Windows.Forms.Button();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.btnSaveMessages = new System.Windows.Forms.Button();
            this.btnLoadMessages = new System.Windows.Forms.Button();
            this.tabCallLogs = new System.Windows.Forms.TabPage();
            this.dgvCallLogs = new System.Windows.Forms.DataGridView();
            this.btnSaveCallLogs = new System.Windows.Forms.Button();
            this.btnLoadCallLogs = new System.Windows.Forms.Button();
            this.tabDeviceInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCPUInfo = new System.Windows.Forms.TextBox();
            this.txtMemoryInfo = new System.Windows.Forms.TextBox();
            this.btnSaveDeviceInfo = new System.Windows.Forms.Button();
            this.btnLoadDeviceInfo = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabContacts);
            this.tabControl1.Controls.Add(this.tabMessages);
            this.tabControl1.Controls.Add(this.tabCallLogs);
            this.tabControl1.Controls.Add(this.tabDeviceInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 410);
            this.tabControl1.TabIndex = 0;
            
            // 
            // tabContacts
            // 
            this.tabContacts.BackColor = System.Drawing.Color.Black;
            this.tabContacts.Controls.Add(this.dgvContacts);
            this.tabContacts.Controls.Add(this.btnSaveContacts);
            this.tabContacts.Controls.Add(this.btnLoadContacts);
            this.tabContacts.Location = new System.Drawing.Point(4, 24);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(752, 382);
            this.tabContacts.TabIndex = 0;
            this.tabContacts.Text = "Contacts";
            
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.BackgroundColor = System.Drawing.Color.Black;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvContacts.Location = new System.Drawing.Point(6, 44);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowTemplate.Height = 25;
            this.dgvContacts.Size = new System.Drawing.Size(740, 332);
            this.dgvContacts.TabIndex = 2;
            
            // 
            // btnSaveContacts
            // 
            this.btnSaveContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveContacts.Location = new System.Drawing.Point(606, 6);
            this.btnSaveContacts.Name = "btnSaveContacts";
            this.btnSaveContacts.Size = new System.Drawing.Size(140, 32);
            this.btnSaveContacts.TabIndex = 1;
            this.btnSaveContacts.Text = "Save to Database";
            this.btnSaveContacts.UseVisualStyleBackColor = true;
            this.btnSaveContacts.Click += new System.EventHandler(this.btnSaveContacts_Click);
            
            // 
            // btnLoadContacts
            // 
            this.btnLoadContacts.Location = new System.Drawing.Point(6, 6);
            this.btnLoadContacts.Name = "btnLoadContacts";
            this.btnLoadContacts.Size = new System.Drawing.Size(140, 32);
            this.btnLoadContacts.TabIndex = 0;
            this.btnLoadContacts.Text = "Load Contacts";
            this.btnLoadContacts.UseVisualStyleBackColor = true;
            this.btnLoadContacts.Click += new System.EventHandler(this.btnLoadContacts_Click);
            
            // 
            // tabMessages
            // 
            this.tabMessages.BackColor = System.Drawing.Color.Black;
            this.tabMessages.Controls.Add(this.dgvMessages);
            this.tabMessages.Controls.Add(this.btnSaveMessages);
            this.tabMessages.Controls.Add(this.btnLoadMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 24);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(752, 382);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMessages.BackgroundColor = System.Drawing.Color.Black;
            this.dgvMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvMessages.Location = new System.Drawing.Point(6, 44);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.RowTemplate.Height = 25;
            this.dgvMessages.Size = new System.Drawing.Size(740, 332);
            this.dgvMessages.TabIndex = 5;
            
            // 
            // btnSaveMessages
            // 
            this.btnSaveMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMessages.Location = new System.Drawing.Point(606, 6);
            this.btnSaveMessages.Name = "btnSaveMessages";
            this.btnSaveMessages.Size = new System.Drawing.Size(140, 32);
            this.btnSaveMessages.TabIndex = 4;
            this.btnSaveMessages.Text = "Save to Database";
            this.btnSaveMessages.UseVisualStyleBackColor = true;
            this.btnSaveMessages.Click += new System.EventHandler(this.btnSaveMessages_Click);
            
            // 
            // btnLoadMessages
            // 
            this.btnLoadMessages.Location = new System.Drawing.Point(6, 6);
            this.btnLoadMessages.Name = "btnLoadMessages";
            this.btnLoadMessages.Size = new System.Drawing.Size(140, 32);
            this.btnLoadMessages.TabIndex = 3;
            this.btnLoadMessages.Text = "Load Messages";
            this.btnLoadMessages.UseVisualStyleBackColor = true;
            this.btnLoadMessages.Click += new System.EventHandler(this.btnLoadMessages_Click);
            
            // 
            // tabCallLogs
            // 
            this.tabCallLogs.BackColor = System.Drawing.Color.Black;
            this.tabCallLogs.Controls.Add(this.dgvCallLogs);
            this.tabCallLogs.Controls.Add(this.btnSaveCallLogs);
            this.tabCallLogs.Controls.Add(this.btnLoadCallLogs);
            this.tabCallLogs.Location = new System.Drawing.Point(4, 24);
            this.tabCallLogs.Name = "tabCallLogs";
            this.tabCallLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabCallLogs.Size = new System.Drawing.Size(752, 382);
            this.tabCallLogs.TabIndex = 2;
            this.tabCallLogs.Text = "Call Logs";
            
            // 
            // dgvCallLogs
            // 
            this.dgvCallLogs.AllowUserToAddRows = false;
            this.dgvCallLogs.AllowUserToDeleteRows = false;
            this.dgvCallLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCallLogs.BackgroundColor = System.Drawing.Color.Black;
            this.dgvCallLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCallLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallLogs.GridColor = System.Drawing.Color.DarkGreen;
            this.dgvCallLogs.Location = new System.Drawing.Point(6, 44);
            this.dgvCallLogs.Name = "dgvCallLogs";
            this.dgvCallLogs.ReadOnly = true;
            this.dgvCallLogs.RowTemplate.Height = 25;
            this.dgvCallLogs.Size = new System.Drawing.Size(740, 332);
            this.dgvCallLogs.TabIndex = 5;
            
            // 
            // btnSaveCallLogs
            // 
            this.btnSaveCallLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCallLogs.Location = new System.Drawing.Point(606, 6);
            this.btnSaveCallLogs.Name = "btnSaveCallLogs";
            this.btnSaveCallLogs.Size = new System.Drawing.Size(140, 32);
            this.btnSaveCallLogs.TabIndex = 4;
            this.btnSaveCallLogs.Text = "Save to Database";
            this.btnSaveCallLogs.UseVisualStyleBackColor = true;
            this.btnSaveCallLogs.Click += new System.EventHandler(this.btnSaveCallLogs_Click);
            
            // 
            // btnLoadCallLogs
            // 
            this.btnLoadCallLogs.Location = new System.Drawing.Point(6, 6);
            this.btnLoadCallLogs.Name = "btnLoadCallLogs";
            this.btnLoadCallLogs.Size = new System.Drawing.Size(140, 32);
            this.btnLoadCallLogs.TabIndex = 3;
            this.btnLoadCallLogs.Text = "Load Call Logs";
            this.btnLoadCallLogs.UseVisualStyleBackColor = true;
            this.btnLoadCallLogs.Click += new System.EventHandler(this.btnLoadCallLogs_Click);
            
            // 
            // tabDeviceInfo
            // 
            this.tabDeviceInfo.BackColor = System.Drawing.Color.Black;
            this.tabDeviceInfo.Controls.Add(this.tableLayoutPanel1);
            this.tabDeviceInfo.Controls.Add(this.btnSaveDeviceInfo);
            this.tabDeviceInfo.Controls.Add(this.btnLoadDeviceInfo);
            this.tabDeviceInfo.Location = new System.Drawing.Point(4, 24);
            this.tabDeviceInfo.Name = "tabDeviceInfo";
            this.tabDeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceInfo.Size = new System.Drawing.Size(752, 382);
            this.tabDeviceInfo.TabIndex = 3;
            this.tabDeviceInfo.Text = "Device Info";
            
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCPUInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMemoryInfo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 332);
            this.tableLayoutPanel1.TabIndex = 6;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(373, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memory Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // txtCPUInfo
            // 
            this.txtCPUInfo.BackColor = System.Drawing.Color.Black;
            this.txtCPUInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCPUInfo.ForeColor = System.Drawing.Color.LightGreen;
            this.txtCPUInfo.Location = new System.Drawing.Point(3, 28);
            this.txtCPUInfo.Multiline = true;
            this.txtCPUInfo.Name = "txtCPUInfo";
            this.txtCPUInfo.ReadOnly = true;
            this.txtCPUInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCPUInfo.Size = new System.Drawing.Size(364, 301);
            this.txtCPUInfo.TabIndex = 2;
            
            // 
            // txtMemoryInfo
            // 
            this.txtMemoryInfo.BackColor = System.Drawing.Color.Black;
            this.txtMemoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMemoryInfo.ForeColor = System.Drawing.Color.LightGreen;
            this.txtMemoryInfo.Location = new System.Drawing.Point(373, 28);
            this.txtMemoryInfo.Multiline = true;
            this.txtMemoryInfo.Name = "txtMemoryInfo";
            this.txtMemoryInfo.ReadOnly = true;
            this.txtMemoryInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMemoryInfo.Size = new System.Drawing.Size(364, 301);
            this.txtMemoryInfo.TabIndex = 3;
            
            // 
            // btnSaveDeviceInfo
            // 
            this.btnSaveDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDeviceInfo.Location = new System.Drawing.Point(606, 6);
            this.btnSaveDeviceInfo.Name = "btnSaveDeviceInfo";
            this.btnSaveDeviceInfo.Size = new System.Drawing.Size(140, 32);
            this.btnSaveDeviceInfo.TabIndex = 4;
            this.btnSaveDeviceInfo.Text = "Save to Database";
            this.btnSaveDeviceInfo.UseVisualStyleBackColor = true;
            this.btnSaveDeviceInfo.Click += new System.EventHandler(this.btnSaveDeviceInfo_Click);
            
            // 
            // btnLoadDeviceInfo
            // 
            this.btnLoadDeviceInfo.Location = new System.Drawing.Point(6, 6);
            this.btnLoadDeviceInfo.Name = "btnLoadDeviceInfo";
            this.btnLoadDeviceInfo.Size = new System.Drawing.Size(140, 32);
            this.btnLoadDeviceInfo.TabIndex = 3;
            this.btnLoadDeviceInfo.Text = "Load Device Info";
            this.btnLoadDeviceInfo.UseVisualStyleBackColor = true;
            this.btnLoadDeviceInfo.Click += new System.EventHandler(this.btnLoadDeviceInfo_Click);
            
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 428);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(760, 32);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate PDF Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 494);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(800, 533);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADB Data Extractor";
            this.tabControl1.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.tabMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.tabCallLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallLogs)).EndInit();
            this.tabDeviceInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabPage tabCallLogs;
        private System.Windows.Forms.TabPage tabDeviceInfo;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnLoadContacts;
        private System.Windows.Forms.Button btnSaveContacts;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Button btnSaveMessages;
        private System.Windows.Forms.Button btnLoadMessages;
        private System.Windows.Forms.DataGridView dgvCallLogs;
        private System.Windows.Forms.Button btnSaveCallLogs;
        private System.Windows.Forms.Button btnLoadCallLogs;
        private System.Windows.Forms.Button btnSaveDeviceInfo;
        private System.Windows.Forms.Button btnLoadDeviceInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPUInfo;
        private System.Windows.Forms.TextBox txtMemoryInfo;
    }
}
