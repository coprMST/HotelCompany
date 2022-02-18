
namespace HiltonCompany
{
    partial class Rooms
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.goToSelectCity = new System.Windows.Forms.ComboBox();
            this.goToSelectCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hotelPhoto3 = new System.Windows.Forms.PictureBox();
            this.hotelPhoto2 = new System.Windows.Forms.PictureBox();
            this.hotelPhoto1 = new System.Windows.Forms.PictureBox();
            this.goToUpDownHotel = new FontAwesome.Sharp.IconButton();
            this.goToSelectHotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.starsAmount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPhoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPhoto1)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.infoPanel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.goToSelectCity);
            this.panel2.Controls.Add(this.goToSelectCountry);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.goToUpDownHotel);
            this.panel2.Controls.Add(this.goToSelectHotel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 604);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(238, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Выберите город";
            // 
            // goToSelectCity
            // 
            this.goToSelectCity.Enabled = false;
            this.goToSelectCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToSelectCity.FormattingEnabled = true;
            this.goToSelectCity.Location = new System.Drawing.Point(242, 42);
            this.goToSelectCity.Name = "goToSelectCity";
            this.goToSelectCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goToSelectCity.Size = new System.Drawing.Size(199, 32);
            this.goToSelectCity.TabIndex = 25;
            this.goToSelectCity.SelectedValueChanged += new System.EventHandler(this.goToSelectCity_SelectedValueChanged);
            // 
            // goToSelectCountry
            // 
            this.goToSelectCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToSelectCountry.FormattingEnabled = true;
            this.goToSelectCountry.Location = new System.Drawing.Point(23, 42);
            this.goToSelectCountry.Name = "goToSelectCountry";
            this.goToSelectCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goToSelectCountry.Size = new System.Drawing.Size(199, 32);
            this.goToSelectCountry.TabIndex = 23;
            this.goToSelectCountry.SelectedValueChanged += new System.EventHandler(this.goToSelectCountry_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите страну";
            // 
            // hotelPhoto3
            // 
            this.hotelPhoto3.Location = new System.Drawing.Point(749, 212);
            this.hotelPhoto3.Name = "hotelPhoto3";
            this.hotelPhoto3.Size = new System.Drawing.Size(320, 200);
            this.hotelPhoto3.TabIndex = 18;
            this.hotelPhoto3.TabStop = false;
            // 
            // hotelPhoto2
            // 
            this.hotelPhoto2.Location = new System.Drawing.Point(378, 212);
            this.hotelPhoto2.Name = "hotelPhoto2";
            this.hotelPhoto2.Size = new System.Drawing.Size(320, 200);
            this.hotelPhoto2.TabIndex = 17;
            this.hotelPhoto2.TabStop = false;
            // 
            // hotelPhoto1
            // 
            this.hotelPhoto1.Location = new System.Drawing.Point(3, 212);
            this.hotelPhoto1.Name = "hotelPhoto1";
            this.hotelPhoto1.Size = new System.Drawing.Size(320, 200);
            this.hotelPhoto1.TabIndex = 16;
            this.hotelPhoto1.TabStop = false;
            // 
            // goToUpDownHotel
            // 
            this.goToUpDownHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.goToUpDownHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToUpDownHotel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToUpDownHotel.FlatAppearance.BorderSize = 0;
            this.goToUpDownHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToUpDownHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToUpDownHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToUpDownHotel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
            this.goToUpDownHotel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToUpDownHotel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToUpDownHotel.IconSize = 32;
            this.goToUpDownHotel.Location = new System.Drawing.Point(0, 544);
            this.goToUpDownHotel.Name = "goToUpDownHotel";
            this.goToUpDownHotel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.goToUpDownHotel.Size = new System.Drawing.Size(1128, 60);
            this.goToUpDownHotel.TabIndex = 15;
            this.goToUpDownHotel.UseVisualStyleBackColor = false;
            this.goToUpDownHotel.Visible = false;
            this.goToUpDownHotel.Click += new System.EventHandler(this.goToUpDownHotel_Click);
            // 
            // goToSelectHotel
            // 
            this.goToSelectHotel.Enabled = false;
            this.goToSelectHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToSelectHotel.FormattingEnabled = true;
            this.goToSelectHotel.Location = new System.Drawing.Point(475, 42);
            this.goToSelectHotel.Name = "goToSelectHotel";
            this.goToSelectHotel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goToSelectHotel.Size = new System.Drawing.Size(358, 32);
            this.goToSelectHotel.TabIndex = 0;
            this.goToSelectHotel.SelectedValueChanged += new System.EventHandler(this.goToSelectHotel_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(471, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите отель";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(374, 1011);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(-4, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ваше пребывание включает";
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.servicesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.servicesLabel.Location = new System.Drawing.Point(-4, 109);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(250, 20);
            this.servicesLabel.TabIndex = 28;
            this.servicesLabel.Text = "Ваше пребывание включает";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.addressLabel.Location = new System.Drawing.Point(-4, 34);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(287, 24);
            this.addressLabel.TabIndex = 29;
            this.addressLabel.Text = "Ваше пребывание включает";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.starsAmount);
            this.infoPanel.Controls.Add(this.addressLabel);
            this.infoPanel.Controls.Add(this.servicesLabel);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.hotelPhoto2);
            this.infoPanel.Controls.Add(this.hotelPhoto3);
            this.infoPanel.Controls.Add(this.hotelPhoto1);
            this.infoPanel.Location = new System.Drawing.Point(23, 80);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1072, 441);
            this.infoPanel.TabIndex = 30;
            this.infoPanel.Visible = false;
            // 
            // starsAmount
            // 
            this.starsAmount.AutoSize = true;
            this.starsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.starsAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.starsAmount.Location = new System.Drawing.Point(-4, 10);
            this.starsAmount.Name = "starsAmount";
            this.starsAmount.Size = new System.Drawing.Size(287, 24);
            this.starsAmount.TabIndex = 30;
            this.starsAmount.Text = "Ваше пребывание включает";
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1163, 740);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPhoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPhoto1)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox goToSelectCity;
        private System.Windows.Forms.ComboBox goToSelectCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox hotelPhoto3;
        private System.Windows.Forms.PictureBox hotelPhoto2;
        private System.Windows.Forms.PictureBox hotelPhoto1;
        private FontAwesome.Sharp.IconButton goToUpDownHotel;
        private System.Windows.Forms.ComboBox goToSelectHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label starsAmount;
        private System.Windows.Forms.Label addressLabel;
    }
}