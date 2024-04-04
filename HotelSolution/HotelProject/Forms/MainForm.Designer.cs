namespace HotelProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.screenSplitterZone1 = new System.Windows.Forms.SplitContainer();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.clockPictureBox = new System.Windows.Forms.PictureBox();
            this.clockLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.freeRadioBox = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.reservedRadioBox = new System.Windows.Forms.RadioButton();
            this.anyRadioButton = new System.Windows.Forms.RadioButton();
            this.screenSplitterZone2 = new System.Windows.Forms.SplitContainer();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.guestDataGridView = new System.Windows.Forms.DataGridView();
            this.guestListLabel = new System.Windows.Forms.Label();
            this.guestDayOfDepartureLabel = new System.Windows.Forms.Label();
            this.guestDayOfArrivalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guestStatusLabel = new System.Windows.Forms.Label();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.hotelRoomLabel = new System.Windows.Forms.Label();
            this.viewGuestCardButton = new System.Windows.Forms.Button();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.screenSplitterZone1)).BeginInit();
            this.screenSplitterZone1.Panel1.SuspendLayout();
            this.screenSplitterZone1.Panel2.SuspendLayout();
            this.screenSplitterZone1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenSplitterZone2)).BeginInit();
            this.screenSplitterZone2.Panel1.SuspendLayout();
            this.screenSplitterZone2.Panel2.SuspendLayout();
            this.screenSplitterZone2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // screenSplitterZone1
            // 
            this.screenSplitterZone1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenSplitterZone1.ForeColor = System.Drawing.Color.Black;
            this.screenSplitterZone1.Location = new System.Drawing.Point(0, 0);
            this.screenSplitterZone1.Margin = new System.Windows.Forms.Padding(4);
            this.screenSplitterZone1.Name = "screenSplitterZone1";
            // 
            // screenSplitterZone1.Panel1
            // 
            this.screenSplitterZone1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screenSplitterZone1.Panel1.Controls.Add(this.radioButton5);
            this.screenSplitterZone1.Panel1.Controls.Add(this.clockPictureBox);
            this.screenSplitterZone1.Panel1.Controls.Add(this.clockLabel);
            this.screenSplitterZone1.Panel1.Controls.Add(this.statusLabel);
            this.screenSplitterZone1.Panel1.Controls.Add(this.freeRadioBox);
            this.screenSplitterZone1.Panel1.Controls.Add(this.radioButton4);
            this.screenSplitterZone1.Panel1.Controls.Add(this.reservedRadioBox);
            this.screenSplitterZone1.Panel1.Controls.Add(this.anyRadioButton);
            // 
            // screenSplitterZone1.Panel2
            // 
            this.screenSplitterZone1.Panel2.Controls.Add(this.screenSplitterZone2);
            this.screenSplitterZone1.Size = new System.Drawing.Size(1270, 534);
            this.screenSplitterZone1.SplitterDistance = 212;
            this.screenSplitterZone1.SplitterWidth = 3;
            this.screenSplitterZone1.TabIndex = 0;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(33, 304);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(127, 22);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.Text = "Выписываются";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.ChangedDischargedRadioButton);
            // 
            // clockPictureBox
            // 
            this.clockPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clockPictureBox.Image")));
            this.clockPictureBox.Location = new System.Drawing.Point(6, 495);
            this.clockPictureBox.Name = "clockPictureBox";
            this.clockPictureBox.Size = new System.Drawing.Size(38, 29);
            this.clockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clockPictureBox.TabIndex = 7;
            this.clockPictureBox.TabStop = false;
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clockLabel.Font = new System.Drawing.Font("SF Pro Display", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.clockLabel.Location = new System.Drawing.Point(36, 487);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(156, 44);
            this.clockLabel.TabIndex = 5;
            this.clockLabel.Text = "13:42:15";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.statusLabel.Location = new System.Drawing.Point(51, 17);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(93, 29);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Статус";
            // 
            // freeRadioBox
            // 
            this.freeRadioBox.AutoSize = true;
            this.freeRadioBox.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeRadioBox.Location = new System.Drawing.Point(33, 239);
            this.freeRadioBox.Margin = new System.Windows.Forms.Padding(4);
            this.freeRadioBox.Name = "freeRadioBox";
            this.freeRadioBox.Size = new System.Drawing.Size(102, 22);
            this.freeRadioBox.TabIndex = 3;
            this.freeRadioBox.Text = "Свободные";
            this.freeRadioBox.UseVisualStyleBackColor = true;
            this.freeRadioBox.CheckedChanged += new System.EventHandler(this.ChangedFreeRadioButton);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(33, 272);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 22);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "Занятые";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.ChangedOccupiedRadioButton);
            // 
            // reservedRadioBox
            // 
            this.reservedRadioBox.AutoSize = true;
            this.reservedRadioBox.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedRadioBox.Location = new System.Drawing.Point(33, 206);
            this.reservedRadioBox.Margin = new System.Windows.Forms.Padding(4);
            this.reservedRadioBox.Name = "reservedRadioBox";
            this.reservedRadioBox.Size = new System.Drawing.Size(162, 22);
            this.reservedRadioBox.TabIndex = 1;
            this.reservedRadioBox.Text = "Зарезервированные";
            this.reservedRadioBox.UseVisualStyleBackColor = true;
            this.reservedRadioBox.CheckedChanged += new System.EventHandler(this.ChangedReservedRadioButton);
            // 
            // anyRadioButton
            // 
            this.anyRadioButton.AutoSize = true;
            this.anyRadioButton.Checked = true;
            this.anyRadioButton.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anyRadioButton.Location = new System.Drawing.Point(33, 172);
            this.anyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.anyRadioButton.Name = "anyRadioButton";
            this.anyRadioButton.Size = new System.Drawing.Size(71, 22);
            this.anyRadioButton.TabIndex = 0;
            this.anyRadioButton.TabStop = true;
            this.anyRadioButton.Text = "Любой";
            this.anyRadioButton.UseVisualStyleBackColor = true;
            this.anyRadioButton.CheckedChanged += new System.EventHandler(this.ChangedAnyRadioButton);
            // 
            // screenSplitterZone2
            // 
            this.screenSplitterZone2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenSplitterZone2.Location = new System.Drawing.Point(0, 0);
            this.screenSplitterZone2.Margin = new System.Windows.Forms.Padding(4);
            this.screenSplitterZone2.Name = "screenSplitterZone2";
            // 
            // screenSplitterZone2.Panel1
            // 
            this.screenSplitterZone2.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screenSplitterZone2.Panel1.Controls.Add(this.searchTextBox);
            this.screenSplitterZone2.Panel1.Controls.Add(this.searchLabel);
            this.screenSplitterZone2.Panel1.Controls.Add(this.guestDataGridView);
            this.screenSplitterZone2.Panel1.Controls.Add(this.guestListLabel);
            // 
            // screenSplitterZone2.Panel2
            // 
            this.screenSplitterZone2.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screenSplitterZone2.Panel2.Controls.Add(this.guestDayOfDepartureLabel);
            this.screenSplitterZone2.Panel2.Controls.Add(this.guestDayOfArrivalLabel);
            this.screenSplitterZone2.Panel2.Controls.Add(this.pictureBox1);
            this.screenSplitterZone2.Panel2.Controls.Add(this.guestStatusLabel);
            this.screenSplitterZone2.Panel2.Controls.Add(this.guestNameLabel);
            this.screenSplitterZone2.Panel2.Controls.Add(this.hotelRoomLabel);
            this.screenSplitterZone2.Panel2.Controls.Add(this.viewGuestCardButton);
            this.screenSplitterZone2.Size = new System.Drawing.Size(1055, 534);
            this.screenSplitterZone2.SplitterDistance = 683;
            this.screenSplitterZone2.SplitterWidth = 5;
            this.screenSplitterZone2.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(266, 89);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(183, 30);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.TextChanged += new System.EventHandler(this.ChangedSearchTextBox);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(200, 91);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(67, 23);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Поиск:";
            // 
            // guestDataGridView
            // 
            this.guestDataGridView.AllowUserToOrderColumns = true;
            this.guestDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.guestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestDataGridView.Location = new System.Drawing.Point(0, 126);
            this.guestDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.guestDataGridView.Name = "guestDataGridView";
            this.guestDataGridView.Size = new System.Drawing.Size(682, 406);
            this.guestDataGridView.TabIndex = 6;
            this.guestDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShowGuestData);
            // 
            // guestListLabel
            // 
            this.guestListLabel.AutoSize = true;
            this.guestListLabel.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestListLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guestListLabel.Location = new System.Drawing.Point(222, 17);
            this.guestListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestListLabel.Name = "guestListLabel";
            this.guestListLabel.Size = new System.Drawing.Size(181, 29);
            this.guestListLabel.TabIndex = 5;
            this.guestListLabel.Text = "Список гостей";
            // 
            // guestDayOfDepartureLabel
            // 
            this.guestDayOfDepartureLabel.AutoSize = true;
            this.guestDayOfDepartureLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDayOfDepartureLabel.Location = new System.Drawing.Point(16, 435);
            this.guestDayOfDepartureLabel.Name = "guestDayOfDepartureLabel";
            this.guestDayOfDepartureLabel.Size = new System.Drawing.Size(152, 23);
            this.guestDayOfDepartureLabel.TabIndex = 11;
            this.guestDayOfDepartureLabel.Text = "Дата выселения:";
            // 
            // guestDayOfArrivalLabel
            // 
            this.guestDayOfArrivalLabel.AutoSize = true;
            this.guestDayOfArrivalLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDayOfArrivalLabel.Location = new System.Drawing.Point(16, 398);
            this.guestDayOfArrivalLabel.Name = "guestDayOfArrivalLabel";
            this.guestDayOfArrivalLabel.Size = new System.Drawing.Size(150, 23);
            this.guestDayOfArrivalLabel.TabIndex = 10;
            this.guestDayOfArrivalLabel.Text = "Дата заселения:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // guestStatusLabel
            // 
            this.guestStatusLabel.AutoSize = true;
            this.guestStatusLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestStatusLabel.Location = new System.Drawing.Point(16, 325);
            this.guestStatusLabel.Name = "guestStatusLabel";
            this.guestStatusLabel.Size = new System.Drawing.Size(129, 23);
            this.guestStatusLabel.TabIndex = 8;
            this.guestStatusLabel.Text = "Статус гостя: ";
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNameLabel.Location = new System.Drawing.Point(16, 272);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(111, 23);
            this.guestNameLabel.TabIndex = 7;
            this.guestNameLabel.Text = "ФИО гостя: ";
            // 
            // hotelRoomLabel
            // 
            this.hotelRoomLabel.AutoSize = true;
            this.hotelRoomLabel.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelRoomLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.hotelRoomLabel.Location = new System.Drawing.Point(119, 17);
            this.hotelRoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hotelRoomLabel.Name = "hotelRoomLabel";
            this.hotelRoomLabel.Size = new System.Drawing.Size(123, 29);
            this.hotelRoomLabel.TabIndex = 6;
            this.hotelRoomLabel.Text = "Номер №";
            // 
            // viewGuestCardButton
            // 
            this.viewGuestCardButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.viewGuestCardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewGuestCardButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.viewGuestCardButton.FlatAppearance.BorderSize = 0;
            this.viewGuestCardButton.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGuestCardButton.ForeColor = System.Drawing.Color.Transparent;
            this.viewGuestCardButton.Location = new System.Drawing.Point(83, 485);
            this.viewGuestCardButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewGuestCardButton.Name = "viewGuestCardButton";
            this.viewGuestCardButton.Size = new System.Drawing.Size(182, 37);
            this.viewGuestCardButton.TabIndex = 0;
            this.viewGuestCardButton.Text = "Просмотр карточки";
            this.viewGuestCardButton.UseVisualStyleBackColor = false;
            this.viewGuestCardButton.Click += new System.EventHandler(this.ShowAllDataAboutGuest);
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.TickClockTimer);
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataSource = typeof(HotelProject.Guest);
            // 
            // guestBindingSource1
            // 
            this.guestBindingSource1.DataSource = typeof(HotelProject.Guest);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 534);
            this.Controls.Add(this.screenSplitterZone1);
            this.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelManager";
            this.screenSplitterZone1.Panel1.ResumeLayout(false);
            this.screenSplitterZone1.Panel1.PerformLayout();
            this.screenSplitterZone1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenSplitterZone1)).EndInit();
            this.screenSplitterZone1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clockPictureBox)).EndInit();
            this.screenSplitterZone2.Panel1.ResumeLayout(false);
            this.screenSplitterZone2.Panel1.PerformLayout();
            this.screenSplitterZone2.Panel2.ResumeLayout(false);
            this.screenSplitterZone2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenSplitterZone2)).EndInit();
            this.screenSplitterZone2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer screenSplitterZone1;
        private System.Windows.Forms.SplitContainer screenSplitterZone2;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private System.Windows.Forms.BindingSource guestBindingSource1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RadioButton freeRadioBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton reservedRadioBox;
        private System.Windows.Forms.RadioButton anyRadioButton;
        private System.Windows.Forms.DataGridView guestDataGridView;
        private System.Windows.Forms.Label guestListLabel;
        private System.Windows.Forms.Label hotelRoomLabel;
        private System.Windows.Forms.Button viewGuestCardButton;
        public System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.PictureBox clockPictureBox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label guestNameLabel;
        private System.Windows.Forms.Label guestStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label guestDayOfDepartureLabel;
        private System.Windows.Forms.Label guestDayOfArrivalLabel;
    }
}

