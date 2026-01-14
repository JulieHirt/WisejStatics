namespace WisejStatics
{
    partial class Page1
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

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Times Clicked: 0";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page1
            // 
            this.Controls.Add(this.button1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1282, 528);
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button button1;
    }
}
