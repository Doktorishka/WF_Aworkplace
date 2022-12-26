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
            this.btnListLiterature = new System.Windows.Forms.Button();
            this.btnInputLiterature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListReader
            // 
            this.buttonListReader.Location = new System.Drawing.Point(322, 50);
            this.buttonListReader.Name = "buttonListReader";
            this.buttonListReader.Size = new System.Drawing.Size(123, 42);
            this.buttonListReader.TabIndex = 0;
            this.buttonListReader.Text = "Список читателей";
            this.buttonListReader.UseVisualStyleBackColor = true;
            this.buttonListReader.Click += new System.EventHandler(this.buttonListReader_Click);
            // 
            // btnListLiterature
            // 
            this.btnListLiterature.Location = new System.Drawing.Point(161, 50);
            this.btnListLiterature.Name = "btnListLiterature";
            this.btnListLiterature.Size = new System.Drawing.Size(123, 42);
            this.btnListLiterature.TabIndex = 0;
            this.btnListLiterature.Text = "Список литературы";
            this.btnListLiterature.UseVisualStyleBackColor = true;
            this.btnListLiterature.Click += new System.EventHandler(this.btnListLiterature_Click);
            // 
            // btnInputLiterature
            // 
            this.btnInputLiterature.Location = new System.Drawing.Point(161, 135);
            this.btnInputLiterature.Name = "btnInputLiterature";
            this.btnInputLiterature.Size = new System.Drawing.Size(123, 42);
            this.btnInputLiterature.TabIndex = 0;
            this.btnInputLiterature.Text = "Выдать литературу";
            this.btnInputLiterature.UseVisualStyleBackColor = true;
            this.btnInputLiterature.Click += new System.EventHandler(this.btnInputLiterature_Click);
            // 
            // StartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 404);
            this.Controls.Add(this.btnInputLiterature);
            this.Controls.Add(this.btnListLiterature);
            this.Controls.Add(this.buttonListReader);
            this.Name = "StartedForm";
            this.Text = "StartedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListReader;
        private System.Windows.Forms.Button btnListLiterature;
        private System.Windows.Forms.Button btnInputLiterature;
    }
}