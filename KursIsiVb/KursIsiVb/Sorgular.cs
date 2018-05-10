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

namespace KursIsiVb
{
    public partial class Sorgular : Form
    {
        public Sorgular()
        {
            InitializeComponent();
            fill();
        }
        SqlConnection elaqe = new SqlConnection(@"Data Source=MRAGHAYEV-PC\SQLEXPRESS;Initial Catalog=VB_kurs_isi;Integrated Security=True");
        private void fill()
        {
            elaqe.Open();
            string query = "select Briqada from Briqadalar";
            SqlCommand cmd = new SqlCommand(query, elaqe);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CmbBriqada.Items.Add(reader.GetString(0));
            }
            elaqe.Close();
            elaqe.Open();
            string query1 = "select  * from Vaqon_Info";
            SqlCommand cmd1 = new SqlCommand(query1, elaqe);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                CmbSorguVaqonNo.Items.Add(reader1.GetString(1));
            }
            elaqe.Close();

            elaqe.Open();
            string query2 = "select  * from Vaqon_Info";
            SqlCommand cmd2 = new SqlCommand(query2, elaqe);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbMarkas.Items.Add(reader2.GetString(1));
            }
            elaqe.Close();
        }
        private void Sorgular_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(CmbBriqada.Text)&&string.IsNullOrEmpty(CmbSorguVaqonNo.Text))|| (!string.IsNullOrEmpty(CmbBriqada.Text) && !string.IsNullOrEmpty(CmbSorguVaqonNo.Text)))
            {
                MessageBox.Show("Məlumatları düzgün daxil edin");
                return;
            }
            if (!string.IsNullOrEmpty(CmbBriqada.Text))
            {
                DgvVaqonNo.Visible = false;
                DgvSorguBriqada.Visible = true;
                DgvSorguBriqada.Rows.Clear();
                elaqe.Open();
                string query1 = "select Ad,Soyad,Vezife from Isci_Info where Temir_briqadasi='"+CmbBriqada.Text+"'";
                SqlCommand cmd1 = new SqlCommand(query1, elaqe);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    DgvSorguBriqada.Rows.Add(reader1.GetString(0), reader1.GetString(1), reader1.GetString(2));
                }
                elaqe.Close();
            }
            if (!string.IsNullOrEmpty(CmbSorguVaqonNo.Text))
            {
                DgvVaqonNo.Rows.Clear();
                DgvSorguBriqada.Visible = false;
                DgvVaqonNo.Visible = true;

                elaqe.Open();

                //string query2 = "select Marka,Tip,Buraxilma_tarixi,Temir_novu,Temir_meblegi from Vaqon_Info  full outer join  Temir_Info on Vaqon_Info.Qeydiyyat_No=Temir_Info.Qeydiyyat_No where Vaqon_Info.Qeydiyyat_No='" + CmbSorguVaqonNo.Text + "'";
                //SqlCommand cmd2=new SqlCommand(query2,elaqe);
                //SqlDataReader reader2 = cmd2.ExecuteReader();
                //while (reader2.Read())
                //{
                //    if (reader2.GetString(3).ToString().Length<6)
                //    {
                //        DgvVaqonNo.Rows.Add(reader2.GetString(0), reader2.GetString(1), reader2.GetDateTime(2), "Təmir edilməyib", "Təmir edilməyib");
                //    }
                //    else
                //    {
                //        DgvVaqonNo.Rows.Add(reader2.GetString(0), reader2.GetString(1), reader2.GetDateTime(2), reader2.GetString(3), reader2.GetString(4));
                //    }
                //}

                string query2 = "select Qeydiyyat_No,Marka,Tip,Buraxilma_tarixi from Vaqon_Info where Qeydiyyat_No='" + CmbSorguVaqonNo.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query2, elaqe);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    
                        DgvVaqonNo.Rows.Add(reader2.GetString(0), reader2.GetString(1), reader2.GetString(2), reader2.GetDateTime(3).ToString("dd.MM.yyyy"));
                    
                }
                elaqe.Close();
            }
        }

        private void CmbSorguVaqonNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBriqada.ResetText();
        }

        private void CmbBriqada_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSorguVaqonNo.ResetText();
        }
    }
}
