namespace _3_курс_2_задание
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
            this.ListBox_LB = new System.Windows.Forms.ListBox();
            this.ListBox_L = new System.Windows.Forms.Label();
            this.FieldOne_TB = new System.Windows.Forms.TextBox();
            this.FieldOne_L = new System.Windows.Forms.Label();
            this.FieldTwo_L = new System.Windows.Forms.Label();
            this.FieldTwo_TB = new System.Windows.Forms.TextBox();
            this.SubtracOperator_GB = new System.Windows.Forms.GroupBox();
            this.SubtracOperatorTwo_TB = new System.Windows.Forms.TextBox();
            this.SubtracOperatorTwo_L = new System.Windows.Forms.Label();
            this.SubtracOperator_B = new System.Windows.Forms.Button();
            this.SubtracOperatorOne_TB = new System.Windows.Forms.TextBox();
            this.SubtracOperatorOne_L = new System.Windows.Forms.Label();
            this.AddField_B = new System.Windows.Forms.Button();
            this.EqualsOperator_GB = new System.Windows.Forms.GroupBox();
            this.EqualsOperatorTwo_TB = new System.Windows.Forms.TextBox();
            this.EqualsOperatorTwo_L = new System.Windows.Forms.Label();
            this.EqualsOperator_B = new System.Windows.Forms.Button();
            this.EqualsOperatorOne_TB = new System.Windows.Forms.TextBox();
            this.EqualsOperatorOne_L = new System.Windows.Forms.Label();
            this.ResultingOperator_GB = new System.Windows.Forms.GroupBox();
            this.ResultingOperatorTwo_NUD = new System.Windows.Forms.NumericUpDown();
            this.ResultingOperatorTwo_L = new System.Windows.Forms.Label();
            this.ResultingOperator_B = new System.Windows.Forms.Button();
            this.LessOperator_GB = new System.Windows.Forms.GroupBox();
            this.LessOperatorTwo_TB = new System.Windows.Forms.TextBox();
            this.LessOperatorTwo_L = new System.Windows.Forms.Label();
            this.LessOperator_B = new System.Windows.Forms.Button();
            this.LessOperatorOne_TB = new System.Windows.Forms.TextBox();
            this.LessOperatorOne_L = new System.Windows.Forms.Label();
            this.Result_TB = new System.Windows.Forms.TextBox();
            this.Result_L = new System.Windows.Forms.Label();
            this.Del_B = new System.Windows.Forms.Button();
            this.SubtracOperator_GB.SuspendLayout();
            this.EqualsOperator_GB.SuspendLayout();
            this.ResultingOperator_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingOperatorTwo_NUD)).BeginInit();
            this.LessOperator_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_LB
            // 
            this.ListBox_LB.FormattingEnabled = true;
            this.ListBox_LB.Location = new System.Drawing.Point(12, 25);
            this.ListBox_LB.Name = "ListBox_LB";
            this.ListBox_LB.Size = new System.Drawing.Size(222, 355);
            this.ListBox_LB.TabIndex = 1;
            // 
            // ListBox_L
            // 
            this.ListBox_L.AutoSize = true;
            this.ListBox_L.Location = new System.Drawing.Point(12, 9);
            this.ListBox_L.Name = "ListBox_L";
            this.ListBox_L.Size = new System.Drawing.Size(95, 13);
            this.ListBox_L.TabIndex = 0;
            this.ListBox_L.Text = "Список &объектов";
            // 
            // FieldOne_TB
            // 
            this.FieldOne_TB.Location = new System.Drawing.Point(352, 25);
            this.FieldOne_TB.Name = "FieldOne_TB";
            this.FieldOne_TB.Size = new System.Drawing.Size(100, 20);
            this.FieldOne_TB.TabIndex = 3;
            // 
            // FieldOne_L
            // 
            this.FieldOne_L.AutoSize = true;
            this.FieldOne_L.Location = new System.Drawing.Point(250, 28);
            this.FieldOne_L.Name = "FieldOne_L";
            this.FieldOne_L.Size = new System.Drawing.Size(72, 13);
            this.FieldOne_L.TabIndex = 2;
            this.FieldOne_L.Text = "&Первое поле";
            // 
            // FieldTwo_L
            // 
            this.FieldTwo_L.AutoSize = true;
            this.FieldTwo_L.Location = new System.Drawing.Point(250, 58);
            this.FieldTwo_L.Name = "FieldTwo_L";
            this.FieldTwo_L.Size = new System.Drawing.Size(70, 13);
            this.FieldTwo_L.TabIndex = 4;
            this.FieldTwo_L.Text = "&Второе поле";
            // 
            // FieldTwo_TB
            // 
            this.FieldTwo_TB.Location = new System.Drawing.Point(352, 51);
            this.FieldTwo_TB.Name = "FieldTwo_TB";
            this.FieldTwo_TB.Size = new System.Drawing.Size(100, 20);
            this.FieldTwo_TB.TabIndex = 5;
            // 
            // SubtracOperator_GB
            // 
            this.SubtracOperator_GB.Controls.Add(this.SubtracOperatorTwo_TB);
            this.SubtracOperator_GB.Controls.Add(this.SubtracOperatorTwo_L);
            this.SubtracOperator_GB.Controls.Add(this.SubtracOperator_B);
            this.SubtracOperator_GB.Controls.Add(this.SubtracOperatorOne_TB);
            this.SubtracOperator_GB.Controls.Add(this.SubtracOperatorOne_L);
            this.SubtracOperator_GB.Location = new System.Drawing.Point(240, 87);
            this.SubtracOperator_GB.Name = "SubtracOperator_GB";
            this.SubtracOperator_GB.Size = new System.Drawing.Size(302, 84);
            this.SubtracOperator_GB.TabIndex = 7;
            this.SubtracOperator_GB.TabStop = false;
            this.SubtracOperator_GB.Text = "Оператор - (<T>,<T>)";
            // 
            // SubtracOperatorTwo_TB
            // 
            this.SubtracOperatorTwo_TB.Location = new System.Drawing.Point(112, 49);
            this.SubtracOperatorTwo_TB.Name = "SubtracOperatorTwo_TB";
            this.SubtracOperatorTwo_TB.Size = new System.Drawing.Size(100, 20);
            this.SubtracOperatorTwo_TB.TabIndex = 3;
            // 
            // SubtracOperatorTwo_L
            // 
            this.SubtracOperatorTwo_L.AutoSize = true;
            this.SubtracOperatorTwo_L.Location = new System.Drawing.Point(10, 52);
            this.SubtracOperatorTwo_L.Name = "SubtracOperatorTwo_L";
            this.SubtracOperatorTwo_L.Size = new System.Drawing.Size(81, 13);
            this.SubtracOperatorTwo_L.TabIndex = 2;
            this.SubtracOperatorTwo_L.Text = "В&торая строка";
            // 
            // SubtracOperator_B
            // 
            this.SubtracOperator_B.Location = new System.Drawing.Point(218, 21);
            this.SubtracOperator_B.Name = "SubtracOperator_B";
            this.SubtracOperator_B.Size = new System.Drawing.Size(75, 23);
            this.SubtracOperator_B.TabIndex = 4;
            this.SubtracOperator_B.Text = "&Выполнить";
            this.SubtracOperator_B.UseVisualStyleBackColor = true;
            this.SubtracOperator_B.Click += new System.EventHandler(this.SubtracOperator_B_Click);
            // 
            // SubtracOperatorOne_TB
            // 
            this.SubtracOperatorOne_TB.Location = new System.Drawing.Point(112, 23);
            this.SubtracOperatorOne_TB.Name = "SubtracOperatorOne_TB";
            this.SubtracOperatorOne_TB.Size = new System.Drawing.Size(100, 20);
            this.SubtracOperatorOne_TB.TabIndex = 1;
            // 
            // SubtracOperatorOne_L
            // 
            this.SubtracOperatorOne_L.AutoSize = true;
            this.SubtracOperatorOne_L.Location = new System.Drawing.Point(10, 26);
            this.SubtracOperatorOne_L.Name = "SubtracOperatorOne_L";
            this.SubtracOperatorOne_L.Size = new System.Drawing.Size(83, 13);
            this.SubtracOperatorOne_L.TabIndex = 0;
            this.SubtracOperatorOne_L.Text = "П&ервая строка";
            // 
            // AddField_B
            // 
            this.AddField_B.Location = new System.Drawing.Point(458, 23);
            this.AddField_B.Name = "AddField_B";
            this.AddField_B.Size = new System.Drawing.Size(75, 23);
            this.AddField_B.TabIndex = 6;
            this.AddField_B.Text = "&Добавить";
            this.AddField_B.UseVisualStyleBackColor = true;
            this.AddField_B.Click += new System.EventHandler(this.AddField_B_Click);
            // 
            // EqualsOperator_GB
            // 
            this.EqualsOperator_GB.Controls.Add(this.EqualsOperatorTwo_TB);
            this.EqualsOperator_GB.Controls.Add(this.EqualsOperatorTwo_L);
            this.EqualsOperator_GB.Controls.Add(this.EqualsOperator_B);
            this.EqualsOperator_GB.Controls.Add(this.EqualsOperatorOne_TB);
            this.EqualsOperator_GB.Controls.Add(this.EqualsOperatorOne_L);
            this.EqualsOperator_GB.Location = new System.Drawing.Point(240, 241);
            this.EqualsOperator_GB.Name = "EqualsOperator_GB";
            this.EqualsOperator_GB.Size = new System.Drawing.Size(302, 84);
            this.EqualsOperator_GB.TabIndex = 9;
            this.EqualsOperator_GB.TabStop = false;
            this.EqualsOperator_GB.Text = "Оператор == (<T>, <T>)";
            // 
            // EqualsOperatorTwo_TB
            // 
            this.EqualsOperatorTwo_TB.Location = new System.Drawing.Point(112, 49);
            this.EqualsOperatorTwo_TB.Name = "EqualsOperatorTwo_TB";
            this.EqualsOperatorTwo_TB.Size = new System.Drawing.Size(100, 20);
            this.EqualsOperatorTwo_TB.TabIndex = 3;
            // 
            // EqualsOperatorTwo_L
            // 
            this.EqualsOperatorTwo_L.AutoSize = true;
            this.EqualsOperatorTwo_L.Location = new System.Drawing.Point(10, 52);
            this.EqualsOperatorTwo_L.Name = "EqualsOperatorTwo_L";
            this.EqualsOperatorTwo_L.Size = new System.Drawing.Size(86, 13);
            this.EqualsOperatorTwo_L.TabIndex = 2;
            this.EqualsOperatorTwo_L.Text = "Вт&орая строчка";
            // 
            // EqualsOperator_B
            // 
            this.EqualsOperator_B.Location = new System.Drawing.Point(218, 21);
            this.EqualsOperator_B.Name = "EqualsOperator_B";
            this.EqualsOperator_B.Size = new System.Drawing.Size(75, 23);
            this.EqualsOperator_B.TabIndex = 4;
            this.EqualsOperator_B.Text = "Вы&полнить";
            this.EqualsOperator_B.UseVisualStyleBackColor = true;
            this.EqualsOperator_B.Click += new System.EventHandler(this.EqualsOperator_B_Click);
            // 
            // EqualsOperatorOne_TB
            // 
            this.EqualsOperatorOne_TB.Location = new System.Drawing.Point(112, 23);
            this.EqualsOperatorOne_TB.Name = "EqualsOperatorOne_TB";
            this.EqualsOperatorOne_TB.Size = new System.Drawing.Size(100, 20);
            this.EqualsOperatorOne_TB.TabIndex = 1;
            // 
            // EqualsOperatorOne_L
            // 
            this.EqualsOperatorOne_L.AutoSize = true;
            this.EqualsOperatorOne_L.Location = new System.Drawing.Point(10, 26);
            this.EqualsOperatorOne_L.Name = "EqualsOperatorOne_L";
            this.EqualsOperatorOne_L.Size = new System.Drawing.Size(88, 13);
            this.EqualsOperatorOne_L.TabIndex = 0;
            this.EqualsOperatorOne_L.Text = "Пе&рвая строчка";
            // 
            // ResultingOperator_GB
            // 
            this.ResultingOperator_GB.Controls.Add(this.ResultingOperatorTwo_NUD);
            this.ResultingOperator_GB.Controls.Add(this.ResultingOperatorTwo_L);
            this.ResultingOperator_GB.Controls.Add(this.ResultingOperator_B);
            this.ResultingOperator_GB.Location = new System.Drawing.Point(240, 177);
            this.ResultingOperator_GB.Name = "ResultingOperator_GB";
            this.ResultingOperator_GB.Size = new System.Drawing.Size(302, 58);
            this.ResultingOperator_GB.TabIndex = 8;
            this.ResultingOperator_GB.TabStop = false;
            this.ResultingOperator_GB.Text = "Оператор * (<T>, int)";
            // 
            // ResultingOperatorTwo_NUD
            // 
            this.ResultingOperatorTwo_NUD.Location = new System.Drawing.Point(112, 24);
            this.ResultingOperatorTwo_NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ResultingOperatorTwo_NUD.Name = "ResultingOperatorTwo_NUD";
            this.ResultingOperatorTwo_NUD.Size = new System.Drawing.Size(100, 20);
            this.ResultingOperatorTwo_NUD.TabIndex = 1;
            // 
            // ResultingOperatorTwo_L
            // 
            this.ResultingOperatorTwo_L.AutoSize = true;
            this.ResultingOperatorTwo_L.Location = new System.Drawing.Point(10, 26);
            this.ResultingOperatorTwo_L.Name = "ResultingOperatorTwo_L";
            this.ResultingOperatorTwo_L.Size = new System.Drawing.Size(91, 13);
            this.ResultingOperatorTwo_L.TabIndex = 0;
            this.ResultingOperatorTwo_L.Text = "&Кол. повторений";
            // 
            // ResultingOperator_B
            // 
            this.ResultingOperator_B.Location = new System.Drawing.Point(218, 21);
            this.ResultingOperator_B.Name = "ResultingOperator_B";
            this.ResultingOperator_B.Size = new System.Drawing.Size(75, 23);
            this.ResultingOperator_B.TabIndex = 2;
            this.ResultingOperator_B.Text = "В&ыполнить";
            this.ResultingOperator_B.UseVisualStyleBackColor = true;
            this.ResultingOperator_B.Click += new System.EventHandler(this.ResultingOperator_B_Click);
            // 
            // LessOperator_GB
            // 
            this.LessOperator_GB.Controls.Add(this.LessOperatorTwo_TB);
            this.LessOperator_GB.Controls.Add(this.LessOperatorTwo_L);
            this.LessOperator_GB.Controls.Add(this.LessOperator_B);
            this.LessOperator_GB.Controls.Add(this.LessOperatorOne_TB);
            this.LessOperator_GB.Controls.Add(this.LessOperatorOne_L);
            this.LessOperator_GB.Location = new System.Drawing.Point(240, 331);
            this.LessOperator_GB.Name = "LessOperator_GB";
            this.LessOperator_GB.Size = new System.Drawing.Size(302, 84);
            this.LessOperator_GB.TabIndex = 10;
            this.LessOperator_GB.TabStop = false;
            this.LessOperator_GB.Text = "Оператор < (<T>, <T>)";
            // 
            // LessOperatorTwo_TB
            // 
            this.LessOperatorTwo_TB.Location = new System.Drawing.Point(112, 49);
            this.LessOperatorTwo_TB.Name = "LessOperatorTwo_TB";
            this.LessOperatorTwo_TB.Size = new System.Drawing.Size(100, 20);
            this.LessOperatorTwo_TB.TabIndex = 3;
            // 
            // LessOperatorTwo_L
            // 
            this.LessOperatorTwo_L.AutoSize = true;
            this.LessOperatorTwo_L.Location = new System.Drawing.Point(10, 52);
            this.LessOperatorTwo_L.Name = "LessOperatorTwo_L";
            this.LessOperatorTwo_L.Size = new System.Drawing.Size(86, 13);
            this.LessOperatorTwo_L.TabIndex = 2;
            this.LessOperatorTwo_L.Text = "Вторая с&трочка";
            // 
            // LessOperator_B
            // 
            this.LessOperator_B.Location = new System.Drawing.Point(218, 21);
            this.LessOperator_B.Name = "LessOperator_B";
            this.LessOperator_B.Size = new System.Drawing.Size(75, 23);
            this.LessOperator_B.TabIndex = 4;
            this.LessOperator_B.Text = "Выпо&лнить";
            this.LessOperator_B.UseVisualStyleBackColor = true;
            this.LessOperator_B.Click += new System.EventHandler(this.LessOperator_B_Click);
            // 
            // LessOperatorOne_TB
            // 
            this.LessOperatorOne_TB.Location = new System.Drawing.Point(112, 23);
            this.LessOperatorOne_TB.Name = "LessOperatorOne_TB";
            this.LessOperatorOne_TB.Size = new System.Drawing.Size(100, 20);
            this.LessOperatorOne_TB.TabIndex = 1;
            // 
            // LessOperatorOne_L
            // 
            this.LessOperatorOne_L.AutoSize = true;
            this.LessOperatorOne_L.Location = new System.Drawing.Point(10, 26);
            this.LessOperatorOne_L.Name = "LessOperatorOne_L";
            this.LessOperatorOne_L.Size = new System.Drawing.Size(88, 13);
            this.LessOperatorOne_L.TabIndex = 0;
            this.LessOperatorOne_L.Text = "Первая &строчка";
            // 
            // Result_TB
            // 
            this.Result_TB.Location = new System.Drawing.Point(12, 454);
            this.Result_TB.Name = "Result_TB";
            this.Result_TB.ReadOnly = true;
            this.Result_TB.Size = new System.Drawing.Size(530, 20);
            this.Result_TB.TabIndex = 13;
            // 
            // Result_L
            // 
            this.Result_L.AutoSize = true;
            this.Result_L.Location = new System.Drawing.Point(12, 438);
            this.Result_L.Name = "Result_L";
            this.Result_L.Size = new System.Drawing.Size(59, 13);
            this.Result_L.TabIndex = 12;
            this.Result_L.Text = "&Результат";
            // 
            // Del_B
            // 
            this.Del_B.Location = new System.Drawing.Point(12, 392);
            this.Del_B.Name = "Del_B";
            this.Del_B.Size = new System.Drawing.Size(222, 23);
            this.Del_B.TabIndex = 11;
            this.Del_B.Text = "&Удалить";
            this.Del_B.UseVisualStyleBackColor = true;
            this.Del_B.Click += new System.EventHandler(this.Del_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 489);
            this.Controls.Add(this.Del_B);
            this.Controls.Add(this.Result_L);
            this.Controls.Add(this.Result_TB);
            this.Controls.Add(this.LessOperator_GB);
            this.Controls.Add(this.ResultingOperator_GB);
            this.Controls.Add(this.EqualsOperator_GB);
            this.Controls.Add(this.AddField_B);
            this.Controls.Add(this.SubtracOperator_GB);
            this.Controls.Add(this.FieldTwo_L);
            this.Controls.Add(this.FieldTwo_TB);
            this.Controls.Add(this.FieldOne_L);
            this.Controls.Add(this.FieldOne_TB);
            this.Controls.Add(this.ListBox_L);
            this.Controls.Add(this.ListBox_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SubtracOperator_GB.ResumeLayout(false);
            this.SubtracOperator_GB.PerformLayout();
            this.EqualsOperator_GB.ResumeLayout(false);
            this.EqualsOperator_GB.PerformLayout();
            this.ResultingOperator_GB.ResumeLayout(false);
            this.ResultingOperator_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultingOperatorTwo_NUD)).EndInit();
            this.LessOperator_GB.ResumeLayout(false);
            this.LessOperator_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_LB;
        private System.Windows.Forms.Label ListBox_L;
        private System.Windows.Forms.TextBox FieldOne_TB;
        private System.Windows.Forms.Label FieldOne_L;
        private System.Windows.Forms.Label FieldTwo_L;
        private System.Windows.Forms.TextBox FieldTwo_TB;
        private System.Windows.Forms.GroupBox SubtracOperator_GB;
        private System.Windows.Forms.Button AddField_B;
        private System.Windows.Forms.TextBox SubtracOperatorTwo_TB;
        private System.Windows.Forms.Label SubtracOperatorTwo_L;
        private System.Windows.Forms.Button SubtracOperator_B;
        private System.Windows.Forms.TextBox SubtracOperatorOne_TB;
        private System.Windows.Forms.Label SubtracOperatorOne_L;
        private System.Windows.Forms.GroupBox EqualsOperator_GB;
        private System.Windows.Forms.TextBox EqualsOperatorTwo_TB;
        private System.Windows.Forms.Label EqualsOperatorTwo_L;
        private System.Windows.Forms.Button EqualsOperator_B;
        private System.Windows.Forms.TextBox EqualsOperatorOne_TB;
        private System.Windows.Forms.Label EqualsOperatorOne_L;
        private System.Windows.Forms.GroupBox ResultingOperator_GB;
        private System.Windows.Forms.Label ResultingOperatorTwo_L;
        private System.Windows.Forms.Button ResultingOperator_B;
        private System.Windows.Forms.GroupBox LessOperator_GB;
        private System.Windows.Forms.TextBox LessOperatorTwo_TB;
        private System.Windows.Forms.Label LessOperatorTwo_L;
        private System.Windows.Forms.Button LessOperator_B;
        private System.Windows.Forms.TextBox LessOperatorOne_TB;
        private System.Windows.Forms.Label LessOperatorOne_L;
        private System.Windows.Forms.TextBox Result_TB;
        private System.Windows.Forms.Label Result_L;
        private System.Windows.Forms.NumericUpDown ResultingOperatorTwo_NUD;
        private System.Windows.Forms.Button Del_B;
    }
}

