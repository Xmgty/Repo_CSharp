namespace Store
{
    partial class MainForm
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
            this.lstPhone = new System.Windows.Forms.ListBox();
            this.grpListPhone = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tbPricePhone = new System.Windows.Forms.TextBox();
            this.tbCPUPhone = new System.Windows.Forms.TextBox();
            this.tbOSPhone = new System.Windows.Forms.TextBox();
            this.tbModelPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.lstOption = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.btnAddNewPhone = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbNameOption = new System.Windows.Forms.TextBox();
            this.btnSaveChanched = new System.Windows.Forms.Button();
            this.lstOptionsNewPhone = new System.Windows.Forms.CheckedListBox();
            this.btnOptionDelete = new System.Windows.Forms.Button();
            this.btnOptionAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpListPhone.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.grpOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabEdit.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPhone
            // 
            this.lstPhone.FormattingEnabled = true;
            this.lstPhone.ItemHeight = 16;
            this.lstPhone.Location = new System.Drawing.Point(6, 21);
            this.lstPhone.Name = "lstPhone";
            this.lstPhone.Size = new System.Drawing.Size(401, 308);
            this.lstPhone.TabIndex = 0;
            this.lstPhone.SelectedIndexChanged += new System.EventHandler(this.lstPhone_SelectedIndexChanged);
            // 
            // grpListPhone
            // 
            this.grpListPhone.Controls.Add(this.btnSave);
            this.grpListPhone.Controls.Add(this.btnRead);
            this.grpListPhone.Controls.Add(this.btnClear);
            this.grpListPhone.Controls.Add(this.btnDelete);
            this.grpListPhone.Controls.Add(this.lstPhone);
            this.grpListPhone.Location = new System.Drawing.Point(12, 12);
            this.grpListPhone.Name = "grpListPhone";
            this.grpListPhone.Size = new System.Drawing.Size(413, 457);
            this.grpListPhone.TabIndex = 1;
            this.grpListPhone.TabStop = false;
            this.grpListPhone.Text = "Список телефонов магазина";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить в файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(218, 404);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(189, 43);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Прочитать из файла";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить список";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 43);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить текущую";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Controls.Add(this.tabEdit);
            this.tabControl1.Location = new System.Drawing.Point(431, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 469);
            this.tabControl1.TabIndex = 2;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tbPricePhone);
            this.tabInfo.Controls.Add(this.tbCPUPhone);
            this.tabInfo.Controls.Add(this.tbOSPhone);
            this.tabInfo.Controls.Add(this.tbModelPhone);
            this.tabInfo.Controls.Add(this.label4);
            this.tabInfo.Controls.Add(this.label3);
            this.tabInfo.Controls.Add(this.label2);
            this.tabInfo.Controls.Add(this.label1);
            this.tabInfo.Controls.Add(this.grpOption);
            this.tabInfo.Controls.Add(this.pictureBox1);
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(391, 440);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Информация о телефоне";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tbPricePhone
            // 
            this.tbPricePhone.Location = new System.Drawing.Point(224, 247);
            this.tbPricePhone.Name = "tbPricePhone";
            this.tbPricePhone.Size = new System.Drawing.Size(158, 22);
            this.tbPricePhone.TabIndex = 3;
            // 
            // tbCPUPhone
            // 
            this.tbCPUPhone.Location = new System.Drawing.Point(224, 213);
            this.tbCPUPhone.Name = "tbCPUPhone";
            this.tbCPUPhone.Size = new System.Drawing.Size(158, 22);
            this.tbCPUPhone.TabIndex = 3;
            // 
            // tbOSPhone
            // 
            this.tbOSPhone.Location = new System.Drawing.Point(224, 178);
            this.tbOSPhone.Name = "tbOSPhone";
            this.tbOSPhone.Size = new System.Drawing.Size(158, 22);
            this.tbOSPhone.TabIndex = 3;
            // 
            // tbModelPhone
            // 
            this.tbModelPhone.Location = new System.Drawing.Point(224, 145);
            this.tbModelPhone.Name = "tbModelPhone";
            this.tbModelPhone.Size = new System.Drawing.Size(158, 22);
            this.tbModelPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Процессор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ОС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Модель";
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.lstOption);
            this.grpOption.Location = new System.Drawing.Point(6, 272);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(379, 150);
            this.grpOption.TabIndex = 1;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "ОПЦИИ";
            // 
            // lstOption
            // 
            this.lstOption.FormattingEnabled = true;
            this.lstOption.ItemHeight = 16;
            this.lstOption.Location = new System.Drawing.Point(9, 38);
            this.lstOption.Name = "lstOption";
            this.lstOption.Size = new System.Drawing.Size(367, 100);
            this.lstOption.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.btnAddNewPhone);
            this.tabEdit.Controls.Add(this.btnClearFields);
            this.tabEdit.Controls.Add(this.groupBox4);
            this.tabEdit.Controls.Add(this.groupBox3);
            this.tabEdit.Location = new System.Drawing.Point(4, 25);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(391, 440);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Редактирование информации";
            this.tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPhone
            // 
            this.btnAddNewPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewPhone.ForeColor = System.Drawing.Color.Red;
            this.btnAddNewPhone.Location = new System.Drawing.Point(200, 391);
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.Size = new System.Drawing.Size(179, 43);
            this.btnAddNewPhone.TabIndex = 1;
            this.btnAddNewPhone.Text = "Добавить новый телефон";
            this.btnAddNewPhone.UseVisualStyleBackColor = true;
            this.btnAddNewPhone.Click += new System.EventHandler(this.btnAddNewPhone_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearFields.ForeColor = System.Drawing.Color.Red;
            this.btnClearFields.Location = new System.Drawing.Point(17, 391);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(174, 43);
            this.btnClearFields.TabIndex = 1;
            this.btnClearFields.Text = "Очистить поля";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbNameOption);
            this.groupBox4.Controls.Add(this.btnSaveChanched);
            this.groupBox4.Controls.Add(this.lstOptionsNewPhone);
            this.groupBox4.Controls.Add(this.btnOptionDelete);
            this.groupBox4.Controls.Add(this.btnOptionAdd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(7, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 232);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // tbNameOption
            // 
            this.tbNameOption.Location = new System.Drawing.Point(190, 172);
            this.tbNameOption.Name = "tbNameOption";
            this.tbNameOption.Size = new System.Drawing.Size(182, 22);
            this.tbNameOption.TabIndex = 1;
            // 
            // btnSaveChanched
            // 
            this.btnSaveChanched.Location = new System.Drawing.Point(7, 137);
            this.btnSaveChanched.Name = "btnSaveChanched";
            this.btnSaveChanched.Size = new System.Drawing.Size(365, 29);
            this.btnSaveChanched.TabIndex = 1;
            this.btnSaveChanched.Text = "Сохранить изменения";
            this.btnSaveChanched.UseVisualStyleBackColor = true;
            this.btnSaveChanched.Click += new System.EventHandler(this.btnSaveChanched_Click);
            // 
            // lstOptionsNewPhone
            // 
            this.lstOptionsNewPhone.FormattingEnabled = true;
            this.lstOptionsNewPhone.Location = new System.Drawing.Point(10, 8);
            this.lstOptionsNewPhone.Name = "lstOptionsNewPhone";
            this.lstOptionsNewPhone.Size = new System.Drawing.Size(362, 123);
            this.lstOptionsNewPhone.TabIndex = 0;
            // 
            // btnOptionDelete
            // 
            this.btnOptionDelete.Location = new System.Drawing.Point(190, 200);
            this.btnOptionDelete.Name = "btnOptionDelete";
            this.btnOptionDelete.Size = new System.Drawing.Size(182, 26);
            this.btnOptionDelete.TabIndex = 1;
            this.btnOptionDelete.Text = "Удалить опцию";
            this.btnOptionDelete.UseVisualStyleBackColor = true;
            this.btnOptionDelete.Click += new System.EventHandler(this.btnOptionDelete_Click);
            // 
            // btnOptionAdd
            // 
            this.btnOptionAdd.Location = new System.Drawing.Point(10, 200);
            this.btnOptionAdd.Name = "btnOptionAdd";
            this.btnOptionAdd.Size = new System.Drawing.Size(174, 26);
            this.btnOptionAdd.TabIndex = 1;
            this.btnOptionAdd.Text = "Добавить опцию";
            this.btnOptionAdd.UseVisualStyleBackColor = true;
            this.btnOptionAdd.Click += new System.EventHandler(this.btnOptionAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(6, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Название опции";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPrice);
            this.groupBox3.Controls.Add(this.tbImage);
            this.groupBox3.Controls.Add(this.tbCPU);
            this.groupBox3.Controls.Add(this.tbOS);
            this.groupBox3.Controls.Add(this.tbModel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 151);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(118, 123);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(254, 22);
            this.tbPrice.TabIndex = 1;
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(118, 95);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(254, 22);
            this.tbImage.TabIndex = 1;
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(118, 67);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(254, 22);
            this.tbCPU.TabIndex = 1;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(118, 39);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(254, 22);
            this.tbOS.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(118, 11);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(254, 22);
            this.tbModel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Картинка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Процессор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ОС";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Модель";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 481);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpListPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile STORE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpListPhone.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.grpOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPhone;
        private System.Windows.Forms.GroupBox grpListPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TextBox tbPricePhone;
        private System.Windows.Forms.TextBox tbCPUPhone;
        private System.Windows.Forms.TextBox tbOSPhone;
        private System.Windows.Forms.TextBox tbModelPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.ListBox lstOption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.Button btnAddNewPhone;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox lstOptionsNewPhone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameOption;
        private System.Windows.Forms.Button btnSaveChanched;
        private System.Windows.Forms.Button btnOptionDelete;
        private System.Windows.Forms.Button btnOptionAdd;
        private System.Windows.Forms.Label label10;
    }
}