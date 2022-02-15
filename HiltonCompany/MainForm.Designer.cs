
namespace HiltonCompany
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.workPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.goToEmployees = new FontAwesome.Sharp.IconButton();
            this.goToGuests = new FontAwesome.Sharp.IconButton();
            this.goToOrders = new FontAwesome.Sharp.IconButton();
            this.goToHotelRooms = new FontAwesome.Sharp.IconButton();
            this.goToHome = new FontAwesome.Sharp.IconButton();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.headPanel = new System.Windows.Forms.Panel();
            this.helloPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goToLogOut = new FontAwesome.Sharp.IconButton();
            this.goToLogIn = new FontAwesome.Sharp.IconButton();
            this.goToMaximizedApp = new FontAwesome.Sharp.IconButton();
            this.goToExitApp = new FontAwesome.Sharp.IconButton();
            this.logoLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.headPanel.SuspendLayout();
            this.helloPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workPanel.Location = new System.Drawing.Point(230, 60);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(970, 740);
            this.workPanel.TabIndex = 8;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(179)))), ((int)(((byte)(247)))));
            this.menuPanel.Controls.Add(this.goToEmployees);
            this.menuPanel.Controls.Add(this.goToGuests);
            this.menuPanel.Controls.Add(this.goToOrders);
            this.menuPanel.Controls.Add(this.goToHotelRooms);
            this.menuPanel.Controls.Add(this.goToHome);
            this.menuPanel.Controls.Add(this.mainLogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 60);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(230, 740);
            this.menuPanel.TabIndex = 7;
            // 
            // goToEmployees
            // 
            this.goToEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToEmployees.FlatAppearance.BorderSize = 0;
            this.goToEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToEmployees.IconChar = FontAwesome.Sharp.IconChar.AccessibleIcon;
            this.goToEmployees.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToEmployees.IconSize = 32;
            this.goToEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToEmployees.Location = new System.Drawing.Point(0, 353);
            this.goToEmployees.Name = "goToEmployees";
            this.goToEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToEmployees.Size = new System.Drawing.Size(230, 60);
            this.goToEmployees.TabIndex = 10;
            this.goToEmployees.Text = "Сотрудники";
            this.goToEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToEmployees.UseVisualStyleBackColor = true;
            this.goToEmployees.Visible = false;
            this.goToEmployees.Click += new System.EventHandler(this.goToEmployees_Click);
            // 
            // goToGuests
            // 
            this.goToGuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToGuests.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToGuests.FlatAppearance.BorderSize = 0;
            this.goToGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToGuests.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.goToGuests.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToGuests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToGuests.IconSize = 32;
            this.goToGuests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToGuests.Location = new System.Drawing.Point(0, 293);
            this.goToGuests.Name = "goToGuests";
            this.goToGuests.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToGuests.Size = new System.Drawing.Size(230, 60);
            this.goToGuests.TabIndex = 9;
            this.goToGuests.Text = "Клиенты";
            this.goToGuests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToGuests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToGuests.UseVisualStyleBackColor = true;
            this.goToGuests.Visible = false;
            this.goToGuests.Click += new System.EventHandler(this.goToGuests_Click);
            // 
            // goToOrders
            // 
            this.goToOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToOrders.FlatAppearance.BorderSize = 0;
            this.goToOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToOrders.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.goToOrders.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToOrders.IconSize = 32;
            this.goToOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToOrders.Location = new System.Drawing.Point(0, 233);
            this.goToOrders.Name = "goToOrders";
            this.goToOrders.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToOrders.Size = new System.Drawing.Size(230, 60);
            this.goToOrders.TabIndex = 8;
            this.goToOrders.Text = "Заказы";
            this.goToOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToOrders.UseVisualStyleBackColor = true;
            this.goToOrders.Visible = false;
            this.goToOrders.Click += new System.EventHandler(this.goToOrders_Click);
            // 
            // goToHotelRooms
            // 
            this.goToHotelRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToHotelRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToHotelRooms.FlatAppearance.BorderSize = 0;
            this.goToHotelRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToHotelRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToHotelRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToHotelRooms.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.goToHotelRooms.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToHotelRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToHotelRooms.IconSize = 32;
            this.goToHotelRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToHotelRooms.Location = new System.Drawing.Point(0, 173);
            this.goToHotelRooms.Name = "goToHotelRooms";
            this.goToHotelRooms.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToHotelRooms.Size = new System.Drawing.Size(230, 60);
            this.goToHotelRooms.TabIndex = 7;
            this.goToHotelRooms.Text = "Номера";
            this.goToHotelRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToHotelRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToHotelRooms.UseVisualStyleBackColor = true;
            this.goToHotelRooms.Click += new System.EventHandler(this.goToHotelRooms_Click);
            // 
            // goToHome
            // 
            this.goToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToHome.FlatAppearance.BorderSize = 0;
            this.goToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.goToHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToHome.IconSize = 32;
            this.goToHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToHome.Location = new System.Drawing.Point(0, 113);
            this.goToHome.Name = "goToHome";
            this.goToHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToHome.Size = new System.Drawing.Size(230, 60);
            this.goToHome.TabIndex = 6;
            this.goToHome.Text = "Главная";
            this.goToHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToHome.UseVisualStyleBackColor = true;
            this.goToHome.Click += new System.EventHandler(this.goToHome_Click);
            // 
            // mainLogo
            // 
            this.mainLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLogo.Image = ((System.Drawing.Image)(resources.GetObject("mainLogo.Image")));
            this.mainLogo.Location = new System.Drawing.Point(0, 0);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(230, 113);
            this.mainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainLogo.TabIndex = 2;
            this.mainLogo.TabStop = false;
            this.mainLogo.Click += new System.EventHandler(this.mainLogo_Click);
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.headPanel.Controls.Add(this.logoLabel);
            this.headPanel.Controls.Add(this.helloPanel);
            this.headPanel.Controls.Add(this.goToLogOut);
            this.headPanel.Controls.Add(this.goToLogIn);
            this.headPanel.Controls.Add(this.goToMaximizedApp);
            this.headPanel.Controls.Add(this.goToExitApp);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1200, 60);
            this.headPanel.TabIndex = 6;
            this.headPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.headPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // helloPanel
            // 
            this.helloPanel.Controls.Add(this.label3);
            this.helloPanel.Controls.Add(this.label4);
            this.helloPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.helloPanel.Location = new System.Drawing.Point(430, 0);
            this.helloPanel.Name = "helloPanel";
            this.helloPanel.Size = new System.Drawing.Size(250, 60);
            this.helloPanel.TabIndex = 102;
            this.helloPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.MaximumSize = new System.Drawing.Size(200, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Евгений!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Приветствуем Вас,";
            // 
            // goToLogOut
            // 
            this.goToLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToLogOut.FlatAppearance.BorderSize = 0;
            this.goToLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLogOut.ForeColor = System.Drawing.Color.White;
            this.goToLogOut.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.goToLogOut.IconColor = System.Drawing.Color.White;
            this.goToLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLogOut.IconSize = 32;
            this.goToLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogOut.Location = new System.Drawing.Point(680, 0);
            this.goToLogOut.Name = "goToLogOut";
            this.goToLogOut.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToLogOut.Size = new System.Drawing.Size(200, 60);
            this.goToLogOut.TabIndex = 101;
            this.goToLogOut.Text = "Выйти";
            this.goToLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToLogOut.UseVisualStyleBackColor = true;
            this.goToLogOut.Visible = false;
            // 
            // goToLogIn
            // 
            this.goToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToLogIn.FlatAppearance.BorderSize = 0;
            this.goToLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLogIn.ForeColor = System.Drawing.Color.White;
            this.goToLogIn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.goToLogIn.IconColor = System.Drawing.Color.White;
            this.goToLogIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLogIn.IconSize = 32;
            this.goToLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogIn.Location = new System.Drawing.Point(880, 0);
            this.goToLogIn.Name = "goToLogIn";
            this.goToLogIn.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToLogIn.Size = new System.Drawing.Size(200, 60);
            this.goToLogIn.TabIndex = 100;
            this.goToLogIn.Text = "Войти";
            this.goToLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToLogIn.UseVisualStyleBackColor = true;
            this.goToLogIn.Click += new System.EventHandler(this.goToLogIn_Click);
            // 
            // goToMaximizedApp
            // 
            this.goToMaximizedApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToMaximizedApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToMaximizedApp.FlatAppearance.BorderSize = 0;
            this.goToMaximizedApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToMaximizedApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToMaximizedApp.ForeColor = System.Drawing.Color.White;
            this.goToMaximizedApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.goToMaximizedApp.IconColor = System.Drawing.Color.White;
            this.goToMaximizedApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToMaximizedApp.IconSize = 32;
            this.goToMaximizedApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToMaximizedApp.Location = new System.Drawing.Point(1080, 0);
            this.goToMaximizedApp.Name = "goToMaximizedApp";
            this.goToMaximizedApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToMaximizedApp.Size = new System.Drawing.Size(60, 60);
            this.goToMaximizedApp.TabIndex = 26;
            this.goToMaximizedApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToMaximizedApp.UseVisualStyleBackColor = true;
            this.goToMaximizedApp.Click += new System.EventHandler(this.goToMaximizedApp_Click);
            // 
            // goToExitApp
            // 
            this.goToExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToExitApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToExitApp.FlatAppearance.BorderSize = 0;
            this.goToExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToExitApp.ForeColor = System.Drawing.Color.White;
            this.goToExitApp.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.goToExitApp.IconColor = System.Drawing.Color.White;
            this.goToExitApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToExitApp.IconSize = 32;
            this.goToExitApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToExitApp.Location = new System.Drawing.Point(1140, 0);
            this.goToExitApp.Name = "goToExitApp";
            this.goToExitApp.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToExitApp.Size = new System.Drawing.Size(60, 60);
            this.goToExitApp.TabIndex = 24;
            this.goToExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goToExitApp.UseVisualStyleBackColor = true;
            this.goToExitApp.Click += new System.EventHandler(this.goToExitApp_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.logoLabel.Location = new System.Drawing.Point(17, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(258, 40);
            this.logoLabel.TabIndex = 5;
            this.logoLabel.Text = "Hilton Worldwide";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.workPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.helloPanel.ResumeLayout(false);
            this.helloPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel headPanel;
        private FontAwesome.Sharp.IconButton goToMaximizedApp;
        private FontAwesome.Sharp.IconButton goToExitApp;
        private System.Windows.Forms.Panel helloPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton goToLogOut;
        private FontAwesome.Sharp.IconButton goToEmployees;
        private FontAwesome.Sharp.IconButton goToGuests;
        private FontAwesome.Sharp.IconButton goToOrders;
        private FontAwesome.Sharp.IconButton goToHotelRooms;
        private FontAwesome.Sharp.IconButton goToHome;
        private System.Windows.Forms.PictureBox mainLogo;
        private FontAwesome.Sharp.IconButton goToLogIn;
        private System.Windows.Forms.Label logoLabel;
    }
}

