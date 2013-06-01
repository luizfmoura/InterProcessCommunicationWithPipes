namespace Client
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
            this.ReceivedDataTextBox = new System.Windows.Forms.TextBox();
            this.SendDataButton = new System.Windows.Forms.Button();
            this.SendDataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReceivedDataTextBox
            // 
            this.ReceivedDataTextBox.Location = new System.Drawing.Point(12, 51);
            this.ReceivedDataTextBox.Multiline = true;
            this.ReceivedDataTextBox.Name = "ReceivedDataTextBox";
            this.ReceivedDataTextBox.Size = new System.Drawing.Size(390, 130);
            this.ReceivedDataTextBox.TabIndex = 6;
            // 
            // SendDataButton
            // 
            this.SendDataButton.Location = new System.Drawing.Point(162, 11);
            this.SendDataButton.Name = "SendDataButton";
            this.SendDataButton.Size = new System.Drawing.Size(115, 23);
            this.SendDataButton.TabIndex = 5;
            this.SendDataButton.Text = "Send to server";
            this.SendDataButton.UseVisualStyleBackColor = true;
            this.SendDataButton.Click += new System.EventHandler(this.SendDataButton_Click);
            // 
            // SendDataTextBox
            // 
            this.SendDataTextBox.Location = new System.Drawing.Point(12, 13);
            this.SendDataTextBox.Name = "SendDataTextBox";
            this.SendDataTextBox.Size = new System.Drawing.Size(144, 20);
            this.SendDataTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 192);
            this.Controls.Add(this.ReceivedDataTextBox);
            this.Controls.Add(this.SendDataButton);
            this.Controls.Add(this.SendDataTextBox);
            this.Name = "MainForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceivedDataTextBox;
        private System.Windows.Forms.Button SendDataButton;
        private System.Windows.Forms.TextBox SendDataTextBox;
    }
}

