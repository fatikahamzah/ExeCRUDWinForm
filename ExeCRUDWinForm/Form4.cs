using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRUDMahasiswaDataSet2.InformasiMataKuliah' table. You can move, or remove it, as needed.
            this.informasiMataKuliahTableAdapter.Fill(this.cRUDMahasiswaDataSet2.InformasiMataKuliah);

        }
    }
}
