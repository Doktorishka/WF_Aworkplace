namespace WF_Aworkplace.View
{
    partial class ListReaderView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grdReaders = new System.Windows.Forms.ListView();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(814, 64);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 28);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "&Удаление читателя";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.textBox2);
            this.grpDetails.Controls.Add(this.textBox1);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.txtDepartment);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtID);
            this.grpDetails.Controls.Add(this.lblID);
            this.grpDetails.Controls.Add(this.txtLastName);
            this.grpDetails.Controls.Add(this.lblLastName);
            this.grpDetails.Controls.Add(this.txtFirstName);
            this.grpDetails.Controls.Add(this.lblFirstName);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDetails.Location = new System.Drawing.Point(13, 13);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpDetails.Size = new System.Drawing.Size(793, 138);
            this.grpDetails.TabIndex = 38;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Регистрация нового читателя :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(532, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 22);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(532, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(433, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Место:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(134, 98);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(291, 22);
            this.txtDepartment.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(433, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Тип читателя:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(24, 98);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(123, 28);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Дата рождения:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(532, 37);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(253, 22);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(432, 39);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 28);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ИД:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(134, 67);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(291, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(24, 70);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 28);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Фамилия:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(134, 37);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(291, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(24, 38);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 28);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "Имя:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(814, 29);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "&Добавить читателя";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(814, 100);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(167, 28);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "&Регистрация читателя";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grdReaders
            // 
            this.grdReaders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdReaders.FullRowSelect = true;
            this.grdReaders.GridLines = true;
            this.grdReaders.HideSelection = false;
            this.grdReaders.Location = new System.Drawing.Point(0, 159);
            this.grdReaders.Margin = new System.Windows.Forms.Padding(4);
            this.grdReaders.Name = "grdReaders";
            this.grdReaders.Size = new System.Drawing.Size(1000, 406);
            this.grdReaders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdReaders.TabIndex = 39;
            this.grdReaders.UseCompatibleStateImageBehavior = false;
            this.grdReaders.View = System.Windows.Forms.View.Details;
            this.grdReaders.SelectedIndexChanged += new System.EventHandler(this.grdReaders_SelectedIndexChanged);
            // 
            // ListReaderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.grdReaders);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRegister);
            this.Name = "ListReaderView";
            this.Text = "Список читателей";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.GroupBox grpDetails;
        internal System.Windows.Forms.TextBox txtDepartment;
        internal System.Windows.Forms.Label lblDepartment;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnRegister;
        internal System.Windows.Forms.ListView grdReaders;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}

