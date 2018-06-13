namespace SystemMonitoring
{
    partial class ProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.processDGV = new System.Windows.Forms.DataGridView();
            this.ProcessCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RamUtilisee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopProcess = new System.Windows.Forms.DataGridViewButtonColumn();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.processDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // processDGV
            // 
            this.processDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessCol,
            this.ProcessID,
            this.RamUtilisee,
            this.StopProcess});
            this.processDGV.Location = new System.Drawing.Point(4, 60);
            this.processDGV.Name = "processDGV";
            this.processDGV.RowTemplate.Height = 24;
            this.processDGV.Size = new System.Drawing.Size(865, 658);
            this.processDGV.TabIndex = 0;
            this.processDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processDGV_CellContentClick);
            // 
            // ProcessCol
            // 
            this.ProcessCol.HeaderText = "Processus";
            this.ProcessCol.MinimumWidth = 300;
            this.ProcessCol.Name = "ProcessCol";
            this.ProcessCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessCol.ToolTipText = "Le nom des processus";
            this.ProcessCol.Width = 300;
            // 
            // ProcessID
            // 
            this.ProcessID.FillWeight = 40F;
            this.ProcessID.HeaderText = "PID";
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Width = 40;
            // 
            // RamUtilisee
            // 
            this.RamUtilisee.FillWeight = 150F;
            this.RamUtilisee.HeaderText = "Ram Utilisée";
            this.RamUtilisee.Name = "RamUtilisee";
            this.RamUtilisee.ToolTipText = "Mémoive vive utilisée par le processus";
            this.RamUtilisee.Width = 150;
            // 
            // StopProcess
            // 
            this.StopProcess.FillWeight = 120F;
            this.StopProcess.HeaderText = "Arrêter le processus";
            this.StopProcess.Name = "StopProcess";
            this.StopProcess.ToolTipText = "Stopper le processus";
            this.StopProcess.Width = 120;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(261, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(137, 33);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Raffraîchir la liste";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des processus :";
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.processDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            ((System.ComponentModel.ISupportInitialize)(this.processDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView processDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RamUtilisee;
        private System.Windows.Forms.DataGridViewButtonColumn StopProcess;
        private System.Windows.Forms.Label label1;
    }
}