namespace KursIsiVb
{
    partial class FrmIsciInfo
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
            this.CmbIsciBriqada = new System.Windows.Forms.ComboBox();
            this.BtnDeleteIsciInfo = new System.Windows.Forms.Button();
            this.LblIsciBriqada = new System.Windows.Forms.Label();
            this.LblIsciAtaAdi = new System.Windows.Forms.Label();
            this.LblIsciAd = new System.Windows.Forms.Label();
            this.TxtIsciAtaAdi = new System.Windows.Forms.TextBox();
            this.TxtIsciAd = new System.Windows.Forms.TextBox();
            this.BtnAddIsciInfo = new System.Windows.Forms.Button();
            this.BtnShowIsciInfo = new System.Windows.Forms.Button();
            this.DgvIsciInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.LblIsciMukafat = new System.Windows.Forms.Label();
            this.LblIsciVezife = new System.Windows.Forms.Label();
            this.LblIsciSoyad = new System.Windows.Forms.Label();
            this.TxtIsciMukafat = new System.Windows.Forms.TextBox();
            this.TxtIsciVezife = new System.Windows.Forms.TextBox();
            this.TxtIsciSoyad = new System.Windows.Forms.TextBox();
            this.LblIsciDeleteBriqada = new System.Windows.Forms.Label();
            this.LblIsciDeleteAd = new System.Windows.Forms.Label();
            this.LblIsciDeleteSoyad = new System.Windows.Forms.Label();
            this.CmbIsciAd = new System.Windows.Forms.ComboBox();
            this.CmbIsciSoyad = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TxtMukafatSebeb = new System.Windows.Forms.RichTextBox();
            this.LblMukafatSebebi = new System.Windows.Forms.Label();
            this.CmbBriqadaAdd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIsciInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbIsciBriqada
            // 
            this.CmbIsciBriqada.FormattingEnabled = true;
            this.CmbIsciBriqada.Location = new System.Drawing.Point(12, 460);
            this.CmbIsciBriqada.Name = "CmbIsciBriqada";
            this.CmbIsciBriqada.Size = new System.Drawing.Size(121, 21);
            this.CmbIsciBriqada.TabIndex = 35;
            this.CmbIsciBriqada.SelectedIndexChanged += new System.EventHandler(this.CmbİsciBriqada_SelectedIndexChanged);
            // 
            // BtnDeleteIsciInfo
            // 
            this.BtnDeleteIsciInfo.Location = new System.Drawing.Point(592, 447);
            this.BtnDeleteIsciInfo.Name = "BtnDeleteIsciInfo";
            this.BtnDeleteIsciInfo.Size = new System.Drawing.Size(143, 32);
            this.BtnDeleteIsciInfo.TabIndex = 34;
            this.BtnDeleteIsciInfo.Text = "Sil";
            this.BtnDeleteIsciInfo.UseVisualStyleBackColor = true;
            this.BtnDeleteIsciInfo.Click += new System.EventHandler(this.BtnDeleteIsciInfo_Click);
            // 
            // LblIsciBriqada
            // 
            this.LblIsciBriqada.AutoSize = true;
            this.LblIsciBriqada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciBriqada.Location = new System.Drawing.Point(173, 315);
            this.LblIsciBriqada.Name = "LblIsciBriqada";
            this.LblIsciBriqada.Size = new System.Drawing.Size(103, 16);
            this.LblIsciBriqada.TabIndex = 32;
            this.LblIsciBriqada.Text = "Təmir briqadası";
            // 
            // LblIsciAtaAdi
            // 
            this.LblIsciAtaAdi.AutoSize = true;
            this.LblIsciAtaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciAtaAdi.Location = new System.Drawing.Point(9, 372);
            this.LblIsciAtaAdi.Name = "LblIsciAtaAdi";
            this.LblIsciAtaAdi.Size = new System.Drawing.Size(50, 16);
            this.LblIsciAtaAdi.TabIndex = 31;
            this.LblIsciAtaAdi.Text = "Ata adı";
            // 
            // LblIsciAd
            // 
            this.LblIsciAd.AutoSize = true;
            this.LblIsciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciAd.Location = new System.Drawing.Point(9, 254);
            this.LblIsciAd.Name = "LblIsciAd";
            this.LblIsciAd.Size = new System.Drawing.Size(25, 16);
            this.LblIsciAd.TabIndex = 30;
            this.LblIsciAd.Text = "Ad";
            // 
            // TxtIsciAtaAdi
            // 
            this.TxtIsciAtaAdi.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsciAtaAdi.Location = new System.Drawing.Point(12, 391);
            this.TxtIsciAtaAdi.Name = "TxtIsciAtaAdi";
            this.TxtIsciAtaAdi.Size = new System.Drawing.Size(143, 27);
            this.TxtIsciAtaAdi.TabIndex = 3;
            // 
            // TxtIsciAd
            // 
            this.TxtIsciAd.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsciAd.Location = new System.Drawing.Point(12, 273);
            this.TxtIsciAd.Name = "TxtIsciAd";
            this.TxtIsciAd.Size = new System.Drawing.Size(143, 27);
            this.TxtIsciAd.TabIndex = 1;
            // 
            // BtnAddIsciInfo
            // 
            this.BtnAddIsciInfo.Location = new System.Drawing.Point(592, 359);
            this.BtnAddIsciInfo.Name = "BtnAddIsciInfo";
            this.BtnAddIsciInfo.Size = new System.Drawing.Size(143, 32);
            this.BtnAddIsciInfo.TabIndex = 25;
            this.BtnAddIsciInfo.Text = "Əlavə et";
            this.BtnAddIsciInfo.UseVisualStyleBackColor = true;
            this.BtnAddIsciInfo.Click += new System.EventHandler(this.BtnAddIsciInfo_Click);
            // 
            // BtnShowIsciInfo
            // 
            this.BtnShowIsciInfo.Location = new System.Drawing.Point(592, 292);
            this.BtnShowIsciInfo.Name = "BtnShowIsciInfo";
            this.BtnShowIsciInfo.Size = new System.Drawing.Size(143, 32);
            this.BtnShowIsciInfo.TabIndex = 24;
            this.BtnShowIsciInfo.Text = "Melumatlar";
            this.BtnShowIsciInfo.UseVisualStyleBackColor = true;
            this.BtnShowIsciInfo.Click += new System.EventHandler(this.BtnShowIsciInfo_Click);
            // 
            // DgvIsciInfo
            // 
            this.DgvIsciInfo.AllowUserToAddRows = false;
            this.DgvIsciInfo.AllowUserToDeleteRows = false;
            this.DgvIsciInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvIsciInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIsciInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvIsciInfo.Location = new System.Drawing.Point(0, 44);
            this.DgvIsciInfo.Name = "DgvIsciInfo";
            this.DgvIsciInfo.RowHeadersVisible = false;
            this.DgvIsciInfo.Size = new System.Drawing.Size(770, 204);
            this.DgvIsciInfo.TabIndex = 23;
            this.DgvIsciInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvIsciInfo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sıra";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ata adı";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vəzifə";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Təmir briqadası";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mükafat məbləği";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Mükafat səbəbi";
            this.Column8.Name = "Column8";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(725, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 35);
            this.button2.TabIndex = 22;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblIsciMukafat
            // 
            this.LblIsciMukafat.AutoSize = true;
            this.LblIsciMukafat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciMukafat.Location = new System.Drawing.Point(173, 373);
            this.LblIsciMukafat.Name = "LblIsciMukafat";
            this.LblIsciMukafat.Size = new System.Drawing.Size(107, 16);
            this.LblIsciMukafat.TabIndex = 41;
            this.LblIsciMukafat.Text = "Mükafat məbləği";
            // 
            // LblIsciVezife
            // 
            this.LblIsciVezife.AutoSize = true;
            this.LblIsciVezife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciVezife.Location = new System.Drawing.Point(173, 254);
            this.LblIsciVezife.Name = "LblIsciVezife";
            this.LblIsciVezife.Size = new System.Drawing.Size(45, 16);
            this.LblIsciVezife.TabIndex = 40;
            this.LblIsciVezife.Text = "Vəzifə";
            // 
            // LblIsciSoyad
            // 
            this.LblIsciSoyad.AutoSize = true;
            this.LblIsciSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciSoyad.Location = new System.Drawing.Point(9, 315);
            this.LblIsciSoyad.Name = "LblIsciSoyad";
            this.LblIsciSoyad.Size = new System.Drawing.Size(48, 16);
            this.LblIsciSoyad.TabIndex = 39;
            this.LblIsciSoyad.Text = "Soyad";
            // 
            // TxtIsciMukafat
            // 
            this.TxtIsciMukafat.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsciMukafat.Location = new System.Drawing.Point(176, 392);
            this.TxtIsciMukafat.Name = "TxtIsciMukafat";
            this.TxtIsciMukafat.Size = new System.Drawing.Size(143, 27);
            this.TxtIsciMukafat.TabIndex = 6;
            // 
            // TxtIsciVezife
            // 
            this.TxtIsciVezife.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsciVezife.Location = new System.Drawing.Point(176, 273);
            this.TxtIsciVezife.Name = "TxtIsciVezife";
            this.TxtIsciVezife.Size = new System.Drawing.Size(143, 27);
            this.TxtIsciVezife.TabIndex = 4;
            // 
            // TxtIsciSoyad
            // 
            this.TxtIsciSoyad.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIsciSoyad.Location = new System.Drawing.Point(12, 334);
            this.TxtIsciSoyad.Name = "TxtIsciSoyad";
            this.TxtIsciSoyad.Size = new System.Drawing.Size(143, 27);
            this.TxtIsciSoyad.TabIndex = 2;
            this.TxtIsciSoyad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LblIsciDeleteBriqada
            // 
            this.LblIsciDeleteBriqada.AutoSize = true;
            this.LblIsciDeleteBriqada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciDeleteBriqada.Location = new System.Drawing.Point(9, 441);
            this.LblIsciDeleteBriqada.Name = "LblIsciDeleteBriqada";
            this.LblIsciDeleteBriqada.Size = new System.Drawing.Size(103, 16);
            this.LblIsciDeleteBriqada.TabIndex = 42;
            this.LblIsciDeleteBriqada.Text = "Təmir briqadası";
            // 
            // LblIsciDeleteAd
            // 
            this.LblIsciDeleteAd.AutoSize = true;
            this.LblIsciDeleteAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciDeleteAd.Location = new System.Drawing.Point(190, 441);
            this.LblIsciDeleteAd.Name = "LblIsciDeleteAd";
            this.LblIsciDeleteAd.Size = new System.Drawing.Size(25, 16);
            this.LblIsciDeleteAd.TabIndex = 43;
            this.LblIsciDeleteAd.Text = "Ad";
            // 
            // LblIsciDeleteSoyad
            // 
            this.LblIsciDeleteSoyad.AutoSize = true;
            this.LblIsciDeleteSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIsciDeleteSoyad.Location = new System.Drawing.Point(385, 441);
            this.LblIsciDeleteSoyad.Name = "LblIsciDeleteSoyad";
            this.LblIsciDeleteSoyad.Size = new System.Drawing.Size(48, 16);
            this.LblIsciDeleteSoyad.TabIndex = 44;
            this.LblIsciDeleteSoyad.Text = "Soyad";
            // 
            // CmbIsciAd
            // 
            this.CmbIsciAd.FormattingEnabled = true;
            this.CmbIsciAd.Location = new System.Drawing.Point(193, 460);
            this.CmbIsciAd.Name = "CmbIsciAd";
            this.CmbIsciAd.Size = new System.Drawing.Size(121, 21);
            this.CmbIsciAd.TabIndex = 45;
            this.CmbIsciAd.SelectedIndexChanged += new System.EventHandler(this.CmbIsciAd_SelectedIndexChanged);
            // 
            // CmbIsciSoyad
            // 
            this.CmbIsciSoyad.FormattingEnabled = true;
            this.CmbIsciSoyad.Location = new System.Drawing.Point(388, 460);
            this.CmbIsciSoyad.Name = "CmbIsciSoyad";
            this.CmbIsciSoyad.Size = new System.Drawing.Size(121, 21);
            this.CmbIsciSoyad.TabIndex = 47;
            this.CmbIsciSoyad.SelectedIndexChanged += new System.EventHandler(this.CmbIsciSoyad_SelectedIndexChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-5, 424);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(770, 10);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // TxtMukafatSebeb
            // 
            this.TxtMukafatSebeb.Location = new System.Drawing.Point(348, 273);
            this.TxtMukafatSebeb.Name = "TxtMukafatSebeb";
            this.TxtMukafatSebeb.Size = new System.Drawing.Size(176, 115);
            this.TxtMukafatSebeb.TabIndex = 7;
            this.TxtMukafatSebeb.Text = "";
            // 
            // LblMukafatSebebi
            // 
            this.LblMukafatSebebi.AutoSize = true;
            this.LblMukafatSebebi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMukafatSebebi.Location = new System.Drawing.Point(345, 254);
            this.LblMukafatSebebi.Name = "LblMukafatSebebi";
            this.LblMukafatSebebi.Size = new System.Drawing.Size(100, 16);
            this.LblMukafatSebebi.TabIndex = 50;
            this.LblMukafatSebebi.Text = "Mükafat səbəbi";
            // 
            // CmbBriqadaAdd
            // 
            this.CmbBriqadaAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBriqadaAdd.FormattingEnabled = true;
            this.CmbBriqadaAdd.Location = new System.Drawing.Point(176, 334);
            this.CmbBriqadaAdd.Name = "CmbBriqadaAdd";
            this.CmbBriqadaAdd.Size = new System.Drawing.Size(143, 27);
            this.CmbBriqadaAdd.TabIndex = 51;
            this.CmbBriqadaAdd.SelectedIndexChanged += new System.EventHandler(this.TxtIsciBriqada_SelectedIndexChanged);
            // 
            // FrmIsciInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 509);
            this.Controls.Add(this.CmbBriqadaAdd);
            this.Controls.Add(this.LblMukafatSebebi);
            this.Controls.Add(this.TxtMukafatSebeb);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.CmbIsciSoyad);
            this.Controls.Add(this.CmbIsciAd);
            this.Controls.Add(this.LblIsciDeleteSoyad);
            this.Controls.Add(this.LblIsciDeleteAd);
            this.Controls.Add(this.LblIsciDeleteBriqada);
            this.Controls.Add(this.LblIsciMukafat);
            this.Controls.Add(this.LblIsciVezife);
            this.Controls.Add(this.LblIsciSoyad);
            this.Controls.Add(this.TxtIsciMukafat);
            this.Controls.Add(this.TxtIsciVezife);
            this.Controls.Add(this.TxtIsciSoyad);
            this.Controls.Add(this.CmbIsciBriqada);
            this.Controls.Add(this.BtnDeleteIsciInfo);
            this.Controls.Add(this.LblIsciBriqada);
            this.Controls.Add(this.LblIsciAtaAdi);
            this.Controls.Add(this.LblIsciAd);
            this.Controls.Add(this.TxtIsciAtaAdi);
            this.Controls.Add(this.TxtIsciAd);
            this.Controls.Add(this.BtnAddIsciInfo);
            this.Controls.Add(this.BtnShowIsciInfo);
            this.Controls.Add(this.DgvIsciInfo);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIsciInfo";
            this.Text = "FrmIsciInfo";
            this.Load += new System.EventHandler(this.FrmIsciInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIsciInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbIsciBriqada;
        private System.Windows.Forms.Button BtnDeleteIsciInfo;
        private System.Windows.Forms.Label LblIsciBriqada;
        private System.Windows.Forms.Label LblIsciAtaAdi;
        private System.Windows.Forms.Label LblIsciAd;
        private System.Windows.Forms.TextBox TxtIsciAtaAdi;
        private System.Windows.Forms.TextBox TxtIsciAd;
        private System.Windows.Forms.Button BtnAddIsciInfo;
        private System.Windows.Forms.Button BtnShowIsciInfo;
        private System.Windows.Forms.DataGridView DgvIsciInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblIsciMukafat;
        private System.Windows.Forms.Label LblIsciVezife;
        private System.Windows.Forms.Label LblIsciSoyad;
        private System.Windows.Forms.TextBox TxtIsciMukafat;
        private System.Windows.Forms.TextBox TxtIsciVezife;
        private System.Windows.Forms.TextBox TxtIsciSoyad;
        private System.Windows.Forms.Label LblIsciDeleteBriqada;
        private System.Windows.Forms.Label LblIsciDeleteAd;
        private System.Windows.Forms.Label LblIsciDeleteSoyad;
        private System.Windows.Forms.ComboBox CmbIsciAd;
        private System.Windows.Forms.ComboBox CmbIsciSoyad;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.RichTextBox TxtMukafatSebeb;
        private System.Windows.Forms.Label LblMukafatSebebi;
        private System.Windows.Forms.ComboBox CmbBriqadaAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}