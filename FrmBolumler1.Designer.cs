namespace YurtKayitSistemi1
{
    partial class FrmBolumler1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtkayitDataSet12 = new YurtKayitSistemi1.YurtkayitDataSet12();
            this.bolumlerTableAdapter = new YurtKayitSistemi1.YurtkayitDataSet12TableAdapters.BolumlerTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbBolumSil = new System.Windows.Forms.PictureBox();
            this.pcbBolumGuncelle = new System.Windows.Forms.PictureBox();
            this.pcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.txtBolumid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet12)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(563, 240);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtkayitDataSet12;
            // 
            // yurtkayitDataSet12
            // 
            this.yurtkayitDataSet12.DataSetName = "YurtkayitDataSet12";
            this.yurtkayitDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pcbBolumSil);
            this.panel1.Controls.Add(this.pcbBolumGuncelle);
            this.panel1.Controls.Add(this.pcbBolumEkle);
            this.panel1.Controls.Add(this.txtBolumAd);
            this.panel1.Controls.Add(this.txtBolumid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 206);
            this.panel1.TabIndex = 3;
            // 
            // pcbBolumSil
            // 
            this.pcbBolumSil.BackColor = System.Drawing.Color.Transparent;
            this.pcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumSil.Image")));
            this.pcbBolumSil.Location = new System.Drawing.Point(388, 148);
            this.pcbBolumSil.Name = "pcbBolumSil";
            this.pcbBolumSil.Size = new System.Drawing.Size(100, 50);
            this.pcbBolumSil.TabIndex = 8;
            this.pcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumSil, "Sil");
            this.pcbBolumSil.Click += new System.EventHandler(this.pcbBolumSil_Click);
            // 
            // pcbBolumGuncelle
            // 
            this.pcbBolumGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.pcbBolumGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumGuncelle.Image")));
            this.pcbBolumGuncelle.Location = new System.Drawing.Point(388, 83);
            this.pcbBolumGuncelle.Name = "pcbBolumGuncelle";
            this.pcbBolumGuncelle.Size = new System.Drawing.Size(100, 50);
            this.pcbBolumGuncelle.TabIndex = 9;
            this.pcbBolumGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumGuncelle, "Güncelle");
            this.pcbBolumGuncelle.Click += new System.EventHandler(this.pcbBolumGuncelle_Click);
            // 
            // pcbBolumEkle
            // 
            this.pcbBolumEkle.BackColor = System.Drawing.Color.Transparent;
            this.pcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumEkle.Image")));
            this.pcbBolumEkle.Location = new System.Drawing.Point(388, 9);
            this.pcbBolumEkle.Name = "pcbBolumEkle";
            this.pcbBolumEkle.Size = new System.Drawing.Size(100, 50);
            this.pcbBolumEkle.TabIndex = 10;
            this.pcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumEkle, "Ekle");
            this.pcbBolumEkle.Click += new System.EventHandler(this.pcbBolumEkle_Click_1);
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.Location = new System.Drawing.Point(192, 116);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(147, 28);
            this.txtBolumAd.TabIndex = 6;
            // 
            // txtBolumid
            // 
            this.txtBolumid.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumid.Location = new System.Drawing.Point(192, 43);
            this.txtBolumid.Name = "txtBolumid";
            this.txtBolumid.Size = new System.Drawing.Size(143, 28);
            this.txtBolumid.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bölüm id :";
            // 
            // FrmBolumler1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(559, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler1";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayitDataSet12)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtkayitDataSet12 yurtkayitDataSet12;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtkayitDataSet12TableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbBolumSil;
        private System.Windows.Forms.PictureBox pcbBolumGuncelle;
        private System.Windows.Forms.PictureBox pcbBolumEkle;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.TextBox txtBolumid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}