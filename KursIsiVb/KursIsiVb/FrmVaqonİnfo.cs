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
    public partial class FrmVaqonİnfoNo : Form
    {
        public FrmVaqonİnfoNo()
        {
            InitializeComponent();
        }
        SqlConnection elaqe = new SqlConnection(@"Data Source=MRAGHAYEV-PC\SQLEXPRESS;Initial Catalog=VB_kurs_isi;Integrated Security=True");
        private void melumatlar()
        {
            elaqe.Open();
            DgvVaqonInfo.Rows.Clear();
            string query = "select * from Vaqon_Info";
            SqlCommand cmd = new SqlCommand(query, elaqe);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DgvVaqonInfo.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4).ToString("dd.MM.yyyy"));
            }
            elaqe.Close();
            CmbUpdate();
        }
        private void CmbUpdate()
        {
            CmbVaqonInfoNo.Items.Clear();

            elaqe.Open();
            SqlCommand emr = new SqlCommand("select Qeydiyyat_No from Vaqon_Info", elaqe);
            SqlDataReader oxu = emr.ExecuteReader();
            while (oxu.Read())
            {
                CmbVaqonInfoNo.Items.Add(oxu["Qeydiyyat_No"]);
            }
            elaqe.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            melumatlar();
        }

        private void FrmVaqonİnfo_Load(object sender, EventArgs e)
        {
            DtpBuraxilama.Format = DateTimePickerFormat.Custom;
            DtpBuraxilama.CustomFormat = "dd / MM / yyyy";
            //CmbUpdate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddVaqonInfo_Click(object sender, EventArgs e)
        {
            string VaqonTip = "0";
            if ((CkbVaqonTipSernisin.Checked && CkbVaqonTipYuk.Checked) || (!CkbVaqonTipYuk.Checked && !CkbVaqonTipSernisin.Checked))
            {
                MessageBox.Show("Vaqonun tipini döğru seçin");
                CkbVaqonTipYuk.Checked = false;
                CkbVaqonTipSernisin.Checked = false;

            }

            else
            {
                if (CkbVaqonTipSernisin.Checked)
                {
                    VaqonTip = CkbVaqonTipSernisin.Text;
                }
                else
                {
                    VaqonTip = CkbVaqonTipYuk.Text;
                }
                CkbVaqonTipYuk.Checked = false;
                CkbVaqonTipSernisin.Checked = false;
            }

            if (!string.IsNullOrEmpty(TxtVaqonMarka.Text) && !string.IsNullOrEmpty(TxtVaqonNo.Text) && (VaqonTip != "0"))
            {
                elaqe.Open();
                string s = "insert into Vaqon_Info values(@Qeydiyyat_No,@marka,@tip,@buraxilma_tarixi)";
                SqlCommand emr = new SqlCommand(s, elaqe);
                emr.Parameters.AddWithValue("@Qeydiyyat_No", TxtVaqonNo.Text);
                emr.Parameters.AddWithValue("@marka", TxtVaqonMarka.Text);
                emr.Parameters.AddWithValue("@tip", VaqonTip);
                emr.Parameters.AddWithValue("@buraxilma_tarixi", DtpBuraxilama.Value.ToString("yyyy-MM-dd"));
                emr.ExecuteNonQuery();
                elaqe.Close();
                CmbUpdate();
                melumatlar();
                elaqe.Close();
                TxtVaqonMarka.Text = string.Empty;
                TxtVaqonNo.Text = string.Empty;
                //CkbVaqonTipSernisin.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Bütün məlumatları düzgün daxil edin!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DtpBazayaGiris_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnDeleteVaqonInfo_Click(object sender, EventArgs e)
        {
            elaqe.Open();
            SqlCommand sil = new SqlCommand("delete from Vaqon_Info where Qeydiyyat_No=@No", elaqe);
            sil.Parameters.AddWithValue("@No", CmbVaqonInfoNo.Text);
            sil.ExecuteNonQuery();
            elaqe.Close();
            melumatlar();
            CmbUpdate();
            CmbVaqonInfoNo.Text = string.Empty;
        }

        private void CmbVaqonInfoNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
