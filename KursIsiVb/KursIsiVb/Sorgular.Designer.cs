namespace KursIsiVb
{
    partial class Sorgular
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
            this.DgvSorguBriqada = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbBriqada = new System.Windows.Forms.ComboBox();
            this.LblVaqonNo = new System.Windows.Forms.Label();
            this.CmbSorguVaqonNo = new System.Windows.Forms.ComboBox();
            this.LblBriqada = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvVaqonNo = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbMarkas = new System.Windows.Forms.ComboBox();
            this.LblMarka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSorguBriqada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVaqonNo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSorguBriqada
            // 
            this.DgvSorguBriqada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSorguBriqada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSorguBriqada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvSorguBriqada.Location = new System.Drawing.Point(0, 253);
            this.DgvSorguBriqada.Name = "DgvSorguBriqada";
            this.DgvSorguBriqada.Size = new System.Drawing.Size(770, 222);
            this.DgvSorguBriqada.TabIndex = 0;
            this.DgvSorguBriqada.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vəzifə";
            this.Column3.Name = "Column3";
            // 
            // CmbBriqada
            // 
            this.CmbBriqada.FormattingEnabled = true;
            this.CmbBriqada.Location = new System.Drawing.Point(23, 31);
            this.CmbBriqada.Name = "CmbBriqada";
            this.CmbBriqada.Size = new System.Drawing.Size(121, 21);
            this.CmbBriqada.TabIndex = 1;
            this.CmbBriqada.SelectedIndexChanged += new System.EventHandler(this.CmbBriqada_SelectedIndexChanged);
            // 
            // LblVaqonNo
            // 
            this.LblVaqonNo.AutoSize = true;
            this.LblVaqonNo.Location = new System.Drawing.Point(192, 9);
            this.LblVaqonNo.Name = "LblVaqonNo";
            this.LblVaqonNo.Size = new System.Drawing.Size(55, 13);
            this.LblVaqonNo.TabIndex = 2;
            this.LblVaqonNo.Text = "Vaqon No";
            this.LblVaqonNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbSorguVaqonNo
            // 
            this.CmbSorguVaqonNo.FormattingEnabled = true;
            this.CmbSorguVaqonNo.Location = new System.Drawing.Point(195, 31);
            this.CmbSorguVaqonNo.Name = "CmbSorguVaqonNo";
            this.CmbSorguVaqonNo.Size = new System.Drawing.Size(121, 21);
            this.CmbSorguVaqonNo.TabIndex = 3;
            this.CmbSorguVaqonNo.SelectedIndexChanged += new System.EventHandler(this.CmbSorguVaqonNo_SelectedIndexChanged);
            // 
            // LblBriqada
            // 
            this.LblBriqada.AutoSize = true;
            this.LblBriqada.Location = new System.Drawing.Point(20, 9);
            this.LblBriqada.Name = "LblBriqada";
            this.LblBriqada.Size = new System.Drawing.Size(43, 13);
            this.LblBriqada.TabIndex = 4;
            this.LblBriqada.Text = "Briqada";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(629, 31);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 5;
            this.BtnSearch.Text = "Axtar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvVaqonNo
            // 
            this.DgvVaqonNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVaqonNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVaqonNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvVaqonNo.Location = new System.Drawing.Point(0, 253);
            this.DgvVaqonNo.Name = "DgvVaqonNo";
            this.DgvVaqonNo.Size = new System.Drawing.Size(770, 222);
            this.DgvVaqonNo.TabIndex = 6;
            this.DgvVaqonNo.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Vaqon No";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Marka";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tip";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Buraxılma tarixi";
            this.Column6.Name = "Column6";
            // 
            // CmbMarkas
            // 
            this.CmbMarkas.FormattingEnabled = true;
            this.CmbMarkas.Location = new System.Drawing.Point(378, 31);
            this.CmbMarkas.Name = "CmbMarkas";
            this.CmbMarkas.Size = new System.Drawing.Size(121, 21);
            this.CmbMarkas.TabIndex = 7;
            // 
            // LblMarka
            // 
            this.LblMarka.AutoSize = true;
            this.LblMarka.Location = new System.Drawing.Point(375, 9);
            this.LblMarka.Name = "LblMarka";
            this.LblMarka.Size = new System.Drawing.Size(70, 13);
            this.LblMarka.TabIndex = 8;
            this.LblMarka.Text = "Vaqon marka";
            // 
            // Sorgular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 509);
            this.Controls.Add(this.LblMarka);
            this.Controls.Add(this.CmbMarkas);
            this.Controls.Add(this.DgvVaqonNo);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblBriqada);
            this.Controls.Add(this.CmbSorguVaqonNo);
            this.Controls.Add(this.LblVaqonNo);
            this.Controls.Add(this.CmbBriqada);
            this.Controls.Add(this.DgvSorguBriqada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sorgular";
            this.Text = "Sorgular";
            this.Load += new System.EventHandler(this.Sorgular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSorguBriqada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVaqonNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSorguBriqada;
        private System.Windows.Forms.ComboBox CmbBriqada;
        private System.Windows.Forms.Label LblVaqonNo;
        private System.Windows.Forms.ComboBox CmbSorguVaqonNo;
        private System.Windows.Forms.Label LblBriqada;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvVaqonNo;
        private System.Windows.Forms.ComboBox CmbMarkas;
        private System.Windows.Forms.Label LblMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}