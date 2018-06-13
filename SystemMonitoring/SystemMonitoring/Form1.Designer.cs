namespace SystemMonitoring
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infosGBox = new System.Windows.Forms.GroupBox();
            this.cpuMakerLogo = new System.Windows.Forms.PictureBox();
            this.ipValueLbl = new System.Windows.Forms.Label();
            this.osValueLbl = new System.Windows.Forms.Label();
            this.gpuValueLbl = new System.Windows.Forms.Label();
            this.ramValueLbl = new System.Windows.Forms.Label();
            this.cpuValueLbl = new System.Windows.Forms.Label();
            this.ipLbl = new System.Windows.Forms.Label();
            this.osLbl = new System.Windows.Forms.Label();
            this.gpuLbl = new System.Windows.Forms.Label();
            this.ramLbl = new System.Windows.Forms.Label();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.disqueGBox = new System.Windows.Forms.GroupBox();
            this.DiskDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ramUsageLbl = new System.Windows.Forms.Label();
            this.RamPbar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.cpuUsageLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CpuPbar = new System.Windows.Forms.ProgressBar();
            this.cpuWorker = new System.ComponentModel.BackgroundWorker();
            this.ToolsBtn = new System.Windows.Forms.Button();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.processBtn = new System.Windows.Forms.Button();
            this.DiskLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Free = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.infosGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMakerLogo)).BeginInit();
            this.disqueGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiskDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.RamPbar);
            this.panel1.Controls.Add(this.CpuPbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 34);
            this.panel1.TabIndex = 1;
            // 
            // infosGBox
            // 
            this.infosGBox.Controls.Add(this.cpuMakerLogo);
            this.infosGBox.Controls.Add(this.ipValueLbl);
            this.infosGBox.Controls.Add(this.osValueLbl);
            this.infosGBox.Controls.Add(this.gpuValueLbl);
            this.infosGBox.Controls.Add(this.ramValueLbl);
            this.infosGBox.Controls.Add(this.cpuValueLbl);
            this.infosGBox.Controls.Add(this.ipLbl);
            this.infosGBox.Controls.Add(this.osLbl);
            this.infosGBox.Controls.Add(this.gpuLbl);
            this.infosGBox.Controls.Add(this.ramLbl);
            this.infosGBox.Controls.Add(this.cpuLbl);
            this.infosGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infosGBox.Location = new System.Drawing.Point(9, 34);
            this.infosGBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infosGBox.Name = "infosGBox";
            this.infosGBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infosGBox.Size = new System.Drawing.Size(314, 220);
            this.infosGBox.TabIndex = 2;
            this.infosGBox.TabStop = false;
            this.infosGBox.Text = "Infos système";
            this.infosGBox.Enter += new System.EventHandler(this.infosGBox_Enter);
            // 
            // cpuMakerLogo
            // 
            this.cpuMakerLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cpuMakerLogo.Location = new System.Drawing.Point(16, 26);
            this.cpuMakerLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpuMakerLogo.Name = "cpuMakerLogo";
            this.cpuMakerLogo.Size = new System.Drawing.Size(62, 55);
            this.cpuMakerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cpuMakerLogo.TabIndex = 11;
            this.cpuMakerLogo.TabStop = false;
            // 
            // ipValueLbl
            // 
            this.ipValueLbl.AutoSize = true;
            this.ipValueLbl.Location = new System.Drawing.Point(89, 182);
            this.ipValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipValueLbl.Name = "ipValueLbl";
            this.ipValueLbl.Size = new System.Drawing.Size(14, 15);
            this.ipValueLbl.TabIndex = 10;
            this.ipValueLbl.Text = "_";
            // 
            // osValueLbl
            // 
            this.osValueLbl.AutoSize = true;
            this.osValueLbl.Location = new System.Drawing.Point(52, 158);
            this.osValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osValueLbl.Name = "osValueLbl";
            this.osValueLbl.Size = new System.Drawing.Size(14, 15);
            this.osValueLbl.TabIndex = 9;
            this.osValueLbl.Text = "_";
            // 
            // gpuValueLbl
            // 
            this.gpuValueLbl.AutoSize = true;
            this.gpuValueLbl.Location = new System.Drawing.Point(56, 136);
            this.gpuValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuValueLbl.Name = "gpuValueLbl";
            this.gpuValueLbl.Size = new System.Drawing.Size(14, 15);
            this.gpuValueLbl.TabIndex = 8;
            this.gpuValueLbl.Text = "_";
            // 
            // ramValueLbl
            // 
            this.ramValueLbl.AutoSize = true;
            this.ramValueLbl.Location = new System.Drawing.Point(55, 114);
            this.ramValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramValueLbl.Name = "ramValueLbl";
            this.ramValueLbl.Size = new System.Drawing.Size(14, 15);
            this.ramValueLbl.TabIndex = 7;
            this.ramValueLbl.Text = "_";
            // 
            // cpuValueLbl
            // 
            this.cpuValueLbl.AutoSize = true;
            this.cpuValueLbl.Location = new System.Drawing.Point(55, 92);
            this.cpuValueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuValueLbl.Name = "cpuValueLbl";
            this.cpuValueLbl.Size = new System.Drawing.Size(14, 15);
            this.cpuValueLbl.TabIndex = 6;
            this.cpuValueLbl.Text = "_";
            // 
            // ipLbl
            // 
            this.ipLbl.AutoSize = true;
            this.ipLbl.Location = new System.Drawing.Point(14, 182);
            this.ipLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLbl.Name = "ipLbl";
            this.ipLbl.Size = new System.Drawing.Size(70, 15);
            this.ipLbl.TabIndex = 4;
            this.ipLbl.Text = "Adresse ip :";
            // 
            // osLbl
            // 
            this.osLbl.AutoSize = true;
            this.osLbl.Location = new System.Drawing.Point(14, 158);
            this.osLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.osLbl.Name = "osLbl";
            this.osLbl.Size = new System.Drawing.Size(30, 15);
            this.osLbl.TabIndex = 3;
            this.osLbl.Text = "OS :";
            // 
            // gpuLbl
            // 
            this.gpuLbl.AutoSize = true;
            this.gpuLbl.Location = new System.Drawing.Point(14, 136);
            this.gpuLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gpuLbl.Name = "gpuLbl";
            this.gpuLbl.Size = new System.Drawing.Size(39, 15);
            this.gpuLbl.TabIndex = 2;
            this.gpuLbl.Text = "GPU :";
            // 
            // ramLbl
            // 
            this.ramLbl.AutoSize = true;
            this.ramLbl.Location = new System.Drawing.Point(14, 114);
            this.ramLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(40, 15);
            this.ramLbl.TabIndex = 1;
            this.ramLbl.Text = "Ram :";
            // 
            // cpuLbl
            // 
            this.cpuLbl.AutoSize = true;
            this.cpuLbl.Location = new System.Drawing.Point(14, 92);
            this.cpuLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(38, 15);
            this.cpuLbl.TabIndex = 0;
            this.cpuLbl.Text = "CPU :";
            this.cpuLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // disqueGBox
            // 
            this.disqueGBox.Controls.Add(this.DiskDGV);
            this.disqueGBox.Location = new System.Drawing.Point(327, 34);
            this.disqueGBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disqueGBox.Name = "disqueGBox";
            this.disqueGBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disqueGBox.Size = new System.Drawing.Size(501, 445);
            this.disqueGBox.TabIndex = 5;
            this.disqueGBox.TabStop = false;
            this.disqueGBox.Text = "Disques durs";
            // 
            // DiskDGV
            // 
            this.DiskDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DiskDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiskDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiskDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DiskLabel,
            this.DiskName,
            this.Capacity,
            this.Free});
            this.DiskDGV.Location = new System.Drawing.Point(4, 26);
            this.DiskDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DiskDGV.Name = "DiskDGV";
            this.DiskDGV.RowTemplate.Height = 24;
            this.DiskDGV.Size = new System.Drawing.Size(495, 407);
            this.DiskDGV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ramUsageLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cpuUsageLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 268);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(314, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moniteur de ressources";
            // 
            // ramUsageLbl
            // 
            this.ramUsageLbl.AutoSize = true;
            this.ramUsageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ramUsageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramUsageLbl.Location = new System.Drawing.Point(107, 60);
            this.ramUsageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ramUsageLbl.Name = "ramUsageLbl";
            this.ramUsageLbl.Size = new System.Drawing.Size(15, 15);
            this.ramUsageLbl.TabIndex = 6;
            this.ramUsageLbl.Text = "_";
            // 
            // RamPbar
            // 
            this.RamPbar.Location = new System.Drawing.Point(460, 3);
            this.RamPbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RamPbar.Name = "RamPbar";
            this.RamPbar.Size = new System.Drawing.Size(302, 29);
            this.RamPbar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Utilisation ram :";
            // 
            // cpuUsageLbl
            // 
            this.cpuUsageLbl.AutoSize = true;
            this.cpuUsageLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpuUsageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsageLbl.Location = new System.Drawing.Point(107, 24);
            this.cpuUsageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cpuUsageLbl.Name = "cpuUsageLbl";
            this.cpuUsageLbl.Size = new System.Drawing.Size(15, 15);
            this.cpuUsageLbl.TabIndex = 2;
            this.cpuUsageLbl.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisation cpu :";
            // 
            // CpuPbar
            // 
            this.CpuPbar.Location = new System.Drawing.Point(9, 2);
            this.CpuPbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CpuPbar.Name = "CpuPbar";
            this.CpuPbar.Size = new System.Drawing.Size(302, 29);
            this.CpuPbar.TabIndex = 0;
            // 
            // ToolsBtn
            // 
            this.ToolsBtn.Image = global::SystemMonitoring.Properties.Resources.toolbox;
            this.ToolsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolsBtn.Location = new System.Drawing.Point(92, 438);
            this.ToolsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToolsBtn.Name = "ToolsBtn";
            this.ToolsBtn.Size = new System.Drawing.Size(143, 41);
            this.ToolsBtn.TabIndex = 7;
            this.ToolsBtn.Text = "Ouvrir les outils";
            this.ToolsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolsBtn.UseVisualStyleBackColor = true;
            this.ToolsBtn.Click += new System.EventHandler(this.ToolsBtn_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.Image = global::SystemMonitoring.Properties.Resources.service;
            this.serviceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serviceBtn.Location = new System.Drawing.Point(180, 384);
            this.serviceBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(143, 41);
            this.serviceBtn.TabIndex = 4;
            this.serviceBtn.Text = "Liste des services";
            this.serviceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // processBtn
            // 
            this.processBtn.Image = global::SystemMonitoring.Properties.Resources.process;
            this.processBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processBtn.Location = new System.Drawing.Point(9, 384);
            this.processBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(143, 41);
            this.processBtn.TabIndex = 3;
            this.processBtn.Text = "Liste des processus";
            this.processBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // DiskLabel
            // 
            this.DiskLabel.HeaderText = "Label";
            this.DiskLabel.Name = "DiskLabel";
            // 
            // DiskName
            // 
            this.DiskName.FillWeight = 150F;
            this.DiskName.HeaderText = "Nom du disque";
            this.DiskName.Name = "DiskName";
            this.DiskName.Width = 150;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacité Totale (Mo)";
            this.Capacity.Name = "Capacity";
            // 
            // Free
            // 
            this.Free.HeaderText = "Libre (Mo)";
            this.Free.Name = "Free";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 519);
            this.Controls.Add(this.ToolsBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disqueGBox);
            this.Controls.Add(this.serviceBtn);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.infosGBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "SystemMonitoring";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.infosGBox.ResumeLayout(false);
            this.infosGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMakerLogo)).EndInit();
            this.disqueGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiskDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox infosGBox;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label ipLbl;
        private System.Windows.Forms.Label osLbl;
        private System.Windows.Forms.Label gpuLbl;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Button serviceBtn;
        private System.Windows.Forms.GroupBox disqueGBox;
        private System.Windows.Forms.Label ipValueLbl;
        private System.Windows.Forms.Label osValueLbl;
        private System.Windows.Forms.Label gpuValueLbl;
        private System.Windows.Forms.Label ramValueLbl;
        private System.Windows.Forms.Label cpuValueLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox cpuMakerLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar CpuPbar;
        private System.Windows.Forms.Label cpuUsageLbl;
        private System.ComponentModel.BackgroundWorker cpuWorker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ToolsBtn;
        private System.Windows.Forms.Label ramUsageLbl;
        private System.Windows.Forms.ProgressBar RamPbar;
        private System.Windows.Forms.DataGridView DiskDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiskLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Free;
    }
}

