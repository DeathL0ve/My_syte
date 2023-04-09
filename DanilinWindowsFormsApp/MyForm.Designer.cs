
namespace DanilinWindowsFormsApp
{
	partial class MyForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.resultRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.selectFilebutton1 = new System.Windows.Forms.Button();
            this.task5Button = new System.Windows.Forms.Button();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.TaskButton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Задача 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Задача 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ввод:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.Location = new System.Drawing.Point(221, 36);
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(379, 20);
            this.InputTextBox1.TabIndex = 4;
            this.InputTextBox1.TextChanged += new System.EventHandler(this.InputTextBox1_TextChanged);
            // 
            // resultRichTextBox1
            // 
            this.resultRichTextBox1.Location = new System.Drawing.Point(221, 79);
            this.resultRichTextBox1.Name = "resultRichTextBox1";
            this.resultRichTextBox1.Size = new System.Drawing.Size(379, 237);
            this.resultRichTextBox1.TabIndex = 5;
            this.resultRichTextBox1.Text = "";
            this.resultRichTextBox1.TextChanged += new System.EventHandler(this.ResultRichTextBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(56, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Задача 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Задача 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // selectFilebutton1
            // 
            this.selectFilebutton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectFilebutton1.Location = new System.Drawing.Point(606, 35);
            this.selectFilebutton1.Name = "selectFilebutton1";
            this.selectFilebutton1.Size = new System.Drawing.Size(30, 23);
            this.selectFilebutton1.TabIndex = 8;
            this.selectFilebutton1.Text = "...";
            this.selectFilebutton1.UseVisualStyleBackColor = true;
            this.selectFilebutton1.Click += new System.EventHandler(this.SelectFilebutton1_Click);
            // 
            // task5Button
            // 
            this.task5Button.Location = new System.Drawing.Point(56, 150);
            this.task5Button.Name = "task5Button";
            this.task5Button.Size = new System.Drawing.Size(75, 24);
            this.task5Button.TabIndex = 9;
            this.task5Button.Text = "Задача 5";
            this.task5Button.UseVisualStyleBackColor = true;
            this.task5Button.Click += new System.EventHandler(this.Task5Button_Click);
            // 
            // selectComboBox
            // 
            this.selectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "Открытие",
            "Сохранение"});
            this.selectComboBox.Location = new System.Drawing.Point(606, 79);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(65, 21);
            this.selectComboBox.TabIndex = 10;
            this.selectComboBox.SelectedIndexChanged += new System.EventHandler(this.selectComboBox_SelectedIndexChanged);
            // 
            // TaskButton5
            // 
            this.TaskButton5.Location = new System.Drawing.Point(56, 180);
            this.TaskButton5.Name = "TaskButton5";
            this.TaskButton5.Size = new System.Drawing.Size(75, 23);
            this.TaskButton5.TabIndex = 11;
            this.TaskButton5.Text = "Задача6";
            this.TaskButton5.UseVisualStyleBackColor = true;
            this.TaskButton5.Click += new System.EventHandler(this.Task6_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskButton5);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.task5Button);
            this.Controls.Add(this.selectFilebutton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.resultRichTextBox1);
            this.Controls.Add(this.InputTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MyForm";
            this.Text = "мой первый проект";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox InputTextBox1;
		private System.Windows.Forms.RichTextBox resultRichTextBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button selectFilebutton1;
		private System.Windows.Forms.Button task5Button;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Button TaskButton5;
    }
}

