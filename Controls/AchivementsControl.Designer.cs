
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pupilFilter = new System.Windows.Forms.CheckBox();
            this.PupilsList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlacesList = new System.Windows.Forms.ComboBox();
            this.LevelsList = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tableAchivements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAchivements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tableAchivements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAchivements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAchivements.Location = new System.Drawing.Point(0, 24);
            this.tableAchivements.MultiSelect = false;
            this.tableAchivements.Name = "tableAchivements";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.pupilFilter);
            this.groupBox1.Controls.Add(this.PupilsList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PlacesList);
            this.groupBox1.Controls.Add(this.LevelsList);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.CancelSearchButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 23);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Дата мероприятия";
            this.checkBox2.UseVisualStyleBackColor = true;
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
            // 
            // PupilsList
            // 
            this.PupilsList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PupilsList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PupilsList.BackColor = System.Drawing.SystemColors.Window;
            this.PupilsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PupilsList.FormattingEnabled = true;
            this.PupilsList.Location = new System.Drawing.Point(215, 27);
            this.PupilsList.Name = "PupilsList";
            this.PupilsList.Size = new System.Drawing.Size(250, 27);
            this.PupilsList.TabIndex = 8;
            this.PupilsList.SelectedIndexChanged += new System.EventHandler(this.PupilsList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Занимаемое место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Уровень олимпиады";
            // 
            // PlacesList
            // 
            this.PlacesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlacesList.FormattingEnabled = true;
            this.PlacesList.Location = new System.Drawing.Point(686, 70);
            this.PlacesList.Name = "PlacesList";
            this.PlacesList.Size = new System.Drawing.Size(219, 27);
            this.PlacesList.TabIndex = 4;
            // 
            // LevelsList
            // 
            this.LevelsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LevelsList.FormattingEnabled = true;
            this.LevelsList.Location = new System.Drawing.Point(686, 27);
            this.LevelsList.Name = "LevelsList";
            this.LevelsList.Size = new System.Drawing.Size(219, 27);
            this.LevelsList.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2021, 12, 8, 14, 57, 22, 0);
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Location = new System.Drawing.Point(1033, 66);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(195, 38);
            this.CancelSearchButton.TabIndex = 1;
            this.CancelSearchButton.Text = "CancelSearchButton";
            this.CancelSearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1033, 15);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(195, 38);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "SearchButton";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
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
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PlacesList;
        private System.Windows.Forms.ComboBox LevelsList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox PupilsList;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox pupilFilter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
    }
}
