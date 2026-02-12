namespace Teknoroma.WinFormUI
{
    partial class CategoryForm
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
            txtKategoriIsmi = new TextBox();
            lblKategoriIsmi = new Label();
            btnListele = new Button();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnKategoriSil = new Button();
            lstKategoriler = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtKategoriIsmi
            // 
            txtKategoriIsmi.Location = new Point(117, 29);
            txtKategoriIsmi.Name = "txtKategoriIsmi";
            txtKategoriIsmi.Size = new Size(100, 23);
            txtKategoriIsmi.TabIndex = 0;
            // 
            // lblKategoriIsmi
            // 
            lblKategoriIsmi.AutoSize = true;
            lblKategoriIsmi.Location = new Point(32, 32);
            lblKategoriIsmi.Name = "lblKategoriIsmi";
            lblKategoriIsmi.Size = new Size(79, 15);
            lblKategoriIsmi.TabIndex = 1;
            lblKategoriIsmi.Text = "Kategori İsmi:";
            // 
            // btnListele
            // 
            btnListele.Location = new Point(32, 85);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(124, 30);
            btnListele.TabIndex = 2;
            btnListele.Text = "Kategorileri Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(32, 134);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(124, 30);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Kategori Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(32, 185);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(124, 30);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Kategori Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.Location = new Point(32, 235);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(124, 30);
            btnKategoriSil.TabIndex = 5;
            btnKategoriSil.Text = "Kategori Sil";
            btnKategoriSil.UseVisualStyleBackColor = true;
            btnKategoriSil.Click += btnKategoriSil_Click;
            // 
            // lstKategoriler
            // 
            lstKategoriler.FormattingEnabled = true;
            lstKategoriler.ItemHeight = 15;
            lstKategoriler.Location = new Point(247, 70);
            lstKategoriler.Name = "lstKategoriler";
            lstKategoriler.Size = new Size(516, 259);
            lstKategoriler.TabIndex = 6;
            lstKategoriler.Click += lstKategoriler_Click;
            // 
            // button1
            // 
            button1.Location = new Point(915, 70);
            button1.Name = "button1";
            button1.Size = new Size(124, 30);
            button1.TabIndex = 7;
            button1.Text = "Ürünler";
            button1.UseVisualStyleBackColor = true;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 450);
            Controls.Add(button1);
            Controls.Add(lstKategoriler);
            Controls.Add(btnKategoriSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(lblKategoriIsmi);
            Controls.Add(txtKategoriIsmi);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKategoriIsmi;
        private Label lblKategoriIsmi;
        private Button btnListele;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnKategoriSil;
        private ListBox lstKategoriler;
        private Button button1;
    }
}