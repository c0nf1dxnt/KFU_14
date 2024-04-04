namespace HotelProject
{
    partial class GuestCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCard));
            this.label1 = new System.Windows.Forms.Label();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.guestBirthdayLabel = new System.Windows.Forms.Label();
            this.guestHasAnimalsLabel = new System.Windows.Forms.Label();
            this.guestPaymentTypeLabel = new System.Windows.Forms.Label();
            this.guestNumberOfDaysAtHotelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Карточка гостя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNameLabel.Location = new System.Drawing.Point(31, 110);
            this.guestNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(107, 23);
            this.guestNameLabel.TabIndex = 6;
            this.guestNameLabel.Text = "ФИО гостя:";
            // 
            // guestBirthdayLabel
            // 
            this.guestBirthdayLabel.AutoSize = true;
            this.guestBirthdayLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestBirthdayLabel.Location = new System.Drawing.Point(31, 162);
            this.guestBirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestBirthdayLabel.Name = "guestBirthdayLabel";
            this.guestBirthdayLabel.Size = new System.Drawing.Size(197, 23);
            this.guestBirthdayLabel.TabIndex = 7;
            this.guestBirthdayLabel.Text = "Дата рождения гостя:";
            // 
            // guestHasAnimalsLabel
            // 
            this.guestHasAnimalsLabel.AutoSize = true;
            this.guestHasAnimalsLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestHasAnimalsLabel.Location = new System.Drawing.Point(31, 197);
            this.guestHasAnimalsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestHasAnimalsLabel.Name = "guestHasAnimalsLabel";
            this.guestHasAnimalsLabel.Size = new System.Drawing.Size(146, 23);
            this.guestHasAnimalsLabel.TabIndex = 8;
            this.guestHasAnimalsLabel.Text = "Есть животные: ";
            // 
            // guestPaymentTypeLabel
            // 
            this.guestPaymentTypeLabel.AutoSize = true;
            this.guestPaymentTypeLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestPaymentTypeLabel.Location = new System.Drawing.Point(31, 232);
            this.guestPaymentTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestPaymentTypeLabel.Name = "guestPaymentTypeLabel";
            this.guestPaymentTypeLabel.Size = new System.Drawing.Size(103, 23);
            this.guestPaymentTypeLabel.TabIndex = 9;
            this.guestPaymentTypeLabel.Text = "Оплачено: ";
            // 
            // guestNumberOfDaysAtHotelLabel
            // 
            this.guestNumberOfDaysAtHotelLabel.AutoSize = true;
            this.guestNumberOfDaysAtHotelLabel.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNumberOfDaysAtHotelLabel.Location = new System.Drawing.Point(31, 267);
            this.guestNumberOfDaysAtHotelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestNumberOfDaysAtHotelLabel.Name = "guestNumberOfDaysAtHotelLabel";
            this.guestNumberOfDaysAtHotelLabel.Size = new System.Drawing.Size(225, 23);
            this.guestNumberOfDaysAtHotelLabel.TabIndex = 10;
            this.guestNumberOfDaysAtHotelLabel.Text = "Количество дней в отеле:";
            // 
            // GuestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 347);
            this.Controls.Add(this.guestNumberOfDaysAtHotelLabel);
            this.Controls.Add(this.guestPaymentTypeLabel);
            this.Controls.Add(this.guestHasAnimalsLabel);
            this.Controls.Add(this.guestBirthdayLabel);
            this.Controls.Add(this.guestNameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestCard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guestNameLabel;
        private System.Windows.Forms.Label guestBirthdayLabel;
        private System.Windows.Forms.Label guestHasAnimalsLabel;
        private System.Windows.Forms.Label guestPaymentTypeLabel;
        private System.Windows.Forms.Label guestNumberOfDaysAtHotelLabel;
    }
}