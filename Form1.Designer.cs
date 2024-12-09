namespace OOP5_1
{
    partial class Form1
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
        private System.Windows.Forms.Button stopButton;

        private void InitializeComponent()
        {
            stopButton = new Button();
            SuspendLayout();
            // 
            // stopButton
            // 
            stopButton.Location = new Point(190, 130);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(120, 40);
            stopButton.TabIndex = 1;
            stopButton.Text = "Зупинити рух";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(stopButton);
            Name = "Form1";
            ResumeLayout(false);
        }


        #endregion
    }
}
