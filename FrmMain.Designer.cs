namespace WFA230427
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlItemDetails = new Panel();
            SuspendLayout();
            // 
            // pnlItemDetails
            // 
            pnlItemDetails.BackColor = Color.LemonChiffon;
            pnlItemDetails.Location = new Point(595, 44);
            pnlItemDetails.Name = "pnlItemDetails";
            pnlItemDetails.Size = new Size(350, 500);
            pnlItemDetails.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 601);
            Controls.Add(pnlItemDetails);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlItemDetails;
    }
}