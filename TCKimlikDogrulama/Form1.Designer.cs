namespace TCKimlikDogrulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAd = new MetroFramework.Controls.MetroTextBox();
            this.dogumYili = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTCKimlikNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSorgula = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(26, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Ad";
            // 
            // txtAd
            // 
            // 
            // 
            // 
            this.txtAd.CustomButton.Image = null;
            this.txtAd.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtAd.CustomButton.Name = "";
            this.txtAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAd.CustomButton.TabIndex = 1;
            this.txtAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAd.CustomButton.UseSelectable = true;
            this.txtAd.CustomButton.Visible = false;
            this.txtAd.Lines = new string[0];
            this.txtAd.Location = new System.Drawing.Point(132, 78);
            this.txtAd.MaxLength = 32767;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.ShortcutsEnabled = true;
            this.txtAd.Size = new System.Drawing.Size(200, 23);
            this.txtAd.TabIndex = 1;
            this.txtAd.UseSelectable = true;
            this.txtAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dogumYili
            // 
            this.dogumYili.Location = new System.Drawing.Point(132, 165);
            this.dogumYili.MinimumSize = new System.Drawing.Size(0, 29);
            this.dogumYili.Name = "dogumYili";
            this.dogumYili.Size = new System.Drawing.Size(200, 29);
            this.dogumYili.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 107);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            // 
            // 
            // 
            this.txtSoyad.CustomButton.Image = null;
            this.txtSoyad.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtSoyad.CustomButton.Name = "";
            this.txtSoyad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoyad.CustomButton.TabIndex = 1;
            this.txtSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoyad.CustomButton.UseSelectable = true;
            this.txtSoyad.CustomButton.Visible = false;
            this.txtSoyad.Lines = new string[0];
            this.txtSoyad.Location = new System.Drawing.Point(132, 107);
            this.txtSoyad.MaxLength = 32767;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.SelectionLength = 0;
            this.txtSoyad.SelectionStart = 0;
            this.txtSoyad.ShortcutsEnabled = true;
            this.txtSoyad.Size = new System.Drawing.Size(200, 23);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.UseSelectable = true;
            this.txtSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "TC Kimlik No";
            // 
            // txtTCKimlikNo
            // 
            // 
            // 
            // 
            this.txtTCKimlikNo.CustomButton.Image = null;
            this.txtTCKimlikNo.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtTCKimlikNo.CustomButton.Name = "";
            this.txtTCKimlikNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTCKimlikNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTCKimlikNo.CustomButton.TabIndex = 1;
            this.txtTCKimlikNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTCKimlikNo.CustomButton.UseSelectable = true;
            this.txtTCKimlikNo.CustomButton.Visible = false;
            this.txtTCKimlikNo.Lines = new string[0];
            this.txtTCKimlikNo.Location = new System.Drawing.Point(132, 136);
            this.txtTCKimlikNo.MaxLength = 32767;
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.PasswordChar = '\0';
            this.txtTCKimlikNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTCKimlikNo.SelectedText = "";
            this.txtTCKimlikNo.SelectionLength = 0;
            this.txtTCKimlikNo.SelectionStart = 0;
            this.txtTCKimlikNo.ShortcutsEnabled = true;
            this.txtTCKimlikNo.Size = new System.Drawing.Size(200, 23);
            this.txtTCKimlikNo.TabIndex = 1;
            this.txtTCKimlikNo.UseSelectable = true;
            this.txtTCKimlikNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTCKimlikNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Doğum Yılı";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(132, 226);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(200, 23);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseSelectable = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 300);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.dogumYili);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "TC Kimlik Doğrulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAd;
        private MetroFramework.Controls.MetroDateTime dogumYili;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTCKimlikNo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnSorgula;
        private MetroFramework.Controls.MetroTextBox txtSoyad;
    }
}

