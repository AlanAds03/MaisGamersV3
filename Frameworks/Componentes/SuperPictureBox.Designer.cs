namespace Frameworks.Componentes
{
    partial class SuperPictureBox
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
            this.superTextBox1 = new Frameworks.Componentes.SuperTextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // superTextBox1
            // 
            this.superTextBox1.CampoObrigatorio = false;
            this.superTextBox1.Location = new System.Drawing.Point(0, 0);
            this.superTextBox1.Name = "superTextBox1";
            this.superTextBox1.Size = new System.Drawing.Size(100, 20);
            this.superTextBox1.TabIndex = 0;
            // 
            // SuperPictureBox
            // 
            this.MouseEnter += new System.EventHandler(this.SuperPictureBox_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SuperPictureBox_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuperTextBox superTextBox1;
    }
}
