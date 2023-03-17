namespace TonerTakip
{
    partial class FrmDolumGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDolumGiris));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LblID = new System.Windows.Forms.Label();
            this.BtnSeciliToneriCikart = new DevExpress.XtraEditors.SimpleButton();
            this.MskEBYS = new System.Windows.Forms.MaskedTextBox();
            this.BtnTonerEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAdet = new DevExpress.XtraEditors.SpinEdit();
            this.TxtTeslimEden = new DevExpress.XtraEditors.TextEdit();
            this.CmbToner = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CmbBirim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchAciklama = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LblToplam = new DevExpress.XtraEditors.LabelControl();
            this.Dgw_Tonerler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTeslimEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Tonerler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LblID);
            this.groupControl1.Controls.Add(this.BtnSeciliToneriCikart);
            this.groupControl1.Controls.Add(this.MskEBYS);
            this.groupControl1.Controls.Add(this.BtnTonerEkle);
            this.groupControl1.Controls.Add(this.TxtAdet);
            this.groupControl1.Controls.Add(this.TxtTeslimEden);
            this.groupControl1.Controls.Add(this.CmbToner);
            this.groupControl1.Controls.Add(this.CmbBirim);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.RchAciklama);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(455, 356);
            this.groupControl1.TabIndex = 6;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(308, 32);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(31, 13);
            this.LblID.TabIndex = 38;
            this.LblID.Text = "LblID";
            this.LblID.Visible = false;
            // 
            // BtnSeciliToneriCikart
            // 
            this.BtnSeciliToneriCikart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeciliToneriCikart.ImageOptions.Image")));
            this.BtnSeciliToneriCikart.Location = new System.Drawing.Point(311, 249);
            this.BtnSeciliToneriCikart.Name = "BtnSeciliToneriCikart";
            this.BtnSeciliToneriCikart.Size = new System.Drawing.Size(122, 24);
            this.BtnSeciliToneriCikart.TabIndex = 8;
            this.BtnSeciliToneriCikart.Text = "Seçili Toneri Çıkart";
            this.BtnSeciliToneriCikart.Click += new System.EventHandler(this.BtnSeciliToneriCikart_Click);
            // 
            // MskEBYS
            // 
            this.MskEBYS.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskEBYS.Location = new System.Drawing.Point(101, 29);
            this.MskEBYS.Mask = "0000000000000000000";
            this.MskEBYS.Name = "MskEBYS";
            this.MskEBYS.Size = new System.Drawing.Size(167, 26);
            this.MskEBYS.TabIndex = 1;
            this.MskEBYS.ValidatingType = typeof(int);
            // 
            // BtnTonerEkle
            // 
            this.BtnTonerEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTonerEkle.ImageOptions.Image")));
            this.BtnTonerEkle.Location = new System.Drawing.Point(202, 249);
            this.BtnTonerEkle.Name = "BtnTonerEkle";
            this.BtnTonerEkle.Size = new System.Drawing.Size(103, 24);
            this.BtnTonerEkle.TabIndex = 7;
            this.BtnTonerEkle.Text = "Ekle";
            this.BtnTonerEkle.Click += new System.EventHandler(this.BtnTonerEkle_Click);
            // 
            // TxtAdet
            // 
            this.TxtAdet.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtAdet.Location = new System.Drawing.Point(102, 248);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdet.Properties.Appearance.Options.UseFont = true;
            this.TxtAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtAdet.Properties.MaskSettings.Set("mask", "d");
            this.TxtAdet.Size = new System.Drawing.Size(94, 24);
            this.TxtAdet.TabIndex = 6;
            // 
            // TxtTeslimEden
            // 
            this.TxtTeslimEden.Location = new System.Drawing.Point(101, 91);
            this.TxtTeslimEden.Name = "TxtTeslimEden";
            this.TxtTeslimEden.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTeslimEden.Properties.Appearance.Options.UseFont = true;
            this.TxtTeslimEden.Size = new System.Drawing.Size(332, 24);
            this.TxtTeslimEden.TabIndex = 3;
            // 
            // CmbToner
            // 
            this.CmbToner.Location = new System.Drawing.Point(101, 218);
            this.CmbToner.Name = "CmbToner";
            this.CmbToner.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbToner.Properties.Appearance.Options.UseFont = true;
            this.CmbToner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbToner.Size = new System.Drawing.Size(332, 24);
            this.CmbToner.TabIndex = 5;
            // 
            // CmbBirim
            // 
            this.CmbBirim.Location = new System.Drawing.Point(101, 61);
            this.CmbBirim.Name = "CmbBirim";
            this.CmbBirim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbBirim.Properties.Appearance.Options.UseFont = true;
            this.CmbBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbBirim.Size = new System.Drawing.Size(333, 24);
            this.CmbBirim.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(56, 251);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(40, 18);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "Adet :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(30, 124);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 18);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "Açıklama :";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(101, 305);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(334, 33);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet ve Tutanak Yazdır";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // RchAciklama
            // 
            this.RchAciklama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchAciklama.Location = new System.Drawing.Point(101, 121);
            this.RchAciklama.Name = "RchAciklama";
            this.RchAciklama.Size = new System.Drawing.Size(332, 91);
            this.RchAciklama.TabIndex = 4;
            this.RchAciklama.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(55, 64);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 18);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Birim :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(7, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Teslim Eden :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 221);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 18);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Toner :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(51, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "EBYS :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 394);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(197, 18);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Toplam Eklenen Toner Sayısı :";
            // 
            // LblToplam
            // 
            this.LblToplam.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplam.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblToplam.Appearance.Options.UseFont = true;
            this.LblToplam.Appearance.Options.UseForeColor = true;
            this.LblToplam.Location = new System.Drawing.Point(222, 394);
            this.LblToplam.Name = "LblToplam";
            this.LblToplam.Size = new System.Drawing.Size(10, 18);
            this.LblToplam.TabIndex = 37;
            this.LblToplam.Text = "0";
            // 
            // Dgw_Tonerler
            // 
            this.Dgw_Tonerler.AllowUserToAddRows = false;
            this.Dgw_Tonerler.AllowUserToDeleteRows = false;
            this.Dgw_Tonerler.AllowUserToResizeColumns = false;
            this.Dgw_Tonerler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dgw_Tonerler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgw_Tonerler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgw_Tonerler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_Tonerler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgw_Tonerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgw_Tonerler.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Tonerler.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgw_Tonerler.Location = new System.Drawing.Point(473, 12);
            this.Dgw_Tonerler.Name = "Dgw_Tonerler";
            this.Dgw_Tonerler.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgw_Tonerler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgw_Tonerler.RowHeadersVisible = false;
            this.Dgw_Tonerler.RowHeadersWidth = 25;
            this.Dgw_Tonerler.RowTemplate.Height = 17;
            this.Dgw_Tonerler.RowTemplate.ReadOnly = true;
            this.Dgw_Tonerler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Tonerler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Tonerler.Size = new System.Drawing.Size(694, 606);
            this.Dgw_Tonerler.TabIndex = 40;
            this.Dgw_Tonerler.TabStop = false;
            this.Dgw_Tonerler.VirtualMode = true;
            // 
            // FrmDolumGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 695);
            this.Controls.Add(this.Dgw_Tonerler);
            this.Controls.Add(this.LblToplam);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDolumGiris";
            this.Text = "Dolum Giriş";
            this.Load += new System.EventHandler(this.FrmDolumGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTeslimEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Tonerler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtTeslimEden;
        private DevExpress.XtraEditors.ComboBoxEdit CmbToner;
        private DevExpress.XtraEditors.ComboBoxEdit CmbBirim;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.RichTextBox RchAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnTonerEkle;
        private DevExpress.XtraEditors.SpinEdit TxtAdet;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox MskEBYS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl LblToplam;
        private DevExpress.XtraEditors.SimpleButton BtnSeciliToneriCikart;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.DataGridView Dgw_Tonerler;
    }
}