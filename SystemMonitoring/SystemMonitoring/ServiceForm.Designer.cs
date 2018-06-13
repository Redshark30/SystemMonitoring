namespace SystemMonitoring
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.ServiceDGV = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceRealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StartService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceDGV
            // 
            this.ServiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceRealName,
            this.Statut,
            this.StopService,
            this.StartService});
            this.ServiceDGV.Location = new System.Drawing.Point(3, 52);
            this.ServiceDGV.Name = "ServiceDGV";
            this.ServiceDGV.RowTemplate.Height = 24;
            this.ServiceDGV.Size = new System.Drawing.Size(1068, 609);
            this.ServiceDGV.TabIndex = 0;
            this.ServiceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDGV_CellContentClick);
            // 
            // ServiceName
            // 
            this.ServiceName.FillWeight = 200F;
            this.ServiceName.HeaderText = "Nom du service";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Width = 200;
            // 
            // ServiceRealName
            // 
            this.ServiceRealName.FillWeight = 300F;
            this.ServiceRealName.HeaderText = "Description";
            this.ServiceRealName.Name = "ServiceRealName";
            this.ServiceRealName.Width = 300;
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            // 
            // StopService
            // 
            this.StopService.FillWeight = 80F;
            this.StopService.HeaderText = "Arrêter";
            this.StopService.Name = "StopService";
            this.StopService.Width = 80;
            // 
            // StartService
            // 
            this.StartService.FillWeight = 80F;
            this.StartService.HeaderText = "Démarrer";
            this.StartService.Name = "StartService";
            this.StartService.Text = "";
            this.StartService.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raffraîchir la liste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des services :";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServiceDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ServiceDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceRealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewButtonColumn StopService;
        private System.Windows.Forms.DataGridViewButtonColumn StartService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}