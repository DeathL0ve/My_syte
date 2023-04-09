using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DanilinWindowsFormsApp
{
	public partial class MyForm : Form
	{
		public MyForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello world");
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			string data = InputTextBox1.Text;

			//MessageBox.Show(data, "Результат");
			int value;
			string result;

			if (int.TryParse(data, out value))
				result = "Число" + value.ToString();
			else
				result = "Не число";

			resultRichTextBox1.Text = result;
		}

		private void InputTextBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void ResultRichTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Button3_Click_Click(object sender, EventArgs e)
		{
			string fileName = InputTextBox1.Text;

			if (!File.Exists(fileName))
				return;

			StreamReader reader = new StreamReader(fileName);

			string data = reader.ReadToEnd();

			reader.Close();

			resultRichTextBox1.Text = data;

		}

		private void SelectFilebutton1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Текстовый файл |*.txt|Все файлы|*.*";
			dlg.FilterIndex = 1;
			DialogResult res = dlg.ShowDialog();
			if (res == DialogResult.OK)
			{
				InputTextBox1.Text = dlg.FileName;
			}
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			string fileName = InputTextBox1.Text;

			if (!File.Exists(fileName))
				return;

			StreamReader reader = new StreamReader(fileName);

			string str;

			List<string> strings = new List<string>();

			while(!reader.EndOfStream)
			{
				str = reader.ReadLine();

				if (!string.IsNullOrEmpty(str))
				{
					strings.Add(str);
				}
			}

			reader.Close();

			StringBuilder text = new StringBuilder();
			for (int i = 0; i < strings.Count; i++)
				text.AppendLine(strings[i]);

			resultRichTextBox1.Text = text.ToString();

		}
	}
}
