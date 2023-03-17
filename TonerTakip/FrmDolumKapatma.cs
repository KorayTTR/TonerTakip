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
using DevExpress.XtraGrid;
using System.Reflection;
using DevExpress.Utils.DirectXPaint;
using DGVPrinterHelper;
using DevExpress.XtraPrinting.Native;

namespace TonerTakip
{
    public partial class FrmDolumKapatma : Form
    {
        public FrmDolumKapatma()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        DataTable dt = new DataTable();


        void TutanakArama()
        {
            MskEBYS.Text = "";
            TxtBirim.Text = "";
            LblBirim.Text = "";
            LblTutanakNo.Text = "";
            TxtTeslimAlan.Text = "";
            dt.Rows.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select Tbl_TonerDolum.ID,Tbl_TonerDolum.EBYS, Sira as 'Sıra No' , Tbl_Toner.TonerAdi as 'Toner Adı', Tbl_Toner.UyumluCihaz as 'Uyumlu Cihaz', Adet from Tbl_Dolum INNER JOIN Tbl_TonerDolum on Tbl_Dolum.TonerDolumID=Tbl_TonerDolum.ID INNER JOIN Tbl_Toner on Tbl_Dolum.TonerID=Tbl_Toner.ID where TonerDolumID= '" + TxtId.Text + "' and Durum='Dolum Yapılıyor.'", bgl.baglanti());
            da.Fill(dt);

            this.Dgw_Tonerler.DataSource = dt;

            //gridControl1.DataSource = dt;

            //Colums 0 toner ID verisi

            this.Dgw_Tonerler.Columns[0].Visible = false;
            this.Dgw_Tonerler.Columns[1].Visible = false;
            this.Dgw_Tonerler.Columns[2].Width = 98;
            this.Dgw_Tonerler.Columns[3].Width = 260;
            this.Dgw_Tonerler.Columns[4].Width = 260;
            this.Dgw_Tonerler.Columns[5].Width = 70;

            this.Dgw_Tonerler.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.Dgw_Tonerler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Dgw_Tonerler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Dgw_Tonerler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        void EBYSTutanakArama()
        {
            MskEBYS.Text = "";
            TxtBirim.Text = "";
            LblBirim.Text = "";
            LblTutanakNo.Text = "";
            TxtTeslimAlan.Text = "";
            dt.Rows.Clear();
            SqlDataAdapter da = new SqlDataAdapter("select Tbl_TonerDolum.ID, Tbl_TonerDolum.EBYS, Sira as 'Sıra No' , Tbl_Toner.TonerAdi as 'Toner Adı', Tbl_Toner.UyumluCihaz as 'Uyumlu Cihaz', Adet, Tbl_TonerDolum.Durum  from Tbl_Dolum INNER JOIN Tbl_TonerDolum on Tbl_Dolum.TonerDolumID=Tbl_TonerDolum.ID INNER JOIN Tbl_Toner on Tbl_Dolum.TonerID=Tbl_Toner.ID where EBYS= '" + TxtEBYS.Text + "' and Durum='Dolum Yapılıyor.'", bgl.baglanti());
            da.Fill(dt);

            this.Dgw_Tonerler.DataSource = dt;

            //gridControl1.DataSource = dt;

            //Colums 0 toner ID verisi

            this.Dgw_Tonerler.Columns[0].Visible = false;
            this.Dgw_Tonerler.Columns[1].Visible = false;
            this.Dgw_Tonerler.Columns[2].Width = 98;
            this.Dgw_Tonerler.Columns[3].Width = 260;
            this.Dgw_Tonerler.Columns[4].Width = 260;
            this.Dgw_Tonerler.Columns[5].Width = 70;
            this.Dgw_Tonerler.Columns[6].Visible = false;

            this.Dgw_Tonerler.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.Dgw_Tonerler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Dgw_Tonerler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Dgw_Tonerler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.Dgw_Tonerler.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }
        void Vericek()
        {
            if (TxtId.Text!="")
            {
                SqlCommand komut1 = new SqlCommand("Select * from Tbl_TonerDolum where ID=@p1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtId.Text);
                SqlDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    LblBirim.Text = dr1["BirimID"].ToString();
                    LblTutanakNo.Text = dr1["ID"].ToString();
                    MskEBYS.Text = dr1["EBYS"].ToString();
                    TxtTeslimAlan.Text = dr1["TeslimAlan"].ToString();
                }
                bgl.baglanti().Close();

                SqlCommand komut2 = new SqlCommand("Select * from Tbl_Birim where ID=@s1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@s1", LblBirim.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    TxtBirim.Text = dr2["BirimAdi"].ToString();
                }
                bgl.baglanti().Close();
            }
            if (TxtEBYS.Text != "")
            {
                SqlCommand komut1 = new SqlCommand("Select * from Tbl_TonerDolum where EBYS=@y1", bgl.baglanti());
                komut1.Parameters.AddWithValue("@y1", TxtEBYS.Text);
                SqlDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read())
                {
                    LblBirim.Text = dr1["BirimID"].ToString();
                    LblTutanakNo.Text = dr1["ID"].ToString();
                    MskEBYS.Text = dr1["EBYS"].ToString();
                    TxtTeslimAlan.Text= dr1["TeslimAlan"].ToString();
                }
                bgl.baglanti().Close();

                SqlCommand komut2 = new SqlCommand("Select * from Tbl_Birim where ID=@z1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@z1", LblBirim.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    TxtBirim.Text = dr2["BirimAdi"].ToString();
                }
                bgl.baglanti().Close();
            }

        }
        void Temizle()
        {
            dt.Rows.Clear();
            TxtBirim.Text = "";
            TxtEBYS.Text = "";
            TxtId.Text = "";
            TxtTeslimAlan.Text = "";
            LblBirim.Text = "";
            LblTutanakNo.Text = "";
            MskEBYS.Text = "";
        }
        void TutanakYazdir()
        {
            try

            {
                if (TxtTeslimAlan.Text!="")
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
                        printer.SubTitle = "\n\n"+"             " + MskEBYS.Text + " EBYS nolu yazısı ile Bilgi Teknolojileri ve Haberleşme Şube Müdürlüğüne dolum ve bakım için verilen aşağıda bilgileri bulunan tonerlerin gerekli işlemleri yapılarak teslim edilmiştir. " + DateTime.Now.ToShortDateString();
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
                        dt.Rows.Add(1);
                        Dgw_Tonerler.DataSource = dt;
                        int s = 0;
                        s = Dgw_Tonerler.Rows.Count;
                        s = s - 1;
                        Dgw_Tonerler.Rows[s].Cells[3].Value = "\n\n\n\nTESLİM EDEN\n" + "Koray TUTAR" + "\n\n";
                        //teslim alan kısmı giriş yapan personel olacak
                        Dgw_Tonerler.Rows[s].Cells[4].Value = "\n\n\n\nTESLİM ALAN\n" + this.TxtTeslimAlan.Text.Trim().ToString() + "\n\n";
                        Dgw_Tonerler.Rows[s].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                        Dgw_Tonerler.Rows[s].DefaultCellStyle.BackColor = Color.White;

                        this.Dgw_Tonerler.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.Dgw_Tonerler.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.Dgw_Tonerler.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.Dgw_Tonerler.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.Dgw_Tonerler.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        this.Dgw_Tonerler.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.Dgw_Tonerler.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.Dgw_Tonerler.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        this.Dgw_Tonerler.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        this.Dgw_Tonerler.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        printer.PrintDataGridView(this.Dgw_Tonerler);

                        Dgw_Tonerler.Rows.RemoveAt(Dgw_Tonerler.Rows.Count - 1);

                        this.Cursor = Cursors.Default;
                        Kaydet();
                        Temizle();

                    }
                    else MessageBox.Show("Tutanağa Yazdırılacak Ürün Bulunamadı veya Ürünler daha önceden teslim edilmiş.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Teslim alan bilgisi girmelisiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tutanak Yazdırma Yazdırma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Kaydet()
        {
            SqlCommand komut = new SqlCommand("Update Tbl_TonerDolum set Durum=@p1, DolumTeslimTarihi=@p2, TeslimAlan=@p3 WHERE ID=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", "Teslim Edildi.");
            komut.Parameters.AddWithValue("@p2",  DateTime.Now.ToShortTimeString());
            komut.Parameters.AddWithValue("@p3", TxtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p4", LblTutanakNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        private void FrmDolumKapatma_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (TxtId.Text!="")
            {
                TxtEBYS.Text = "";
                TxtBirim.Text = "";

                TutanakArama();
                Vericek();
            }
            else if (TxtEBYS.Text!="")
            {
                TxtId.Text = "";
                TxtBirim.Text = "";

                EBYSTutanakArama();
                Vericek();
            }

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TutanakYazdir();
        }

        
        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            TxtEBYS.Text = "";
        }

        private void TxtEBYS_TextChanged(object sender, EventArgs e)
        {
            TxtId.Text = "";
        }
    }
}
