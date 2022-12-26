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
            this.outputLiterature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListReader
            // 
            this.buttonListReader.Location = new System.Drawing.Point(211, 29);
            this.buttonListReader.Name = "buttonListReader";
            this.buttonListReader.Size = new System.Drawing.Size(169, 77);
            this.buttonListReader.TabIndex = 0;
            this.buttonListReader.Text = "Список читателей";
            this.buttonListReader.UseVisualStyleBackColor = true;
            this.buttonListReader.Click += new System.EventHandler(this.buttonListReader_Click);
            // 
            // btnListLiterature
            // 
            this.btnListLiterature.Location = new System.Drawing.Point(41, 29);
            this.btnListLiterature.Name = "btnListLiterature";
            this.btnListLiterature.Size = new System.Drawing.Size(164, 77);
            this.btnListLiterature.TabIndex = 0;
            this.btnListLiterature.Text = "Список литературы";
            this.btnListLiterature.UseVisualStyleBackColor = true;
            this.btnListLiterature.Click += new System.EventHandler(this.btnListLiterature_Click);
            // 
            // btnInputLiterature
            // 
            this.btnInputLiterature.Location = new System.Drawing.Point(41, 112);
            this.btnInputLiterature.Name = "btnInputLiterature";
            this.btnInputLiterature.Size = new System.Drawing.Size(164, 74);
            this.btnInputLiterature.TabIndex = 0;
            this.btnInputLiterature.Text = "Принять литературу";
            this.btnInputLiterature.UseVisualStyleBackColor = true;
            this.btnInputLiterature.Click += new System.EventHandler(this.btnInputLiterature_Click);
            // 
            // outputLiterature
            // 
            this.outputLiterature.Location = new System.Drawing.Point(211, 112);
            this.outputLiterature.Name = "outputLiterature";
            this.outputLiterature.Size = new System.Drawing.Size(169, 74);
            this.outputLiterature.TabIndex = 0;
            this.outputLiterature.Text = "Выдать литературу";
            this.outputLiterature.UseVisualStyleBackColor = true;
            this.outputLiterature.Click += new System.EventHandler(this.outputLiterature_Click);
            // 
            // StartedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 219);
            this.Controls.Add(this.outputLiterature);
            this.Controls.Add(this.btnInputLiterature);
            this.Controls.Add(this.btnListLiterature);
            this.Controls.Add(this.buttonListReader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartedForm";
            this.Text = "StartedForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListReader;
        private System.Windows.Forms.Button btnListLiterature;
        private System.Windows.Forms.Button btnInputLiterature;
        private System.Windows.Forms.Button outputLiterature;
    }
}