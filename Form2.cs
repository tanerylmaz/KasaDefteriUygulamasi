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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            d.Tarih = dtpDate.Value;
            d.Aciklama = txtDescription.Text;
            d.Fiyat = Convert.ToDecimal(txtPrice.Text);
            d.Girismi = !chkHarcama.Checked;

            DataList.Veriler.Add(d);

            this.Close();
        }
    }
}
