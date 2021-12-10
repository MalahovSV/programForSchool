
namespace TestProject
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.achivementsPupils = new System.Windows.Forms.Button();
            this.Pupils = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.470459F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.52954F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(828, 427);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.achivementsPupils);
            this.flowLayoutPanel1.Controls.Add(this.Pupils);
            this.flowLayoutPanel1.Controls.Add(this.Help);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 427);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // achivementsPupils
            // 
            this.achivementsPupils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.achivementsPupils.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.achivementsPupils.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.achivementsPupils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.achivementsPupils.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.achivementsPupils.Location = new System.Drawing.Point(3, 3);
            this.achivementsPupils.Name = "achivementsPupils";
            this.achivementsPupils.Size = new System.Drawing.Size(150, 60);
            this.achivementsPupils.TabIndex = 0;
            this.achivementsPupils.Text = "Достижения учеников";
            this.achivementsPupils.UseVisualStyleBackColor = false;
            this.achivementsPupils.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pupils
            // 
            this.Pupils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pupils.FlatAppearance.BorderSize = 0;
            this.Pupils.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pupils.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.Pupils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pupils.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Pupils.Location = new System.Drawing.Point(3, 69);
            this.Pupils.Name = "Pupils";
            this.Pupils.Size = new System.Drawing.Size(150, 60);
            this.Pupils.TabIndex = 1;
            this.Pupils.Text = "Ученики";
            this.Pupils.UseVisualStyleBackColor = false;
            this.Pupils.Click += new System.EventHandler(this.Pupils_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Help.Location = new System.Drawing.Point(3, 135);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(150, 60);
            this.Help.TabIndex = 2;
            this.Help.Text = "Помощь";
            this.Help.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(834, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button achivementsPupils;
        private System.Windows.Forms.Button Pupils;
        private System.Windows.Forms.Button Help;
    }
}