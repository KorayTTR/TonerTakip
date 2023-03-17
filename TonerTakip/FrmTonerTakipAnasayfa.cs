using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonerTakip
{
    public partial class FrmTonerTakipAnasayfa : Form
    {
        public FrmTonerTakipAnasayfa()
        {
            InitializeComponent();
        }

        FrmDolumGiris frm1;
        private void BthDolumGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new FrmDolumGiris();
                frm1.MdiParent = this;
                frm1.Show();
            }
        }
        FrmDolumKapatma frm2;
        private void BtnDolumKapatma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm1.IsDisposed)
            {
                frm2 = new FrmDolumKapatma();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }
               

        FrmTonerDagitim frm3;
        private void BtnTonerDagitim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm1.IsDisposed)
            {
                frm3 = new FrmTonerDagitim();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }
    }
}
