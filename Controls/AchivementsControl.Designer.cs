
namespace TestProject.Controls
{
    partial class AchivementsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableAchivements = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endDateFilter = new System.Windows.Forms.DateTimePicker();
            this.dataSelect = new System.Windows.Forms.CheckBox();
            this.pupilFilter = new System.Windows.Forms.CheckBox();
            this.PupilsList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LevelsList = new System.Windows.Forms.ComboBox();
            this.beginDateFilter = new System.Windows.Forms.DateTimePicker();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableAchivements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableAchivements
            // 
            this.tableAchivements.AllowUserToAddRows = false;
            this.tableAchivements.AllowUserToDeleteRows = false;
            this.tableAchivements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAchivements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableAchivements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAchivements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAchivements.Location = new System.Drawing.Point(0, 24);
            this.tableAchivements.MultiSelect = false;
            this.tableAchivements.Name = "tableAchivements";
            this.tableAchivements.ReadOnly = true;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAchivements.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableAchivements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAchivements.Size = new System.Drawing.Size(1246, 395);
            this.tableAchivements.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableAchivements);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 552);
            this.splitContainer1.SplitterDistance = 419;
            this.splitContainer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.endDateFilter);
            this.groupBox1.Controls.Add(this.dataSelect);
            this.groupBox1.Controls.Add(this.pupilFilter);
            this.groupBox1.Controls.Add(this.PupilsList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LevelsList);
            this.groupBox1.Controls.Add(this.beginDateFilter);
            this.groupBox1.Controls.Add(this.CancelSearchButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "с";
            // 
            // endDateFilter
            // 
            this.endDateFilter.Enabled = false;
            this.endDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateFilter.Location = new System.Drawing.Point(391, 70);
            this.endDateFilter.Name = "endDateFilter";
            this.endDateFilter.Size = new System.Drawing.Size(146, 26);
            this.endDateFilter.TabIndex = 11;
            this.endDateFilter.Value = new System.DateTime(2021, 12, 10, 0, 0, 0, 0);
            this.endDateFilter.ValueChanged += new System.EventHandler(this.endDateFilter_ValueChanged);
            // 
            // dataSelect
            // 
            this.dataSelect.AutoSize = true;
            this.dataSelect.Location = new System.Drawing.Point(10, 72);
            this.dataSelect.Name = "dataSelect";
            this.dataSelect.Size = new System.Drawing.Size(172, 23);
            this.dataSelect.TabIndex = 10;
            this.dataSelect.Text = "Дата мероприятий";
            this.dataSelect.UseVisualStyleBackColor = true;
            this.dataSelect.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pupilFilter
            // 
            this.pupilFilter.AutoSize = true;
            this.pupilFilter.Location = new System.Drawing.Point(10, 29);
            this.pupilFilter.Name = "pupilFilter";
            this.pupilFilter.Size = new System.Drawing.Size(199, 23);
            this.pupilFilter.TabIndex = 9;
            this.pupilFilter.Text = "Участник (учащийся)";
            this.pupilFilter.UseVisualStyleBackColor = true;
            this.pupilFilter.CheckedChanged += new System.EventHandler(this.pupilFilter_CheckedChanged);
            // 
            // PupilsList
            // 
            this.PupilsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PupilsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PupilsList.BackColor = System.Drawing.SystemColors.Window;
            this.PupilsList.Enabled = false;
            this.PupilsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PupilsList.FormattingEnabled = true;
            this.PupilsList.Location = new System.Drawing.Point(215, 27);
            this.PupilsList.Name = "PupilsList";
            this.PupilsList.Size = new System.Drawing.Size(322, 27);
            this.PupilsList.TabIndex = 8;
            this.PupilsList.SelectedIndexChanged += new System.EventHandler(this.PupilsList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Уровень олимпиады";
            // 
            // LevelsList
            // 
            this.LevelsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LevelsList.FormattingEnabled = true;
            this.LevelsList.Location = new System.Drawing.Point(785, 27);
            this.LevelsList.Name = "LevelsList";
            this.LevelsList.Size = new System.Drawing.Size(219, 27);
            this.LevelsList.TabIndex = 3;
            // 
            // beginDateFilter
            // 
            this.beginDateFilter.Enabled = false;
            this.beginDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.beginDateFilter.Location = new System.Drawing.Point(215, 70);
            this.beginDateFilter.Name = "beginDateFilter";
            this.beginDateFilter.Size = new System.Drawing.Size(137, 26);
            this.beginDateFilter.TabIndex = 2;
            this.beginDateFilter.Value = new System.DateTime(2021, 12, 8, 14, 57, 22, 0);
            this.beginDateFilter.ValueChanged += new System.EventHandler(this.beginDateFilter_ValueChanged);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Location = new System.Drawing.Point(1039, 20);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(195, 38);
            this.CancelSearchButton.TabIndex = 1;
            this.CancelSearchButton.Text = "Вывод в Excel";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // AchivementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AchivementsControl";
            this.Size = new System.Drawing.Size(1246, 552);
            this.VisibleChanged += new System.EventHandler(this.AchivementsControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tableAchivements)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableAchivements;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LevelsList;
        private System.Windows.Forms.DateTimePicker beginDateFilter;
        private System.Windows.Forms.ComboBox PupilsList;
        private System.Windows.Forms.CheckBox dataSelect;
        private System.Windows.Forms.CheckBox pupilFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker endDateFilter;
    }
}
