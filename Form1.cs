using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace KasaDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

            lbData.Items.Clear();
            decimal totalHarcama = 0;
            decimal totalGelir = 0;
            foreach (var item in DataList.Veriler)
            {

                if (item.Girismi)
                {
                    totalGelir += item.Fiyat;
                    lbData.Items.Add($"{item.Tarih} tarihinde, {item.Aciklama} açıklaması ile {item.Fiyat}TL para girişi yapılmıştır.");
                }
                else
                {
                    totalHarcama += item.Fiyat;
                    lbData.Items.Add($"{item.Tarih} tarihinde, {item.Aciklama} açıklaması ile {item.Fiyat}TL harcama yapılmıştır.");
                }
            }
            lblDurum.Text = $"Kasada Kalan Para Miktarı : {(DataList.Maas + totalGelir) - totalHarcama}TL";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
