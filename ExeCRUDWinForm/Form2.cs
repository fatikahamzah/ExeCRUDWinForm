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
using System.Configuration;


namespace ExeCRUDWinForm
{
    public partial class Form2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection con;
        SqlCommand CMD;
        SqlDataAdapter adapter;
        DataTable dt;

        public void ShowDataOnGridView()
        {
            using (con = new SqlConnection(cs))
            {
                adapter = new SqlDataAdapter("Select * From Mahasiswa", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewMahasiswa.DataSource = dt;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CRUDMahasiswaDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.cRUDMahasiswaDataSet.Mahasiswa);

        }

        private void dgViewMahasiswa_CellClick(object sender, DataGridViewCellCancelEventArgs e)
        {
            txtName.Text = this.dgViewMahasiswa.CurrentRow.Cells["Name"].Value.ToString();
            cmBoxGender.Text = this.dgViewMahasiswa.CurrentRow.Cells["Gender"].Value.ToString();
            txtPhone.Text = this.dgViewMahasiswa.CurrentRow.Cells["Phone"].Value.ToString();
            txtEmail.Text = this.dgViewMahasiswa.CurrentRow.Cells["Email"].Value.ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using(con=new SqlConnection(cs))
            {
                con.Open();
                CMD = new SqlCommand("Insert Into Mahasiswa (Name, Gender, Phone, Email) Values(@name, @gender, @phone, @email)", con);
                CMD.Parameters.AddWithValue("@name", txtName.Text);
                CMD.Parameters.AddWithValue("@gender", cmBoxGender.SelectedItem);
                CMD.Parameters.AddWithValue("@phone", txtPhone.Text);
                CMD.Parameters.AddWithValue("@email", txtEmail.Text);

                CMD.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully");
                ShowDataOnGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
