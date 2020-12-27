namespace ListTablets
{
    partial class mainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbsNext = new System.Windows.Forms.Button();
            this.tslCount = new System.Windows.Forms.Label();
            this.tbsPrev = new System.Windows.Forms.Button();
            this.tbsDelete = new System.Windows.Forms.Button();
            this.tbsAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbDiagonal = new System.Windows.Forms.TextBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbMemory = new System.Windows.Forms.TextBox();
            this.tbStorage = new System.Windows.Forms.TextBox();
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(374, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbsNext
            // 
            this.tbsNext.Image = global::ListTablets.Properties.Resources.ImageNextButton;
            this.tbsNext.Location = new System.Drawing.Point(135, 2);
            this.tbsNext.Name = "tbsNext";
            this.tbsNext.Size = new System.Drawing.Size(32, 32);
            this.tbsNext.TabIndex = 4;
            this.tbsNext.UseVisualStyleBackColor = true;
            this.tbsNext.Click += new System.EventHandler(this.TbsNext_Click);
            // 
            // tslCount
            // 
            this.tslCount.AutoSize = true;
            this.tslCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tslCount.Location = new System.Drawing.Point(173, 12);
            this.tslCount.Name = "tslCount";
            this.tslCount.Size = new System.Drawing.Size(111, 13);
            this.tslCount.TabIndex = 5;
            this.tslCount.Text = "Количество записей";
            // 
            // tbsPrev
            // 
            this.tbsPrev.Image = global::ListTablets.Properties.Resources.ImagePreviousButton;
            this.tbsPrev.Location = new System.Drawing.Point(97, 2);
            this.tbsPrev.Name = "tbsPrev";
            this.tbsPrev.Size = new System.Drawing.Size(32, 32);
            this.tbsPrev.TabIndex = 3;
            this.tbsPrev.UseVisualStyleBackColor = true;
            this.tbsPrev.Click += new System.EventHandler(this.TbsPrev_Click);
            // 
            // tbsDelete
            // 
            this.tbsDelete.Image = global::ListTablets.Properties.Resources.ImageDeleteButton;
            this.tbsDelete.Location = new System.Drawing.Point(59, 2);
            this.tbsDelete.Name = "tbsDelete";
            this.tbsDelete.Size = new System.Drawing.Size(32, 32);
            this.tbsDelete.TabIndex = 2;
            this.tbsDelete.UseVisualStyleBackColor = true;
            this.tbsDelete.Click += new System.EventHandler(this.TbsDelete_Click);
            // 
            // tbsAdd
            // 
            this.tbsAdd.BackgroundImage = global::ListTablets.Properties.Resources.ImageAddButton;
            this.tbsAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tbsAdd.FlatAppearance.BorderSize = 0;
            this.tbsAdd.Image = global::ListTablets.Properties.Resources.ImageAddButton;
            this.tbsAdd.Location = new System.Drawing.Point(21, 2);
            this.tbsAdd.Name = "tbsAdd";
            this.tbsAdd.Size = new System.Drawing.Size(32, 32);
            this.tbsAdd.TabIndex = 1;
            this.tbsAdd.UseVisualStyleBackColor = true;
            this.tbsAdd.Click += new System.EventHandler(this.TbsAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Диагональ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Операционная система";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Оперативная память";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Встроенная память";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Процессор";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(182, 82);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(164, 20);
            this.tbModel.TabIndex = 12;
            // 
            // tbDiagonal
            // 
            this.tbDiagonal.Location = new System.Drawing.Point(182, 118);
            this.tbDiagonal.Name = "tbDiagonal";
            this.tbDiagonal.Size = new System.Drawing.Size(164, 20);
            this.tbDiagonal.TabIndex = 13;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(182, 154);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(164, 20);
            this.tbOS.TabIndex = 14;
            // 
            // tbMemory
            // 
            this.tbMemory.Location = new System.Drawing.Point(182, 188);
            this.tbMemory.Name = "tbMemory";
            this.tbMemory.Size = new System.Drawing.Size(164, 20);
            this.tbMemory.TabIndex = 15;
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(182, 224);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.Size = new System.Drawing.Size(164, 20);
            this.tbStorage.TabIndex = 16;
            // 
            // tbCPU
            // 
            this.tbCPU.Location = new System.Drawing.Point(182, 259);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.Size = new System.Drawing.Size(164, 20);
            this.tbCPU.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 344);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCPU);
            this.Controls.Add(this.tbStorage);
            this.Controls.Add(this.tbMemory);
            this.Controls.Add(this.tbOS);
            this.Controls.Add(this.tbDiagonal);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tslCount);
            this.Controls.Add(this.tbsNext);
            this.Controls.Add(this.tbsPrev);
            this.Controls.Add(this.tbsDelete);
            this.Controls.Add(this.tbsAdd);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список планшетов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button tbsAdd;
        private System.Windows.Forms.Button tbsDelete;
        private System.Windows.Forms.Button tbsPrev;
        private System.Windows.Forms.Button tbsNext;
        private System.Windows.Forms.Label tslCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbDiagonal;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tbMemory;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

