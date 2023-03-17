using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace TonerTakip
{
    public partial class FrmDolumGiris : Form
    {
        public FrmDolumGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        DataTable dt = new DataTable();
        void BirimListesi()
        {
            SqlCommand komut = new SqlCommand("Select  BirimAdi From Tbl_Birim", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBirim.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void TonerListesi()
        {
            SqlCommand komut = new SqlCommand("Select  TonerAdi From Tbl_Toner", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbToner.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        void TonerEkle()
        {
            try
            {
                if ((this.CmbToner.Text != "") & (this.TxtAdet.Value != 0))
                {
                    this.Cursor = Cursors.AppStarting;

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Toner WHERE ID=@p1", bgl.baglanti());
                    cmd.Parameters.AddWithValue("@p1", CmbToner.SelectedIndex + 1);
                    SqlDataReader oku = cmd.ExecuteReader();
                    while (oku.Read())
                    {
                        this.CmbToner.Tag = oku["ID"].ToString();

                        Dgw_Tonerler.DataSource = dt;
                        int i = 0;
                        for (i = 0; i < Dgw_Tonerler.Rows.Count; i++)
                        { }
                        dt.Rows.Add(oku["ID"].ToString(), i + 1, oku["TonerAdi"].ToString(), oku["UyumluCihaz"].ToString(), this.TxtAdet.Value.ToString());
                        Dgw_Tonerler.DataSource = dt;
                    }
                    oku.Close();
                    bgl.baglanti().Close();
                    int toplam = 0;

                    for (int t = 0; t < Dgw_Tonerler.Rows.Count; t++)
                    {
                        if (Dgw_Tonerler.Rows[t].Cells[3].Value != DBNull.Value)
                            toplam = toplam + Convert.ToInt32(Dgw_Tonerler.Rows[t].Cells[4].Value);
                    }

                    this.LblToplam.Text = toplam.ToString();

                    this.Cursor = Cursors.Default;
                }
                else MessageBox.Show("Lütfen Birim, Ürün ve Adet Alanlarını Doldurunuz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Ekleme Hatası\n" + ex.Message + "", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void TonerCikartma()
        {
            try
            {
                int selectedIndex = Dgw_Tonerler.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    Dgw_Tonerler.Rows.RemoveAt(selectedIndex);
                    Dgw_Tonerler.Refresh();
                }
                int toplam = 0;
                for (int t = 0; t < Dgw_Tonerler.Rows.Count; t++)
                {

                    if (Dgw_Tonerler.Rows[t].Cells[2].Value != DBNull.Value)

                        toplam = toplam + Convert.ToInt32(Dgw_Tonerler.Rows[t].Cells[4].Value);

                }
                for (int i = 0; i < this.Dgw_Tonerler.Rows.Count; i++)
                {
                    this.Dgw_Tonerler.Rows[i].Cells[1].Value = 1 + i;
                }
                this.LblToplam.Text = toplam.ToString();

            }
            catch
            {
                MessageBox.Show("Listeden Çıkartılacak Ürün Bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Kaydet()
        {
            try
            {
                if (TxtTeslimEden.Text != "" && Dgw_Tonerler.Rows.Count != 0)
                {
                    SqlCommand komut = new SqlCommand("SELECT EBYS FROM Tbl_TonerDolum WHERE EBYS=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", MskEBYS.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("" + MskEBYS.Text + " \nEBYS Nolu Evrak Daha Önce Kaydedilmiş. ", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.MskEBYS.Focus();
                        dr.Dispose();
                        bgl.baglanti().Close();
                        
                    }
                    else
                    {
                        SqlCommand komut2 = new SqlCommand("insert into Tbl_TonerDolum(EBYS,BirimID,Aciklama,TeslimEden,Durum) values (@t1,@t2,@t3,@t4,@t5)", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@t1", MskEBYS.Text);
                        komut2.Parameters.AddWithValue("@t2", CmbToner.SelectedIndex + 1); ////kontrol et////////
                        komut2.Parameters.AddWithValue("@t3", RchAciklama.Text);
                        komut2.Parameters.AddWithValue("@t4", TxtTeslimEden.Text);
                        komut2.Parameters.AddWithValue("@t5", "Dolum Yapılıyor.");
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();



                        //Toner Dolum ID verisi alma
                        SqlCommand sorgu = new SqlCommand("SELECT ID FROM Tbl_TonerDolum WHERE EBYS='" + MskEBYS.Text + "'", bgl.baglanti());
                        sorgu.ExecuteScalar();
                        LblID.Text = sorgu.ExecuteScalar().ToString();
                        bgl.baglanti().Close();


                        for (int i = 0; i < Dgw_Tonerler.Rows.Count; i++)
                        {
                            SqlCommand komut3 = new SqlCommand("insert into Tbl_Dolum (Sira,TonerDolumID,TonerID,Adet) values (@s1,@s2,@s3,@s4)", bgl.baglanti());
                            komut3.Parameters.AddWithValue("@s1", Dgw_Tonerler.Rows[i].Cells[1].Value.ToString().Trim());
                            komut3.Parameters.AddWithValue("@s2", LblID.Text);
                            komut3.Parameters.AddWithValue("@s3", Dgw_Tonerler.Rows[i].Cells[0].Value.ToString().Trim());
                            komut3.Parameters.AddWithValue("@s4", Dgw_Tonerler.Rows[i].Cells[4].Value.ToString().Trim());
                            komut3.ExecuteNonQuery();
                            bgl.baglanti().Close();
                        }

                        MessageBox.Show("Toner Dolum Bilgisi Sisteme Girildi. \n Tutanak Yazdırılıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TutanakYazdir();

                        Temizle();



                    }

                    
                }
                else
                {
                    MessageBox.Show("Teslim Eden Bilgisi ve/veya Teslim Edilen Ürün Listesi Boş Olamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("İş Açma Hatası\n" + ex.Message + "", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgwAyar()
        {
            try
            {

                this.Dgw_Tonerler.DataSource = dt;

                //Colums 0 toner ID verisi

                this.Dgw_Tonerler.Columns[0].Visible = false;
                this.Dgw_Tonerler.Columns[1].Width = 98;
                this.Dgw_Tonerler.Columns[2].Width = 260;
                this.Dgw_Tonerler.Columns[3].Width = 260;
                this.Dgw_Tonerler.Columns[4].Width = 70;

                this.Dgw_Tonerler.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Dgw_Tonerler.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Dgw_Tonerler.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Dgw_Tonerler.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.Dgw_Tonerler.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Dgw_Tonerler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.Dgw_Tonerler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.Dgw_Tonerler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DGW Ayarlama Hatası\n" + ex.Message + "", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DgwKolonAd()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Sıra No");
            dt.Columns.Add("Toner Marka");
            dt.Columns.Add("Toner Uyumlu Makine");
            dt.Columns.Add("Adet");
        }

        void Temizle()
        {
            dt.Rows.Clear();
            TxtAdet.Text = "";
            TxtTeslimEden.Text = "";
            MskEBYS.Text = "";
            LblID.Text = "";
            LblToplam.Text = "0";
            CmbBirim.Text = "";
            RchAciklama.Text = "";
            CmbToner.Text = "";
            MskEBYS.Focus();
        }

        void TutanakYazdir()
        {
            try
            {
                if (this.Dgw_Tonerler.Rows.Count > 0)
                {
                    this.Cursor = Cursors.AppStarting;
                    DGVPrinter printer = new DGVPrinter();

                    printer.PageSettings.Margins.Left = 40;
                    printer.PageSettings.Margins.Right = 40;
                    printer.PageSettings.Margins.Bottom = 30;
                    printer.PageSettings.Margins.Top = 30;
                    printer.Title = "TESLİM TESELLÜM TUTANAĞI";
                    printer.SubTitle = "\n" + "Tutanak No : " + LblID.Text + "\n\n\n              " + this.CmbBirim.Text.Trim().ToString() + "'ne ait " + this.MskEBYS.Text.Trim().ToString() + " EBYS nolu yazısında aşağıda bilgileri bulunan tonerler dolum ve bakımı yapılmak üzere teslim alınmıştır. " + DateTime.Now.ToShortDateString() + "";
                    printer.SubTitleSpacing = 25;
                    printer.SubTitleAlignment = StringAlignment.Near;
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.SubTitleFont = new Font("Tahoma", 10, FontStyle.Regular, GraphicsUnit.Point);
                    printer.PageNumbers = true;
                    printer.PageSettings.Landscape = false;
                    printer.PageNumberInHeader = false;
                    printer.ColumnWidth.GetType();
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.FooterSpacing = 15;

                    dt.Rows.Add("");
                    Dgw_Tonerler.DataSource = dt;
                    int s = 0;
                    s = Dgw_Tonerler.Rows.Count;
                    s = s - 1;

                    Dgw_Tonerler.Rows[s].Cells[2].Value = "\n\n\n\nTESLİM EDEN\n" + this.TxtTeslimEden.Text.Trim().ToString() + "\n\n";

                    //teslim alan kısmı giriş yapan personel olacak
                    Dgw_Tonerler.Rows[s].Cells[3].Value = "\n\n\n\nTESLİM ALAN\n" + "Koray TUTAR" + "\n\n";
                    Dgw_Tonerler.Rows[s].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                    Dgw_Tonerler.Rows[s].DefaultCellStyle.BackColor = Color.White;

                    this.Dgw_Tonerler.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.Dgw_Tonerler.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.Dgw_Tonerler.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.Dgw_Tonerler.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    this.Dgw_Tonerler.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.Dgw_Tonerler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    this.Dgw_Tonerler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    this.Dgw_Tonerler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    printer.PrintDataGridView(this.Dgw_Tonerler);

                    Dgw_Tonerler.Rows.RemoveAt(Dgw_Tonerler.Rows.Count - 1);

                    this.Cursor = Cursors.Default;
                }
                else MessageBox.Show("Tutanağa Yazdırılacak Ürün Bulunamadı. Lütfen Önce Ürün Ekleyiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tutanak Yazdırma Yazdırma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmDolumGiris_Load(object sender, EventArgs e)
        {
            BirimListesi();
            TonerListesi();
            DgwKolonAd();
            DgwAyar();
            Temizle();
            MskEBYS.Focus();
        }

        private void BtnTonerEkle_Click(object sender, EventArgs e)
        {
            TonerEkle();
        }

        private void BtnSeciliToneriCikart_Click(object sender, EventArgs e)
        {
            TonerCikartma();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
            
            
        }
    }
}
