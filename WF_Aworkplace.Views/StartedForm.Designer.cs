namespace WF_Aworkplace.View
{
    partial class StartedForm
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
            this.buttonListReader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListReader
            // 
            this.buttonListReader.Location = new System.Drawing.Point(322, 50);
            this.buttonListReader.Name = "buttonListReader";
            this.buttonListReader.Size = new System.Drawing.Size(75, 23);
            this.buttonListReader.TabIndex = 0;
            this.buttonListReader.Text = "Список читателей";
            this.buttonListReader.UseVisualStyleBackColor = true;
            this.buttonListReader.Click += new System.EventHandler(this.buttonListReader_Click);
            // 
            // StartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 404);
            this.Controls.Add(this.buttonListReader);
            this.Name = "StartedForm";
            this.Text = "StartedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListReader;
    }
}