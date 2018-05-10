using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursIsiVb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FrmVaqonİnfoNo frmVaqon = new FrmVaqonİnfoNo();
        FrmTemirInfo frmTemir = new FrmTemirInfo();
        FrmIsciInfo frmIsci = new FrmIsciInfo();
        Sorgular frmSorgu = new Sorgular();

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Transparent;

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="elcin" && textBox2.Text=="elcin")
            {
                PnlLogin.Controls.Clear();
                PnlMenu.Visible = true;
                PnlLogin.Visible = false;

                //PnlMain.Controls.Clear();
                frmVaqon.FormBorderStyle = FormBorderStyle.None;
                frmVaqon.TopLevel = false;
                frmVaqon.AutoScroll = true;
                panel4.Controls.Add(frmVaqon);
                //PnlMenu.Visible = false;
                frmVaqon.Show();
                BtnIsciForm.BackColor = Color.FromArgb(25, 95, 110);
                BtnTemirForm.BackColor = Color.FromArgb(25, 95, 110);
                BtnSorgu.BackColor = Color.FromArgb(25, 95, 110);
                BtnVaqonForm.BackColor = Color.FromArgb(15, 110, 150);
                
                //PnlMain.Controls.Clear();
                //FrmVaqonİnfoNo frmVaqon = new FrmVaqonİnfoNo();
                //frmVaqon.FormBorderStyle = FormBorderStyle.None;
                //frmVaqon.TopLevel = false;
                //frmVaqon.AutoScroll = true;
                //PnlMain.Controls.Add(frmVaqon);
                //frmVaqon.Show();


            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yalnışdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Clear();
                textBox2.Clear();
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSelectİnfo_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnIsciForm_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            panel4.BackgroundImage = null;
            //FrmIsciInfo frmIsci = new FrmIsciInfo();
            frmIsci.FormBorderStyle = FormBorderStyle.None;
            frmIsci.TopLevel = false;
            frmIsci.AutoScroll = true;
            frmTemir.Hide();
            frmVaqon.Hide();
            frmSorgu.Hide();
            //panel4.Controls.Clear();
            panel4.Controls.Add(frmIsci);
            frmIsci.Show();
            BtnVaqonForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnTemirForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnSorgu.BackColor = Color.FromArgb(25, 95, 110);
            BtnIsciForm.BackColor = Color.FromArgb(15, 110, 150);
        }

        private void PnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(95)))), ((int)(((byte)(110)))));
            panel4.BackgroundImage = Image.FromFile(@"C:\Users\MR.AGHAYEV\source\repos\KursIsiVb\KursIsiVb\bin\Debug\\demiryol.jpg");
            panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.Visible = true;
            frm.Show();
            Hide();
            BtnIsciForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnTemirForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnSorgu.BackColor = Color.FromArgb(25, 95, 110);
            BtnVaqonForm.BackColor = Color.FromArgb(15, 110, 150);
        }

        private void BtnVaqonForm_Click(object sender, EventArgs e)
        {
            panel4.BackgroundImage = null;
            panel4.Controls.Clear();
            frmTemir.Hide();
            frmIsci.Hide();
            frmSorgu.Hide();
            panel4.Controls.Add(frmVaqon);
            frmVaqon.Show();
            button2.Visible = false;
            BtnIsciForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnTemirForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnSorgu.BackColor = Color.FromArgb(25, 95, 110);
            BtnVaqonForm.BackColor = Color.FromArgb(15, 110, 150);
        }

        private void BtnTemirForm_Click(object sender, EventArgs e)
        {
            panel4.BackgroundImage = null;
            //FrmTemirInfo frmTemir = new FrmTemirInfo();
            frmTemir.FormBorderStyle = FormBorderStyle.None;
            frmTemir.TopLevel = false;
            frmTemir.AutoScroll = true;
            frmVaqon.Hide();
            frmIsci.Hide();
            frmSorgu.Hide();
            //panel4.Controls.Clear();
            panel4.Controls.Add(frmTemir);
            frmTemir.Show();
            BtnIsciForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnVaqonForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnSorgu.BackColor = Color.FromArgb(25, 95, 110);
            BtnTemirForm.BackColor = Color.FromArgb(15, 110, 150);
        }

        private void BtnSorgu_Click(object sender, EventArgs e)
        {
            panel4.BackgroundImage = null;
            frmSorgu.TopLevel = false;
            frmSorgu.AutoScroll = true;
            frmVaqon.Hide();
            frmIsci.Hide();
            frmTemir.Hide();
            panel4.Controls.Add(frmSorgu);
            frmSorgu.Show();
            BtnIsciForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnVaqonForm.BackColor = Color.FromArgb(25, 95, 110);
            BtnTemirForm.BackColor = Color.FromArgb(25,95,110);
            BtnSorgu.BackColor = Color.FromArgb(15, 110, 150);
        }
    }
}
