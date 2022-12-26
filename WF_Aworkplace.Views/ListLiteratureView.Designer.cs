namespace WF_Aworkplace.Views
{
    partial class ListLiteratureView
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
            this.grdLiterature = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdLiterature
            // 
            this.grdLiterature.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLiterature.FullRowSelect = true;
            this.grdLiterature.GridLines = true;
            this.grdLiterature.HideSelection = false;
            this.grdLiterature.Location = new System.Drawing.Point(0, 204);
            this.grdLiterature.Margin = new System.Windows.Forms.Padding(4);
            this.grdLiterature.Name = "grdLiterature";
            this.grdLiterature.Size = new System.Drawing.Size(1000, 361);
            this.grdLiterature.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdLiterature.TabIndex = 44;
            this.grdLiterature.UseCompatibleStateImageBehavior = false;
            this.grdLiterature.View = System.Windows.Forms.View.Details;
            this.grdLiterature.SelectedIndexChanged += new System.EventHandler(this.grdLiterature_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(799, 79);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 28);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.Text = "&Удаление литературы";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(799, 44);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 28);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "&Добавить литературу";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(799, 115);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(167, 28);
            this.btnRegister.TabIndex = 42;
            this.btnRegister.Text = "&Регистрация";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.cbType);
            this.grpDetails.Controls.Add(this.dateTimeOut);
            this.grpDetails.Controls.Add(this.txtNum);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtPublish);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.txtID);
            this.grpDetails.Controls.Add(this.lblID);
            this.grpDetails.Controls.Add(this.txtTitle);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtAuthor);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(0, 13);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetails.Size = new System.Drawing.Size(793, 171);
            this.grpDetails.TabIndex = 45;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Регистрация новой литературы :";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(502, 67);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(291, 24);
            this.cbType.TabIndex = 41;
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.Location = new System.Drawing.Point(134, 122);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(265, 22);
            this.dateTimeOut.TabIndex = 40;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(134, 94);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(265, 22);
            this.txtNum.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Количество:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(406, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Тип:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(24, 124);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(123, 28);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Дата выпуска:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(502, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(291, 22);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(409, 38);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 28);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ИД:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(134, 67);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(265, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(24, 70);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(110, 28);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Наименование:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(134, 37);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(265, 22);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(24, 38);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 28);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "Автор:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(409, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Издатель:";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(502, 97);
            this.txtPublish.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(291, 22);
            this.txtPublish.TabIndex = 5;
            // 
            // ListLiteratureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grdLiterature);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRegister);
            this.Name = "ListLiteratureView";
            this.Text = "ListLiteratureView";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListView grdLiterature;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        internal System.Windows.Forms.TextBox txtNum;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblDepartment;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtAuthor;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.TextBox txtPublish;
        internal System.Windows.Forms.Label label2;
    }
}