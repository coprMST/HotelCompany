
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.workPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.goToSettings = new FontAwesome.Sharp.IconButton();
            this.timerLabel = new System.Windows.Forms.Label();
            this.goToEmployees = new FontAwesome.Sharp.IconButton();
            this.goToGuests = new FontAwesome.Sharp.IconButton();
            this.goToOrders = new FontAwesome.Sharp.IconButton();
            this.goToHotelRooms = new FontAwesome.Sharp.IconButton();
            this.goToHome = new FontAwesome.Sharp.IconButton();
            this.mainLogo = new System.Windows.Forms.PictureBox();
            this.headPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.myName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goToLogOut = new FontAwesome.Sharp.IconButton();
            this.goToLogIn = new FontAwesome.Sharp.IconButton();
            this.goToMaximizedApp = new FontAwesome.Sharp.IconButton();
            this.goToExitApp = new FontAwesome.Sharp.IconButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).BeginInit();
            this.headPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workPanel
            // 
            this.workPanel.AutoScroll = true;
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
            this.menuPanel.Controls.Add(this.goToSettings);
            this.menuPanel.Controls.Add(this.timerLabel);
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
            // goToSettings
            // 
            this.goToSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToSettings.FlatAppearance.BorderSize = 0;
            this.goToSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.goToSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSettings.IconSize = 32;
            this.goToSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSettings.Location = new System.Drawing.Point(0, 680);
            this.goToSettings.Name = "goToSettings";
            this.goToSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToSettings.Size = new System.Drawing.Size(230, 60);
            this.goToSettings.TabIndex = 104;
            this.goToSettings.Text = "Настройки";
            this.goToSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.goToSettings, "Настройки приложения");
            this.goToSettings.UseVisualStyleBackColor = true;
            this.goToSettings.Click += new System.EventHandler(this.goToSettings_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.timerLabel.Location = new System.Drawing.Point(12, 597);
            this.timerLabel.MaximumSize = new System.Drawing.Size(169, 80);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(169, 80);
            this.timerLabel.TabIndex = 103;
            this.timerLabel.Text = "15 января, 23:45:20";
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
            this.toolTip.SetToolTip(this.goToEmployees, "Перейти на страницу данных сотрудников");
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
            this.toolTip.SetToolTip(this.goToGuests, "Перейти на страницу данных клиентов");
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
            this.toolTip.SetToolTip(this.goToOrders, "Перейти на страницу заказов клиентов");
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
            this.toolTip.SetToolTip(this.goToHotelRooms, "Перейти на страницу номеров");
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
            this.toolTip.SetToolTip(this.goToHome, "Перейти на главную страницу");
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
            this.headPanel.Controls.Add(this.loginPanel);
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
            this.logoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.logoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.myName);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.goToLogOut);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginPanel.Location = new System.Drawing.Point(441, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(439, 60);
            this.loginPanel.TabIndex = 102;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.loginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // myName
            // 
            this.myName.AutoSize = true;
            this.myName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.myName.Location = new System.Drawing.Point(2, 30);
            this.myName.MaximumSize = new System.Drawing.Size(200, 24);
            this.myName.Name = "myName";
            this.myName.Size = new System.Drawing.Size(114, 24);
            this.myName.TabIndex = 4;
            this.myName.Text = "UserName!";
            this.myName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.myName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Приветствуем Вас,";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headPanel_MouseMove);
            // 
            // goToLogOut
            // 
            this.goToLogOut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goToLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogOut.FlatAppearance.BorderSize = 0;
            this.goToLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.goToLogOut.IconColor = System.Drawing.Color.White;
            this.goToLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToLogOut.IconSize = 32;
            this.goToLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogOut.Location = new System.Drawing.Point(240, 0);
            this.goToLogOut.Name = "goToLogOut";
            this.goToLogOut.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.goToLogOut.Size = new System.Drawing.Size(200, 60);
            this.goToLogOut.TabIndex = 101;
            this.goToLogOut.Text = "ВЫЙТИ";
            this.goToLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.goToLogOut, "Выйти из системы");
            this.goToLogOut.UseVisualStyleBackColor = true;
            this.goToLogOut.Click += new System.EventHandler(this.goToLogOut_Click);
            // 
            // goToLogIn
            // 
            this.goToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.goToLogIn.FlatAppearance.BorderSize = 0;
            this.goToLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToLogIn.ForeColor = System.Drawing.Color.White;
            this.goToLogIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
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
            this.toolTip.SetToolTip(this.goToLogIn, "Авторизироваться в систему");
            this.goToLogIn.UseVisualStyleBackColor = true;
            this.goToLogIn.Visible = false;
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
            this.toolTip.SetToolTip(this.goToMaximizedApp, "Свернуть приложение");
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
            this.toolTip.SetToolTip(this.goToExitApp, "Завершить работу приложения");
            this.goToExitApp.UseVisualStyleBackColor = true;
            this.goToExitApp.Click += new System.EventHandler(this.goToExitApp_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLogo)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel headPanel;
        private FontAwesome.Sharp.IconButton goToMaximizedApp;
        private FontAwesome.Sharp.IconButton goToExitApp;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label myName;
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton goToSettings;
    }
}

