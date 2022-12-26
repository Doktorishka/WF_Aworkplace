namespace WF_Aworkplace.Views
{
    partial class InputLiteratureView
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
            this.dataReader = new System.Windows.Forms.DataGridView();
            this.dataOutputLiterature = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutputLiterature)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReader
            // 
            this.dataReader.AllowUserToAddRows = false;
            this.dataReader.AllowUserToDeleteRows = false;
            this.dataReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReader.Location = new System.Drawing.Point(12, 33);
            this.dataReader.Name = "dataReader";
            this.dataReader.ReadOnly = true;
            this.dataReader.RowHeadersWidth = 51;
            this.dataReader.Size = new System.Drawing.Size(469, 207);
            this.dataReader.TabIndex = 0;
            this.dataReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReader_CellClick);
            // 
            // dataOutputLiterature
            // 
            this.dataOutputLiterature.AllowUserToAddRows = false;
            this.dataOutputLiterature.AllowUserToDeleteRows = false;
            this.dataOutputLiterature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutputLiterature.Location = new System.Drawing.Point(487, 33);
            this.dataOutputLiterature.Name = "dataOutputLiterature";
            this.dataOutputLiterature.ReadOnly = true;
            this.dataOutputLiterature.RowHeadersWidth = 51;
            this.dataOutputLiterature.Size = new System.Drawing.Size(485, 207);
            this.dataOutputLiterature.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputLiteratureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataOutputLiterature);
            this.Controls.Add(this.dataReader);
            this.Name = "InputLiteratureView";
            this.Text = "InputLiteratureView";
            ((System.ComponentModel.ISupportInitialize)(this.dataReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutputLiterature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataReader;
        private System.Windows.Forms.DataGridView dataOutputLiterature;
        private System.Windows.Forms.Button button1;
    }
}