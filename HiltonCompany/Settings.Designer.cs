
namespace HiltonCompany
{
    partial class Settings
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
            this.goToSave = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initialCatalog = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.goToStandartSettings = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // goToSave
            // 
            this.goToSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(210)))), ((int)(((byte)(244)))));
            this.goToSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSave.FlatAppearance.BorderSize = 0;
            this.goToSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.goToSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToSave.IconSize = 32;
            this.goToSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSave.Location = new System.Drawing.Point(75, 313);
            this.goToSave.Name = "goToSave";
            this.goToSave.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToSave.Size = new System.Drawing.Size(247, 60);
            this.goToSave.TabIndex = 5;
            this.goToSave.Text = "Спаси и сохрани";
            this.goToSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.goToSave, "Сохранить настройки");
            this.goToSave.UseVisualStyleBackColor = false;
            this.goToSave.Click += new System.EventHandler(this.goToSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Название пользователя";
            // 
            // dataSource
            // 
            this.dataSource.BackColor = System.Drawing.SystemColors.Window;
            this.dataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataSource.Location = new System.Drawing.Point(55, 90);
            this.dataSource.MaxLength = 64;
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(284, 31);
            this.dataSource.TabIndex = 14;
            this.dataSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.dataSource, "Название подключаемого к базе данных");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.label2.Location = new System.Drawing.Point(79, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название базы данных";
            // 
            // initialCatalog
            // 
            this.initialCatalog.BackColor = System.Drawing.SystemColors.Window;
            this.initialCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialCatalog.Location = new System.Drawing.Point(55, 179);
            this.initialCatalog.MaxLength = 64;
            this.initialCatalog.Name = "initialCatalog";
            this.initialCatalog.Size = new System.Drawing.Size(284, 31);
            this.initialCatalog.TabIndex = 16;
            this.initialCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.initialCatalog, "Название базы данных при подключении к базе данных");
            // 
            // goToStandartSettings
            // 
            this.goToStandartSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.goToStandartSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToStandartSettings.FlatAppearance.BorderSize = 0;
            this.goToStandartSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToStandartSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToStandartSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToStandartSettings.IconChar = FontAwesome.Sharp.IconChar.Cross;
            this.goToStandartSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(77)))), ((int)(((byte)(151)))));
            this.goToStandartSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goToStandartSettings.IconSize = 32;
            this.goToStandartSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToStandartSettings.Location = new System.Drawing.Point(109, 395);
            this.goToStandartSettings.Name = "goToStandartSettings";
            this.goToStandartSettings.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.goToStandartSettings.Size = new System.Drawing.Size(177, 60);
            this.goToStandartSettings.TabIndex = 18;
            this.goToStandartSettings.Text = "Сбросить";
            this.goToStandartSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToStandartSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.goToStandartSettings, "Сбросить настройки и сохранить");
            this.goToStandartSettings.UseVisualStyleBackColor = false;
            this.goToStandartSettings.Click += new System.EventHandler(this.goToStandartSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(400, 740);
            this.Controls.Add(this.goToStandartSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialCatalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSource);
            this.Controls.Add(this.goToSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton goToSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initialCatalog;
        private System.Windows.Forms.ToolTip toolTip;
        private FontAwesome.Sharp.IconButton goToStandartSettings;
    }
}