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
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(814, 86);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 28);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "&Удаление читателя";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.cbType);
            this.grpDetails.Controls.Add(this.dateTimeBirth);
            this.grpDetails.Controls.Add(this.txtPlace);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.txtPatronymic);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Controls.Add(this.lblDepartment);
            this.grpDetails.Controls.Add(this.txtIdCard);
            this.grpDetails.Controls.Add(this.label3);
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
            this.grpDetails.Size = new System.Drawing.Size(793, 171);
            this.grpDetails.TabIndex = 38;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Регистрация нового читателя :";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(502, 97);
            this.txtPlace.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(291, 22);
            this.txtPlace.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(409, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 28;
            this.label2.Text = "Место:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(406, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Тип читателя:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Location = new System.Drawing.Point(24, 124);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(123, 28);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Дата рождения:";
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
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(134, 67);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(265, 22);
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
            this.txtFirstName.Size = new System.Drawing.Size(265, 22);
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
            this.btnAdd.Location = new System.Drawing.Point(814, 51);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 28);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "&Добавить читателя";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(814, 122);
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
            this.grdReaders.Location = new System.Drawing.Point(0, 204);
            this.grdReaders.Margin = new System.Windows.Forms.Padding(4);
            this.grdReaders.Name = "grdReaders";
            this.grdReaders.Size = new System.Drawing.Size(1000, 361);
            this.grdReaders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.grdReaders.TabIndex = 39;
            this.grdReaders.UseCompatibleStateImageBehavior = false;
            this.grdReaders.View = System.Windows.Forms.View.Details;
            this.grdReaders.SelectedIndexChanged += new System.EventHandler(this.grdReaders_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(409, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "ИД Билета:";
            // 
            // txtIdCard
            // 
            this.txtIdCard.Location = new System.Drawing.Point(502, 67);
            this.txtIdCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Size = new System.Drawing.Size(291, 22);
            this.txtIdCard.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Отчество:";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Location = new System.Drawing.Point(134, 94);
            this.txtPatronymic.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(265, 22);
            this.txtPatronymic.TabIndex = 27;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(134, 122);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(265, 22);
            this.dateTimeBirth.TabIndex = 40;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(502, 127);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(291, 24);
            this.cbType.TabIndex = 41;
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
        internal System.Windows.Forms.TextBox txtPlace;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtIdCard;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        internal System.Windows.Forms.TextBox txtPatronymic;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
    }
}

