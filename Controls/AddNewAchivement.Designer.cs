
namespace TestProject.Controls
{
    partial class AddNewAchivement
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
            this.PupilsList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.placeText = new System.Windows.Forms.TextBox();
            this.eventText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.levelText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateAchivement = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.typeEventText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PupilsList
            // 
            this.PupilsList.FormattingEnabled = true;
            this.PupilsList.Location = new System.Drawing.Point(117, 44);
            this.PupilsList.Name = "PupilsList";
            this.PupilsList.Size = new System.Drawing.Size(322, 27);
            this.PupilsList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ученик";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.typeEventText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.levelText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddressText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eventText);
            this.groupBox1.Controls.Add(this.placeText);
            this.groupBox1.Location = new System.Drawing.Point(52, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проприятие";
            // 
            // placeText
            // 
            this.placeText.Location = new System.Drawing.Point(174, 131);
            this.placeText.Name = "placeText";
            this.placeText.Size = new System.Drawing.Size(207, 26);
            this.placeText.TabIndex = 0;
            // 
            // eventText
            // 
            this.eventText.Location = new System.Drawing.Point(113, 25);
            this.eventText.Name = "eventText";
            this.eventText.Size = new System.Drawing.Size(268, 26);
            this.eventText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат (место)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(80, 167);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(301, 26);
            this.AddressText.TabIndex = 7;
            // 
            // levelText
            // 
            this.levelText.Location = new System.Drawing.Point(84, 57);
            this.levelText.Name = "levelText";
            this.levelText.Size = new System.Drawing.Size(297, 26);
            this.levelText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Уровень";
            // 
            // dateAchivement
            // 
            this.dateAchivement.Location = new System.Drawing.Point(219, 298);
            this.dateAchivement.Name = "dateAchivement";
            this.dateAchivement.Size = new System.Drawing.Size(200, 26);
            this.dateAchivement.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата мероприятия";
            // 
            // addRecordButton
            // 
            this.addRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRecordButton.FlatAppearance.BorderSize = 0;
            this.addRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.addRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecordButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRecordButton.Location = new System.Drawing.Point(31, 343);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(132, 58);
            this.addRecordButton.TabIndex = 7;
            this.addRecordButton.Text = "Добавить";
            this.addRecordButton.UseVisualStyleBackColor = false;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearAllButton.FlatAppearance.BorderSize = 0;
            this.ClearAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearAllButton.Location = new System.Drawing.Point(169, 343);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(132, 58);
            this.ClearAllButton.TabIndex = 8;
            this.ClearAllButton.Text = "Отчистить все поля";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            // 
            // CanselButton
            // 
            this.CanselButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CanselButton.FlatAppearance.BorderSize = 0;
            this.CanselButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CanselButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.CanselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanselButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CanselButton.Location = new System.Drawing.Point(307, 343);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(132, 58);
            this.CanselButton.TabIndex = 9;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = false;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тип мероприятия";
            // 
            // typeEventText
            // 
            this.typeEventText.Location = new System.Drawing.Point(156, 92);
            this.typeEventText.Name = "typeEventText";
            this.typeEventText.Size = new System.Drawing.Size(225, 26);
            this.typeEventText.TabIndex = 10;
            this.typeEventText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewAchivement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateAchivement);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PupilsList);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNewAchivement";
            this.Text = "Новая запись";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PupilsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox levelText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eventText;
        private System.Windows.Forms.TextBox placeText;
        private System.Windows.Forms.DateTimePicker dateAchivement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeEventText;
    }
}