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
    public partial class FrmTemirInfo : Form
    {
        public FrmTemirInfo()
        {
            InitializeComponent();
            //string[] briqadalar = { "Adi təmmir", "Orta təmmir", "Texniki baxış", "Planlaşdırılmamış təmir" };
            ////CmbTemirBriqadasi.Items.AddRange(briqadalar);
            //string[] keyfiyyet = { "Aşağı", "Orta", "Yüksək" };
            //CmbTemirKeyfiyyeti.Items.AddRange(keyfiyyet);
            //CmbTemirNovu.Items.AddRange(briqadalar);

        }
        SqlConnection elaqe = new SqlConnection(@"Data Source=MRAGHAYEV-PC\SQLEXPRESS;Initial Catalog=VB_kurs_isi;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Server=MRAGHAYEV-PC\SQLEXPRESS; Database=VB_kurs_isi;Integrated Security=SSPI;");
        private void melumatlar()
        {
            elaqe.Open();
            DgvTemirInfo.Rows.Clear();
            string sorgu = "select Temir_info.Id,Temir_Info.Qeydiyyat_No,Temir_Info.Temir_novu,Temir_Info.Temir_meblegi,Temir_Info.Temir_keyfiyyeti,Temir_Info.Baslama_tarixi,Temir_Info.Bitme_tarixi,Briqadalar.Briqada,Temir_Info.Temir_sebebi  from Temir_Info";
            string sorguC = " inner join Briqadalar on Temir_Info.BriqadaId=Briqadalar.Id ";
            SqlCommand emr1 = new SqlCommand(sorgu + sorguC, elaqe);
            SqlDataReader reader = emr1.ExecuteReader();
            while (reader.Read())
            {
                DgvTemirInfo.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDateTime(5).ToString("dd.MM.yyyy"), reader.GetDateTime(6).ToString("dd.MM.yyyy"), reader.GetString(7), reader.GetString(8));
            }
            elaqe.Close();
            elaqe.Open();
            SqlCommand emr = new SqlCommand("select * from Vaqon_Info", elaqe);
            SqlDataReader oxu = emr.ExecuteReader();
            CmbQeydiyyatNo.Items.Clear();
            CmbTemirVaqonNo.Items.Clear();
            while (oxu.Read())
            {
                CmbQeydiyyatNo.Items.Add(oxu.GetString(1));
                CmbTemirVaqonNo.Items.Add(oxu.GetString(1));
            }
            elaqe.Close();


            //  CmbUpdate();
        }
        private void CmbUpdate()
        {
            CmbTemirBriqadasi.ResetText();
            CmbQeydiyyatNo.ResetText();
            CmbTemirKeyfiyyeti.ResetText();
            CmbTemirNovu.ResetText();
            CmbQeydiyyatNo.ResetText();
            CmbTemirVaqonNo.ResetText();
            TxtTemirMebleg.ResetText();
            TxtTemirSebeb.ResetText();

        }
        private void BtnAddTemirInfo_Click(object sender, EventArgs e)
        {
            string VaqonNo = CmbTemirVaqonNo.Text;
            string TemirNovu = CmbTemirNovu.Text;
            string TemirKeyfiyyeti = CmbTemirKeyfiyyeti.Text;
            string TemirMeblegi = TxtTemirMebleg.Text;
            string TemirSebeb = TxtTemirSebeb.Text;
            string TemirBriqadasi = CmbTemirBriqadasi.Text;
            //DateTime TemirBitme =new DateTime(DtpTemirBitme.Value.Day, DtpTemirBitme.Value.Month, DtpTemirBitme.Value.Year);
            //DateTime TemirBaslama = new DateTime(DtpTemirBaslama.AddHours(-1));     
            //MessageBox.Show(TemirBitme.ToString());
            int BriqadaId = 0;
            elaqe.Open();
            string query1 = "select Id from Briqadalar Where Briqada='"+TemirBriqadasi+"'";
            SqlCommand cmd1 = new SqlCommand(query1, elaqe);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                BriqadaId = reader1.GetInt32(0);
            }
            elaqe.Close();


            if (VaqonNo == string.Empty || TemirNovu == string.Empty || TemirKeyfiyyeti == string.Empty || TemirMeblegi == string.Empty || TemirSebeb == string.Empty || DtpTemirBaslama.Text==string.Empty || DtpTemirBitme.Text == string.Empty)
            {
                MessageBox.Show("Zəhmət olmasa bütün məlumatları düzgün daxil edin");
                return;
            }

            elaqe.Open();


            string sorgu = "insert into  Temir_Info(Qeydiyyat_No,Temir_novu,Temir_meblegi,Temir_keyfiyyeti,Baslama_tarixi,Bitme_tarixi,BriqadaId,Temir_sebebi)";
            string sorguC = " values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
            SqlCommand cmd = new SqlCommand(sorgu + sorguC, elaqe);
            cmd.Parameters.AddWithValue("@a1", VaqonNo);
            cmd.Parameters.AddWithValue("@a2", TemirNovu);
            cmd.Parameters.AddWithValue("@a3", TemirMeblegi);
            cmd.Parameters.AddWithValue("@a4", TemirKeyfiyyeti);
            cmd.Parameters.AddWithValue("@a5", DtpTemirBaslama.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@a6", DtpTemirBitme.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@a7", BriqadaId);
            cmd.Parameters.AddWithValue("@a8", TemirSebeb);
            int affRows = cmd.ExecuteNonQuery();
            elaqe.Close();
            melumatlar();
            CmbUpdate();
        }

        private void DgvTemirInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbQeydiyyatNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDeleteTemirInfo_Click(object sender, EventArgs e)
        {
            string Deleted = CmbQeydiyyatNo.Text;
            elaqe.Open();
            string query = "delete from Temir_Info where Qeydiyyat_No='" + Deleted + "' ";
            SqlCommand DeleteCom = new SqlCommand(query, elaqe);
            int affRows = DeleteCom.ExecuteNonQuery();
            elaqe.Close();
            CmbUpdate();
            melumatlar();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnShowTemirInfo_Click(object sender, EventArgs e)
        {
            melumatlar();
            CmbUpdate();
        }

        private void FrmTemirInfo_Load(object sender, EventArgs e)
        {
            DtpTemirBitme.Format = DateTimePickerFormat.Custom;
            DtpTemirBitme.CustomFormat = "dd/MM/yyyy";
            DtpTemirBaslama.Format = DateTimePickerFormat.Custom;
            DtpTemirBaslama.CustomFormat = "dd / MM / yyyy";
        }

        private void BtnTemirDeletAll_Click(object sender, EventArgs e)
        {
            int length = DgvTemirInfo.Rows.Count;
            MessageBox.Show(length.ToString());

            elaqe.Open();
            for (int i = 0; i <= length; i++)
            {
                string query = "delete from Temir_Info where Id='" + (i + 1) + "'";
                SqlCommand cmd = new SqlCommand(query, elaqe);
                int affRows = cmd.ExecuteNonQuery();
            }
            elaqe.Close();
            CmbUpdate();
            melumatlar();
        }
    }
}
