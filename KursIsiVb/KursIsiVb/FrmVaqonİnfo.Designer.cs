namespace KursIsiVb
{
    partial class FrmVaqonİnfoNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.DgvVaqonInfo = new System.Windows.Forms.DataGridView();
            this.BtnShowVaqonInfo = new System.Windows.Forms.Button();
            this.BtnAddVaqonInfo = new System.Windows.Forms.Button();
            this.TxtVaqonNo = new System.Windows.Forms.TextBox();
            this.TxtVaqonMarka = new System.Windows.Forms.TextBox();
            this.DtpBuraxilama = new System.Windows.Forms.DateTimePicker();
            this.LblVaqonNo = new System.Windows.Forms.Label();
            this.LblVaqonMarka = new System.Windows.Forms.Label();
            this.LblVaqonTipi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeleteVaqonInfo = new System.Windows.Forms.Button();
            this.CmbVaqonInfoNo = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.CkbVaqonTipYuk = new System.Windows.Forms.CheckBox();
            this.CkbVaqonTipSernisin = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVaqonInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(729, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DgvVaqonInfo
            // 
            this.DgvVaqonInfo.AllowUserToAddRows = false;
            this.DgvVaqonInfo.AllowUserToDeleteRows = false;
            this.DgvVaqonInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVaqonInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVaqonInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvVaqonInfo.Location = new System.Drawing.Point(-1, 43);
            this.DgvVaqonInfo.Name = "DgvVaqonInfo";
            this.DgvVaqonInfo.RowHeadersVisible = false;
            this.DgvVaqonInfo.Size = new System.Drawing.Size(770, 204);
            this.DgvVaqonInfo.TabIndex = 2;
            this.DgvVaqonInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnShowVaqonInfo
            // 
            this.BtnShowVaqonInfo.Location = new System.Drawing.Point(547, 294);
            this.BtnShowVaqonInfo.Name = "BtnShowVaqonInfo";
            this.BtnShowVaqonInfo.Size = new System.Drawing.Size(143, 32);
            this.BtnShowVaqonInfo.TabIndex = 3;
            this.BtnShowVaqonInfo.Text = "Melumatlar";
            this.BtnShowVaqonInfo.UseVisualStyleBackColor = true;
            this.BtnShowVaqonInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAddVaqonInfo
            // 
            this.BtnAddVaqonInfo.Location = new System.Drawing.Point(547, 365);
            this.BtnAddVaqonInfo.Name = "BtnAddVaqonInfo";
            this.BtnAddVaqonInfo.Size = new System.Drawing.Size(143, 32);
            this.BtnAddVaqonInfo.TabIndex = 4;
            this.BtnAddVaqonInfo.Text = "Əlavə et";
            this.BtnAddVaqonInfo.UseVisualStyleBackColor = true;
            this.BtnAddVaqonInfo.Click += new System.EventHandler(this.BtnAddVaqonInfo_Click);
            // 
            // TxtVaqonNo
            // 
            this.TxtVaqonNo.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVaqonNo.Location = new System.Drawing.Point(64, 302);
            this.TxtVaqonNo.Name = "TxtVaqonNo";
            this.TxtVaqonNo.Size = new System.Drawing.Size(143, 27);
            this.TxtVaqonNo.TabIndex = 5;
            // 
            // TxtVaqonMarka
            // 
            this.TxtVaqonMarka.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVaqonMarka.Location = new System.Drawing.Point(64, 370);
            this.TxtVaqonMarka.Name = "TxtVaqonMarka";
            this.TxtVaqonMarka.Size = new System.Drawing.Size(143, 27);
            this.TxtVaqonMarka.TabIndex = 6;
            // 
            // DtpBuraxilama
            // 
            this.DtpBuraxilama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpBuraxilama.Location = new System.Drawing.Point(308, 302);
            this.DtpBuraxilama.Name = "DtpBuraxilama";
            this.DtpBuraxilama.Size = new System.Drawing.Size(143, 24);
            this.DtpBuraxilama.TabIndex = 14;
            // 
            // LblVaqonNo
            // 
            this.LblVaqonNo.AutoSize = true;
            this.LblVaqonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVaqonNo.Location = new System.Drawing.Point(64, 283);
            this.LblVaqonNo.Name = "LblVaqonNo";
            this.LblVaqonNo.Size = new System.Drawing.Size(120, 16);
            this.LblVaqonNo.TabIndex = 16;
            this.LblVaqonNo.Text = "Qeydiyyat nömrəsi";
            // 
            // LblVaqonMarka
            // 
            this.LblVaqonMarka.AutoSize = true;
            this.LblVaqonMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVaqonMarka.Location = new System.Drawing.Point(64, 351);
            this.LblVaqonMarka.Name = "LblVaqonMarka";
            this.LblVaqonMarka.Size = new System.Drawing.Size(113, 16);
            this.LblVaqonMarka.TabIndex = 17;
            this.LblVaqonMarka.Text = "Vaqonun markası";
            // 
            // LblVaqonTipi
            // 
            this.LblVaqonTipi.AutoSize = true;
            this.LblVaqonTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVaqonTipi.Location = new System.Drawing.Point(305, 351);
            this.LblVaqonTipi.Name = "LblVaqonTipi";
            this.LblVaqonTipi.Size = new System.Drawing.Size(82, 16);
            this.LblVaqonTipi.TabIndex = 18;
            this.LblVaqonTipi.Text = "Vaqonun tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vaqonun buraxıma tarixi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnDeleteVaqonInfo
            // 
            this.BtnDeleteVaqonInfo.Location = new System.Drawing.Point(547, 441);
            this.BtnDeleteVaqonInfo.Name = "BtnDeleteVaqonInfo";
            this.BtnDeleteVaqonInfo.Size = new System.Drawing.Size(143, 32);
            this.BtnDeleteVaqonInfo.TabIndex = 20;
            this.BtnDeleteVaqonInfo.Text = "Sil";
            this.BtnDeleteVaqonInfo.UseVisualStyleBackColor = true;
            this.BtnDeleteVaqonInfo.Click += new System.EventHandler(this.BtnDeleteVaqonInfo_Click);
            // 
            // CmbVaqonInfoNo
            // 
            this.CmbVaqonInfoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbVaqonInfoNo.FormattingEnabled = true;
            this.CmbVaqonInfoNo.Location = new System.Drawing.Point(400, 443);
            this.CmbVaqonInfoNo.Name = "CmbVaqonInfoNo";
            this.CmbVaqonInfoNo.Size = new System.Drawing.Size(121, 28);
            this.CmbVaqonInfoNo.TabIndex = 21;
            this.CmbVaqonInfoNo.SelectedIndexChanged += new System.EventHandler(this.CmbVaqonInfoNo_SelectedIndexChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 403);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(770, 35);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // CkbVaqonTipYuk
            // 
            this.CkbVaqonTipYuk.AutoSize = true;
            this.CkbVaqonTipYuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbVaqonTipYuk.Location = new System.Drawing.Point(1, 3);
            this.CkbVaqonTipYuk.Name = "CkbVaqonTipYuk";
            this.CkbVaqonTipYuk.Size = new System.Drawing.Size(52, 22);
            this.CkbVaqonTipYuk.TabIndex = 23;
            this.CkbVaqonTipYuk.Text = "Yük";
            this.CkbVaqonTipYuk.UseVisualStyleBackColor = true;
            // 
            // CkbVaqonTipSernisin
            // 
            this.CkbVaqonTipSernisin.AutoSize = true;
            this.CkbVaqonTipSernisin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbVaqonTipSernisin.Location = new System.Drawing.Point(66, 3);
            this.CkbVaqonTipSernisin.Name = "CkbVaqonTipSernisin";
            this.CkbVaqonTipSernisin.Size = new System.Drawing.Size(80, 22);
            this.CkbVaqonTipSernisin.TabIndex = 24;
            this.CkbVaqonTipSernisin.Text = "Sərnişin";
            this.CkbVaqonTipSernisin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CkbVaqonTipSernisin);
            this.panel1.Controls.Add(this.CkbVaqonTipYuk);
            this.panel1.Location = new System.Drawing.Point(308, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 27);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sıra";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qeydiyyat No";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Marka";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tip";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Buraxılma tarixi";
            this.Column5.Name = "Column5";
            // 
            // FrmVaqonİnfoNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.CmbVaqonInfoNo);
            this.Controls.Add(this.BtnDeleteVaqonInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVaqonTipi);
            this.Controls.Add(this.LblVaqonMarka);
            this.Controls.Add(this.LblVaqonNo);
            this.Controls.Add(this.DtpBuraxilama);
            this.Controls.Add(this.TxtVaqonMarka);
            this.Controls.Add(this.TxtVaqonNo);
            this.Controls.Add(this.BtnAddVaqonInfo);
            this.Controls.Add(this.BtnShowVaqonInfo);
            this.Controls.Add(this.DgvVaqonInfo);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVaqonİnfoNo";
            this.Text = "FrmVaqonİnfo";
            this.Load += new System.EventHandler(this.FrmVaqonİnfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVaqonInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgvVaqonInfo;
        private System.Windows.Forms.Button BtnShowVaqonInfo;
        private System.Windows.Forms.Button BtnAddVaqonInfo;
        private System.Windows.Forms.TextBox TxtVaqonNo;
        private System.Windows.Forms.TextBox TxtVaqonMarka;
        private System.Windows.Forms.DateTimePicker DtpBuraxilama;
        private System.Windows.Forms.Label LblVaqonNo;
        private System.Windows.Forms.Label LblVaqonMarka;
        private System.Windows.Forms.Label LblVaqonTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDeleteVaqonInfo;
        private System.Windows.Forms.ComboBox CmbVaqonInfoNo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.CheckBox CkbVaqonTipYuk;
        private System.Windows.Forms.CheckBox CkbVaqonTipSernisin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}