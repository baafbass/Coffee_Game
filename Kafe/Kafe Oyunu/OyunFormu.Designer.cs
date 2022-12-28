
namespace Kafe_Oyunu
{
    partial class OyunFormu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SureLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TalepUrunLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.SoyadLabel = new System.Windows.Forms.Label();
            this.MasaNoLabel = new System.Windows.Forms.Label();
            this.Kalan = new System.Windows.Forms.Label();
            this.Toplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyunPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.skorTextBox = new System.Windows.Forms.TextBox();
            this.txttoplanansudamla = new System.Windows.Forms.Label();
            this.txttoplananfincan = new System.Windows.Forms.Label();
            this.txttoplanankafe = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guncenlleyenTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.oyunPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SureLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Kalan);
            this.panel1.Controls.Add(this.Toplam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 448);
            this.panel1.TabIndex = 0;
            // 
            // SureLabel
            // 
            this.SureLabel.AutoSize = true;
            this.SureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SureLabel.Location = new System.Drawing.Point(55, 47);
            this.SureLabel.Name = "SureLabel";
            this.SureLabel.Size = new System.Drawing.Size(80, 55);
            this.SureLabel.TabIndex = 6;
            this.SureLabel.Text = "00";
            this.SureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TalepUrunLabel);
            this.panel2.Controls.Add(this.AdLabel);
            this.panel2.Controls.Add(this.SoyadLabel);
            this.panel2.Controls.Add(this.MasaNoLabel);
            this.panel2.Location = new System.Drawing.Point(9, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 201);
            this.panel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Urun :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "SOYAD :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "AD :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Masa No :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TalepUrunLabel
            // 
            this.TalepUrunLabel.AutoSize = true;
            this.TalepUrunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalepUrunLabel.Location = new System.Drawing.Point(96, 154);
            this.TalepUrunLabel.Name = "TalepUrunLabel";
            this.TalepUrunLabel.Size = new System.Drawing.Size(38, 24);
            this.TalepUrunLabel.TabIndex = 7;
            this.TalepUrunLabel.Text = "----";
            this.TalepUrunLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdLabel.Location = new System.Drawing.Point(96, 72);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(38, 24);
            this.AdLabel.TabIndex = 5;
            this.AdLabel.Text = "----";
            this.AdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoyadLabel
            // 
            this.SoyadLabel.AutoSize = true;
            this.SoyadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoyadLabel.Location = new System.Drawing.Point(96, 113);
            this.SoyadLabel.Name = "SoyadLabel";
            this.SoyadLabel.Size = new System.Drawing.Size(38, 24);
            this.SoyadLabel.TabIndex = 6;
            this.SoyadLabel.Text = "----";
            this.SoyadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MasaNoLabel
            // 
            this.MasaNoLabel.AutoSize = true;
            this.MasaNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasaNoLabel.Location = new System.Drawing.Point(96, 31);
            this.MasaNoLabel.Name = "MasaNoLabel";
            this.MasaNoLabel.Size = new System.Drawing.Size(21, 24);
            this.MasaNoLabel.TabIndex = 4;
            this.MasaNoLabel.Text = "0";
            this.MasaNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kalan
            // 
            this.Kalan.AutoSize = true;
            this.Kalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kalan.Location = new System.Drawing.Point(42, 140);
            this.Kalan.Name = "Kalan";
            this.Kalan.Size = new System.Drawing.Size(64, 15);
            this.Kalan.TabIndex = 2;
            this.Kalan.Text = "Kalan : 0";
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toplam.Location = new System.Drawing.Point(42, 115);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(129, 15);
            this.Toplam.TabIndex = 1;
            this.Toplam.Text = "Toplam yapılan  : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalan Süre (sn)";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // oyunPanel
            // 
            this.oyunPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oyunPanel.BackColor = System.Drawing.Color.Aqua;
            this.oyunPanel.Controls.Add(this.panel3);
            this.oyunPanel.Location = new System.Drawing.Point(0, 0);
            this.oyunPanel.Name = "oyunPanel";
            this.oyunPanel.Size = new System.Drawing.Size(603, 448);
            this.oyunPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.skorTextBox);
            this.panel3.Controls.Add(this.txttoplanansudamla);
            this.panel3.Controls.Add(this.txttoplananfincan);
            this.panel3.Controls.Add(this.txttoplanankafe);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 62);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skor";
            // 
            // skorTextBox
            // 
            this.skorTextBox.Enabled = false;
            this.skorTextBox.Location = new System.Drawing.Point(470, 21);
            this.skorTextBox.Name = "skorTextBox";
            this.skorTextBox.Size = new System.Drawing.Size(100, 20);
            this.skorTextBox.TabIndex = 4;
            this.skorTextBox.Text = "0";
            // 
            // txttoplanansudamla
            // 
            this.txttoplanansudamla.AutoSize = true;
            this.txttoplanansudamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoplanansudamla.Location = new System.Drawing.Point(263, 47);
            this.txttoplanansudamla.Name = "txttoplanansudamla";
            this.txttoplanansudamla.Size = new System.Drawing.Size(21, 13);
            this.txttoplanansudamla.TabIndex = 11;
            this.txttoplanansudamla.Text = "00";
            // 
            // txttoplananfincan
            // 
            this.txttoplananfincan.AutoSize = true;
            this.txttoplananfincan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoplananfincan.Location = new System.Drawing.Point(151, 47);
            this.txttoplananfincan.Name = "txttoplananfincan";
            this.txttoplananfincan.Size = new System.Drawing.Size(21, 13);
            this.txttoplananfincan.TabIndex = 10;
            this.txttoplananfincan.Text = "00";
            // 
            // txttoplanankafe
            // 
            this.txttoplanankafe.AutoSize = true;
            this.txttoplanankafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoplanankafe.Location = new System.Drawing.Point(32, 47);
            this.txttoplanankafe.Name = "txttoplanankafe";
            this.txttoplanankafe.Size = new System.Drawing.Size(21, 13);
            this.txttoplanankafe.TabIndex = 9;
            this.txttoplanankafe.Text = "00";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Kafe_Oyunu.Properties.Resources.istockphoto_1029939484_170667a;
            this.pictureBox6.Location = new System.Drawing.Point(254, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Kafe_Oyunu.Properties.Resources.téléchargement;
            this.pictureBox5.Location = new System.Drawing.Point(142, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Kafe_Oyunu.Properties.Resources.tane;
            this.pictureBox4.Location = new System.Drawing.Point(23, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // guncenlleyenTimer
            // 
            this.guncenlleyenTimer.Enabled = true;
            this.guncenlleyenTimer.Interval = 1;
            this.guncenlleyenTimer.Tick += new System.EventHandler(this.guncenlleyenTimer_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 65);
            this.label2.TabIndex = 7;
            this.label2.Text = "Oyunu Baslatmak : E\r\nSola Hareket Ettir  : S\r\nSaga Hareket Ettir : F\r\nOyunu Durdu" +
    "rmak : P\r\nOyunu Devam Ettir : C";
            // 
            // OyunFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.oyunPanel);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "OyunFormu";
            this.ShowIcon = false;
            this.Text = "OyunFormu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OyunFormu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.oyunPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Kalan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SureLabel;
        private System.Windows.Forms.Label Toplam;
        private System.Windows.Forms.Label MasaNoLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label SoyadLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel oyunPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txttoplanansudamla;
        private System.Windows.Forms.Label txttoplananfincan;
        private System.Windows.Forms.Label txttoplanankafe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox skorTextBox;
        private System.Windows.Forms.Timer guncenlleyenTimer;
        private System.Windows.Forms.Label TalepUrunLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}