
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
            this.hotelPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siteHotel = new System.Windows.Forms.LinkLabel();
            this.aboutHotelLabel = new System.Windows.Forms.Label();
            this.photoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.servicesList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstLineAboutHotel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goToSelectCity = new System.Windows.Forms.ComboBox();
            this.goToSelectCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goToUpDownHotel = new FontAwesome.Sharp.IconButton();
            this.goToSelectHotel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.roomsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.minPrice = new System.Windows.Forms.Label();
            this.goToCheckRooms = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.goToUpDownRoom = new FontAwesome.Sharp.IconButton();
            this.hotelPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotelPanel
            // 
            this.hotelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(244)))));
            this.hotelPanel.Controls.Add(this.infoPanel);
            this.hotelPanel.Controls.Add(this.label3);
            this.hotelPanel.Controls.Add(this.goToSelectCity);
            this.hotelPanel.Controls.Add(this.goToSelectCountry);
            this.hotelPanel.Controls.Add(this.label2);
            this.hotelPanel.Controls.Add(this.goToUpDownHotel);
            this.hotelPanel.Controls.Add(this.goToSelectHotel);
            this.hotelPanel.Controls.Add(this.label1);
            this.hotelPanel.Location = new System.Drawing.Point(12, 12);
            this.hotelPanel.Name = "hotelPanel";
            this.hotelPanel.Size = new System.Drawing.Size(1128, 1024);
            this.hotelPanel.TabIndex = 17;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.panel1);
            this.infoPanel.Controls.Add(this.photoPanel);
            this.infoPanel.Controls.Add(this.servicesList);
            this.infoPanel.Controls.Add(this.label4);
            this.infoPanel.Controls.Add(this.addressLabel);
            this.infoPanel.Controls.Add(this.firstLineAboutHotel);
            this.infoPanel.Location = new System.Drawing.Point(23, 92);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1072, 850);
            this.infoPanel.TabIndex = 30;
            this.infoPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siteHotel);
            this.panel1.Controls.Add(this.aboutHotelLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 129);
            this.panel1.TabIndex = 37;
            // 
            // siteHotel
            // 
            this.siteHotel.AutoSize = true;
            this.siteHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.siteHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteHotel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.siteHotel.Location = new System.Drawing.Point(0, 39);
            this.siteHotel.Name = "siteHotel";
            this.siteHotel.Size = new System.Drawing.Size(42, 24);
            this.siteHotel.TabIndex = 39;
            this.siteHotel.TabStop = true;
            this.siteHotel.Text = "site";
            this.siteHotel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.siteHotel_LinkClicked);
            // 
            // aboutHotelLabel
            // 
            this.aboutHotelLabel.AutoSize = true;
            this.aboutHotelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutHotelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutHotelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.aboutHotelLabel.Location = new System.Drawing.Point(0, 0);
            this.aboutHotelLabel.MaximumSize = new System.Drawing.Size(1072, 100);
            this.aboutHotelLabel.Name = "aboutHotelLabel";
            this.aboutHotelLabel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.aboutHotelLabel.Size = new System.Drawing.Size(0, 39);
            this.aboutHotelLabel.TabIndex = 38;
            // 
            // photoPanel
            // 
            this.photoPanel.AutoScroll = true;
            this.photoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.photoPanel.Location = new System.Drawing.Point(0, 350);
            this.photoPanel.Name = "photoPanel";
            this.photoPanel.Size = new System.Drawing.Size(1072, 500);
            this.photoPanel.TabIndex = 36;
            // 
            // servicesList
            // 
            this.servicesList.AutoSize = true;
            this.servicesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.servicesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.servicesList.Location = new System.Drawing.Point(0, 110);
            this.servicesList.MaximumSize = new System.Drawing.Size(1072, 80);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(0, 24);
            this.servicesList.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label4.Location = new System.Drawing.Point(0, 66);
            this.label4.MaximumSize = new System.Drawing.Size(1072, 80);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label4.Size = new System.Drawing.Size(367, 44);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ваше пребывание включает";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.addressLabel.Location = new System.Drawing.Point(0, 37);
            this.addressLabel.MaximumSize = new System.Drawing.Size(1072, 80);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(367, 29);
            this.addressLabel.TabIndex = 33;
            this.addressLabel.Text = "Ваше пребывание включает";
            // 
            // firstLineAboutHotel
            // 
            this.firstLineAboutHotel.AutoSize = true;
            this.firstLineAboutHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstLineAboutHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstLineAboutHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.firstLineAboutHotel.Location = new System.Drawing.Point(0, 0);
            this.firstLineAboutHotel.MaximumSize = new System.Drawing.Size(1072, 80);
            this.firstLineAboutHotel.Name = "firstLineAboutHotel";
            this.firstLineAboutHotel.Size = new System.Drawing.Size(429, 37);
            this.firstLineAboutHotel.TabIndex = 30;
            this.firstLineAboutHotel.Text = "Ваше пребывание включает";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label3.Location = new System.Drawing.Point(243, 11);
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
            this.goToSelectCity.Location = new System.Drawing.Point(247, 38);
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
            this.goToSelectCountry.Location = new System.Drawing.Point(28, 38);
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
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите страну";
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
            this.goToUpDownHotel.Location = new System.Drawing.Point(0, 964);
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
            this.goToSelectHotel.Location = new System.Drawing.Point(480, 38);
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
            this.label1.Location = new System.Drawing.Point(476, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выберите отель";
            // 
            // roomPanel
            // 
            this.roomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(244)))));
            this.roomPanel.Controls.Add(this.roomsPanel);
            this.roomPanel.Controls.Add(this.minPrice);
            this.roomPanel.Controls.Add(this.goToCheckRooms);
            this.roomPanel.Controls.Add(this.label6);
            this.roomPanel.Controls.Add(this.label5);
            this.roomPanel.Controls.Add(this.datePicker2);
            this.roomPanel.Controls.Add(this.datePicker1);
            this.roomPanel.Controls.Add(this.goToUpDownRoom);
            this.roomPanel.Location = new System.Drawing.Point(12, 1070);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(1128, 836);
            this.roomPanel.TabIndex = 18;
            this.roomPanel.Visible = false;
            // 
            // roomsPanel
            // 
            this.roomsPanel.AutoScroll = true;
            this.roomsPanel.Location = new System.Drawing.Point(23, 159);
            this.roomsPanel.Name = "roomsPanel";
            this.roomsPanel.Size = new System.Drawing.Size(1072, 580);
            this.roomsPanel.TabIndex = 108;
            // 
            // minPrice
            // 
            this.minPrice.AutoSize = true;
            this.minPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.minPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.minPrice.Location = new System.Drawing.Point(846, 70);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(183, 37);
            this.minPrice.TabIndex = 107;
            this.minPrice.Text = "От ??? руб";
            // 
            // goToCheckRooms
            // 
            this.goToCheckRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToCheckRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCheckRooms.FlatAppearance.BorderSize = 0;
            this.goToCheckRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToCheckRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToCheckRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToCheckRooms.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.goToCheckRooms.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToCheckRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToCheckRooms.IconSize = 32;
            this.goToCheckRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCheckRooms.Location = new System.Drawing.Point(579, 56);
            this.goToCheckRooms.Name = "goToCheckRooms";
            this.goToCheckRooms.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToCheckRooms.Size = new System.Drawing.Size(247, 60);
            this.goToCheckRooms.TabIndex = 106;
            this.goToCheckRooms.Text = "Проверить цены";
            this.goToCheckRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToCheckRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToCheckRooms.UseVisualStyleBackColor = false;
            this.goToCheckRooms.Click += new System.EventHandler(this.goToCheckRooms_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label6.Location = new System.Drawing.Point(295, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Дата выезда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label5.Location = new System.Drawing.Point(15, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Дата въезда";
            // 
            // datePicker2
            // 
            this.datePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker2.Location = new System.Drawing.Point(299, 66);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(258, 40);
            this.datePicker2.TabIndex = 18;
            this.datePicker2.ValueChanged += new System.EventHandler(this.datePicker1_ValueChanged);
            // 
            // datePicker1
            // 
            this.datePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePicker1.Location = new System.Drawing.Point(19, 66);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(261, 40);
            this.datePicker1.TabIndex = 17;
            this.datePicker1.ValueChanged += new System.EventHandler(this.datePicker1_ValueChanged);
            // 
            // goToUpDownRoom
            // 
            this.goToUpDownRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.goToUpDownRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToUpDownRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToUpDownRoom.FlatAppearance.BorderSize = 0;
            this.goToUpDownRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToUpDownRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToUpDownRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToUpDownRoom.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
            this.goToUpDownRoom.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToUpDownRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToUpDownRoom.IconSize = 32;
            this.goToUpDownRoom.Location = new System.Drawing.Point(0, 776);
            this.goToUpDownRoom.Name = "goToUpDownRoom";
            this.goToUpDownRoom.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.goToUpDownRoom.Size = new System.Drawing.Size(1128, 60);
            this.goToUpDownRoom.TabIndex = 16;
            this.goToUpDownRoom.UseVisualStyleBackColor = false;
            this.goToUpDownRoom.Visible = false;
            this.goToUpDownRoom.Click += new System.EventHandler(this.goToUpDownRoom_Click);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1180, 1100);
            this.Controls.Add(this.roomPanel);
            this.Controls.Add(this.hotelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.hotelPanel.ResumeLayout(false);
            this.hotelPanel.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hotelPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox goToSelectCity;
        private System.Windows.Forms.ComboBox goToSelectCountry;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton goToUpDownHotel;
        private System.Windows.Forms.ComboBox goToSelectHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label firstLineAboutHotel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label servicesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel photoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutHotelLabel;
        private System.Windows.Forms.LinkLabel siteHotel;
        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private FontAwesome.Sharp.IconButton goToUpDownRoom;
        private FontAwesome.Sharp.IconButton goToCheckRooms;
        private System.Windows.Forms.Label minPrice;
        private System.Windows.Forms.FlowLayoutPanel roomsPanel;
    }
}