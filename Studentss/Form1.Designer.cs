namespace Studentss
{
    partial class Form1
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
            this.table = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectionMode = new System.Windows.Forms.ComboBox();
            this.View = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResetView = new System.Windows.Forms.Button();
            this.secondtable = new System.Windows.Forms.DataGridView();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkOfS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondtable)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.SecondName,
            this.Group,
            this.Mark});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(461, 206);
            this.table.TabIndex = 0;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // Namee
            // 
            this.Namee.HeaderText = "Имя";
            this.Namee.Name = "Namee";
            this.Namee.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Фамилия";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Оценка";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            // 
            // SelectionMode
            // 
            this.SelectionMode.FormattingEnabled = true;
            this.SelectionMode.Items.AddRange(new object[] {
            "По имени",
            "По группе",
            "Неудачники"});
            this.SelectionMode.Location = new System.Drawing.Point(51, 248);
            this.SelectionMode.Name = "SelectionMode";
            this.SelectionMode.Size = new System.Drawing.Size(121, 21);
            this.SelectionMode.TabIndex = 1;
            this.SelectionMode.SelectedIndexChanged += new System.EventHandler(this.SelectionMode_SelectedIndexChanged);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(350, 245);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 2;
            this.View.Text = "Найти";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 3;
            // 
            // ResetView
            // 
            this.ResetView.Location = new System.Drawing.Point(431, 245);
            this.ResetView.Name = "ResetView";
            this.ResetView.Size = new System.Drawing.Size(112, 23);
            this.ResetView.TabIndex = 4;
            this.ResetView.Text = "Сброс поиска";
            this.ResetView.UseVisualStyleBackColor = true;
            this.ResetView.Click += new System.EventHandler(this.ResetView_Click);
            // 
            // secondtable
            // 
            this.secondtable.AllowUserToAddRows = false;
            this.secondtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secondtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subject,
            this.MarkOfS});
            this.secondtable.Location = new System.Drawing.Point(517, 12);
            this.secondtable.Name = "secondtable";
            this.secondtable.ReadOnly = true;
            this.secondtable.Size = new System.Drawing.Size(286, 150);
            this.secondtable.TabIndex = 5;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 140;
            // 
            // MarkOfS
            // 
            this.MarkOfS.HeaderText = "Оценка";
            this.MarkOfS.Name = "MarkOfS";
            this.MarkOfS.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 297);
            this.Controls.Add(this.secondtable);
            this.Controls.Add(this.ResetView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.SelectionMode);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.ComboBox SelectionMode;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResetView;
        private System.Windows.Forms.DataGridView secondtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkOfS;
    }
}

