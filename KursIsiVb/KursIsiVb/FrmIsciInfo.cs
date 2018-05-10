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
    public partial class FrmIsciInfo : Form
    {
        public FrmIsciInfo()
        {
            InitializeComponent();
        }
        
        SqlConnection elaqe = new SqlConnection(@"Data Source=MRAGHAYEV-PC\SQLEXPRESS;Initial Catalog=VB_kurs_isi;Integrated Security=True");
        private void melumatlar()
        {
            //elaqe.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from Isci_Info", elaqe);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //DgvIsciInfo.DataSource = ds.Tables[0];
            //elaqe.Close();
            DgvIsciInfo.Rows.Clear();
            CmbIsciBriqada.Items.Clear();
            CmbBriqadaAdd.Items.Clear();
            CmbIsciSoyad.Items.Clear();
            CmbIsciAd.Items.Clear();
            elaqe.Open();
            string query = "select *from Isci_Info";
            SqlCommand cmd = new SqlCommand(query,elaqe);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DgvIsciInfo.Rows.Add(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }

            elaqe.Close();


            elaqe.Open();
            string query1 = "select Briqada from Briqadalar";
            SqlCommand cmd1 = new SqlCommand(query1, elaqe);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                CmbBriqadaAdd.Items.Add(reader1.GetString(0));
                CmbIsciBriqada.Items.Add(reader1.GetString(0));
            }
            elaqe.Close();

        

            
            CmbUpdate();
           
        }
        private void CmbUpdate()
        {
            CmbIsciAd.Items.Clear();
            CmbIsciBriqada.Text = string.Empty;
            CmbIsciSoyad.Items.Clear();

            elaqe.Open();
            string query = "select * from Isci_Info";
            SqlCommand cmd = new SqlCommand(query, elaqe);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //CmbIsciBriqada
            }
            elaqe.Close();
           
        }
        private void FrmIsciInfo_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbİsciBriqada_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIsciSoyad.ResetText();
            CmbIsciSoyad.Items.Clear();
            CmbIsciAd.ResetText();
            CmbIsciAd.Items.Clear();
            elaqe.Open();
            string query2 = " select Ad,Soyad from Isci_Info where Temir_briqadasi='" + CmbIsciBriqada.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, elaqe);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbIsciAd.Items.Add(reader2.GetString(0));
                CmbIsciSoyad.Items.Add(reader2.GetString(1));
            }
            elaqe.Close();
        }

        private void BtnAddIsciInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtIsciAd.Text) && !string.IsNullOrEmpty(TxtIsciAtaAdi.Text) && !string.IsNullOrEmpty(CmbBriqadaAdd.Text) && !string.IsNullOrEmpty(TxtIsciMukafat.Text) && !string.IsNullOrEmpty(TxtIsciSoyad.Text) && !string.IsNullOrEmpty(TxtIsciVezife.Text)&&!string.IsNullOrEmpty(TxtMukafatSebeb.Text))
            {

                elaqe.Open();
                string s = "insert into Isci_Info values(@Ad,@Soyad,@Ata_adi,@Vezife,@Temir_briqadasi,@Mukafat_meblegi,@Mukafat_sebebi)";
                SqlCommand emr = new SqlCommand(s, elaqe);
                emr.Parameters.AddWithValue("@Ad", TxtIsciAd.Text);
                emr.Parameters.AddWithValue("@Soyad", TxtIsciSoyad.Text);
                emr.Parameters.AddWithValue("@Ata_adi", TxtIsciAtaAdi.Text);
                emr.Parameters.AddWithValue("@Vezife", TxtIsciVezife.Text);
                emr.Parameters.AddWithValue("@Temir_briqadasi", CmbBriqadaAdd.Text);
                emr.Parameters.AddWithValue("@Mukafat_meblegi", TxtIsciMukafat.Text);
                emr.Parameters.AddWithValue("@Mukafat_sebebi", TxtMukafatSebeb.Text);

                emr.ExecuteNonQuery();
                elaqe.Close();
                CmbUpdate();
                melumatlar();
                elaqe.Close();
                TxtMukafatSebeb.Text = string.Empty;
                TxtIsciVezife.Text = string.Empty;
                TxtIsciSoyad.Text = string.Empty;
                TxtIsciMukafat.Text = string.Empty;
                CmbBriqadaAdd.Text = string.Empty;
                TxtIsciAtaAdi.Text = string.Empty;
                TxtIsciAd.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Bütün məlumatları düzgün daxil edin!", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnShowIsciInfo_Click(object sender, EventArgs e)
        {
            melumatlar();
        }

        private void BtnDeleteIsciInfo_Click(object sender, EventArgs e)
        {
            elaqe.Open();
            SqlCommand sil = new SqlCommand("delete from Isci_Info where Ad=@Ad", elaqe);
            sil.Parameters.AddWithValue("@Ad", CmbIsciAd.Text);

            sil.ExecuteNonQuery();
            elaqe.Close();
            elaqe.Open();
            SqlCommand sil1 = new SqlCommand("delete from Isci_Info where Soyad=@Soyad",elaqe);
            sil1.Parameters.AddWithValue("@Ad",CmbIsciSoyad.Text);
            elaqe.Close();
            elaqe.Open();
            SqlCommand sil2 = new SqlCommand("delete from Isci_Info where Temir_briqadasi=@Temir_briqadasi",elaqe);
            elaqe.Close();
            melumatlar();
            CmbUpdate();
            //cm.Text = string.Empty;

        }

        private void TxtIsciBriqada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbIsciSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DgvIsciInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbIsciAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbIsciSoyad.Items.Clear();
            CmbIsciSoyad.ResetText();
            string newAd = CmbIsciAd.Text;
            
                newAd = newAd.Replace("ə", "%");
                newAd = newAd.Replace("ı", "%");
                newAd = newAd.Replace("ö", "%");
                newAd = newAd.Replace("ü", "%");
                newAd = newAd.Replace("ğ", "%");

            elaqe.Open();

            string query2 = " select * from Isci_Info where Ad like '" + newAd + "' and Temir_briqadasi='"+CmbIsciBriqada.Text+"'";
            SqlCommand cmd2 = new SqlCommand(query2, elaqe);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbIsciSoyad.Items.Add(reader2.GetString(2));
            }
            elaqe.Close();
        }
    }
}
