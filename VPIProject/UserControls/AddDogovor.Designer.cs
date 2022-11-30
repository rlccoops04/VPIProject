namespace VPIProject
{
    partial class AddDogovor
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDateStart = new System.Windows.Forms.TextBox();
            this.tbDateEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArendator = new System.Windows.Forms.ComboBox();
            this.btnAddDogovor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDateStart
            // 
            this.tbDateStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDateStart.Location = new System.Drawing.Point(345, 45);
            this.tbDateStart.Name = "tbDateStart";
            this.tbDateStart.PlaceholderText = "01.01.2000";
            this.tbDateStart.Size = new System.Drawing.Size(125, 27);
            this.tbDateStart.TabIndex = 3;
            // 
            // tbDateEnd
            // 
            this.tbDateEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDateEnd.Location = new System.Drawing.Point(345, 102);
            this.tbDateEnd.Name = "tbDateEnd";
            this.tbDateEnd.PlaceholderText = "01.01.2000";
            this.tbDateEnd.Size = new System.Drawing.Size(125, 27);
            this.tbDateEnd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер комнаты";
            // 
            // cbNumRoom
            // 
            this.cbNumRoom.FormattingEnabled = true;
            this.cbNumRoom.Location = new System.Drawing.Point(135, 45);
            this.cbNumRoom.Name = "cbNumRoom";
            this.cbNumRoom.Size = new System.Drawing.Size(151, 28);
            this.cbNumRoom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Арендатор";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(348, 22);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(164, 20);
            this.lblDateStart.TabIndex = 8;
            this.lblDateStart.Text = "Дата начала договора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата окончания договора";
            // 
            // cbArendator
            // 
            this.cbArendator.FormattingEnabled = true;
            this.cbArendator.Location = new System.Drawing.Point(135, 99);
            this.cbArendator.Name = "cbArendator";
            this.cbArendator.Size = new System.Drawing.Size(151, 28);
            this.cbArendator.TabIndex = 10;
            // 
            // btnAddDogovor
            // 
            this.btnAddDogovor.Location = new System.Drawing.Point(260, 157);
            this.btnAddDogovor.Name = "btnAddDogovor";
            this.btnAddDogovor.Size = new System.Drawing.Size(136, 48);
            this.btnAddDogovor.TabIndex = 11;
            this.btnAddDogovor.Text = "Добавить";
            this.btnAddDogovor.UseVisualStyleBackColor = true;
            this.btnAddDogovor.Click += new System.EventHandler(this.btnAddDogovor_Click);
            // 
            // AddDogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnAddDogovor);
            this.Controls.Add(this.cbArendator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNumRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDateEnd);
            this.Controls.Add(this.tbDateStart);
            this.Name = "AddDogovor";
            this.Size = new System.Drawing.Size(638, 233);
            this.Load += new System.EventHandler(this.AddDogovor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbDateStart;
        private TextBox tbDateEnd;
        private Label label1;
        private ComboBox cbNumRoom;
        private Label label2;
        private Label lblDateStart;
        private Label label4;
        private ComboBox cbArendator;
        private Button btnAddDogovor;
    }
}
