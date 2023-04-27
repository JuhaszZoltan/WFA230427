namespace WFA230427
{
    partial class UcItemDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDescription = new Label();
            label3 = new Label();
            dtpAddDate = new DateTimePicker();
            label4 = new Label();
            dtpDeadline = new DateTimePicker();
            label5 = new Label();
            nudPeriodHours = new NumericUpDown();
            label6 = new Label();
            nudPeriodMins = new NumericUpDown();
            pbIsDone = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPeriodHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeriodMins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIsDone).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.DodgerBlue;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "###TITLE###";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.White;
            lblDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(3, 67);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(344, 159);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "ezt a sok baromságot csak azért írom ide, hogy lássam, hogy automatikus-e a sortörés, ha kikapcsolom az autosize-t...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 240);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 2;
            label3.Text = "hozzáadva:";
            // 
            // dtpAddDate
            // 
            dtpAddDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpAddDate.Format = DateTimePickerFormat.Custom;
            dtpAddDate.Location = new Point(3, 264);
            dtpAddDate.Name = "dtpAddDate";
            dtpAddDate.Size = new Size(344, 23);
            dtpAddDate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 302);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 2;
            label4.Text = "határidő:";
            // 
            // dtpDeadtime
            // 
            dtpDeadline.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDeadline.CalendarForeColor = Color.Red;
            dtpDeadline.Format = DateTimePickerFormat.Custom;
            dtpDeadline.Location = new Point(3, 326);
            dtpDeadline.Name = "dtpDeadtime";
            dtpDeadline.Size = new Size(344, 23);
            dtpDeadline.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 375);
            label5.Name = "label5";
            label5.Size = new Size(191, 21);
            label5.TabIndex = 2;
            label5.Text = "hozzávetőleges időtartam:";
            // 
            // nudPeriodHours
            // 
            nudPeriodHours.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudPeriodHours.Location = new Point(209, 373);
            nudPeriodHours.Name = "nudPeriodHours";
            nudPeriodHours.Size = new Size(48, 29);
            nudPeriodHours.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(263, 375);
            label6.Name = "label6";
            label6.Size = new Size(14, 21);
            label6.TabIndex = 2;
            label6.Text = ":";
            // 
            // nudPeriodMins
            // 
            nudPeriodMins.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nudPeriodMins.Location = new Point(283, 373);
            nudPeriodMins.Name = "nudPeriodMins";
            nudPeriodMins.Size = new Size(48, 29);
            nudPeriodMins.TabIndex = 4;
            nudPeriodMins.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // pbIsDone
            // 
            pbIsDone.BackColor = Color.LightCoral;
            pbIsDone.Location = new Point(29, 432);
            pbIsDone.Name = "pbIsDone";
            pbIsDone.Size = new Size(50, 50);
            pbIsDone.TabIndex = 5;
            pbIsDone.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(95, 432);
            label7.Name = "label7";
            label7.Size = new Size(207, 50);
            label7.TabIndex = 6;
            label7.Text = "elvégezve?";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UcItemDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(pbIsDone);
            Controls.Add(nudPeriodMins);
            Controls.Add(nudPeriodHours);
            Controls.Add(dtpDeadline);
            Controls.Add(label4);
            Controls.Add(dtpAddDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Name = "UcItemDetails";
            Size = new Size(350, 500);
            ((System.ComponentModel.ISupportInitialize)nudPeriodHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeriodMins).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIsDone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private Label label3;
        private DateTimePicker dtpAddDate;
        private Label label4;
        private DateTimePicker dtpDeadline;
        private Label label5;
        private NumericUpDown nudPeriodHours;
        private Label label6;
        private NumericUpDown nudPeriodMins;
        private PictureBox pbIsDone;
        private Label label7;
    }
}
