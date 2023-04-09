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
			switch(selectComboBox.SelectedIndex)
			{
				case 0: // открытие
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Filter = "Текстовый файл |*.txt|Файлы INI|*.ini|Все файлы|*.*";
                    dlg.FilterIndex = 1;
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        InputTextBox1.Text = dlg.FileName;
                    }
                    break;
				case 1: // сохранение
					// стандартный диалог сообщения
                    SaveFileDialog dlg2 = new SaveFileDialog();
                    dlg2.Filter = "Текстовый файл |*.txt|Файлы INI|*.ini|Все файлы|*.*";
                    dlg2.FilterIndex = 1;
					// показать диалог
                    DialogResult res2 = dlg2.ShowDialog();
                    if (res2 == DialogResult.OK)
                    {
                        InputTextBox1.Text = dlg2.FileName;
                    }
                    break;
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

		private void Task5Button_Click(object sender, EventArgs e)
		{
			Config conf = new Config();

			if(conf.AddSection("Data"))
			{
				if(conf.AddParameter("Data","Width"))
				{
					conf.SetValue("Data", "Width", "20");
				}
                if (conf.AddParameter("Data", "Height"))
                {
                    conf.SetValue("Data", "Height", "30");
                }
            }
			// показать в поле Результат
			resultRichTextBox1.Text = conf.ToString();
			// сохранить файл
			conf.Write(InputTextBox1.Text);
		}

		private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Task6_Click(object sender, EventArgs e)
		{
			//Transport t = new Transport("Транспорт", 10, 20); // нельзя - абстрактный
			Transport t = new AirTransport("Вертолет", 10, 20, 200);

			((AirTransport)t).Z = 500;
            //((WaterTransport)t).Volume = 20000;// нельзя t - это воздушный транспорт

            AirTransport a = new AirTransport("Самолет", 10, 20, 1000);

			WaterTransport w = new WaterTransport("Корабль", 19, 3, 1000);

			t.Move(5, 14);
			a.Move(11, 44);
			w.Move(37, 56);

			StringBuilder text = new StringBuilder();
            text.AppendLine(t.ToString());
            text.AppendLine(a.ToString());
            text.AppendLine(w.ToString());

			text.AppendLine("Классы транспортных средств:");
			text.AppendLine($"{t.Name} - {Transport.ClassName(t)}");
            text.AppendLine($"{a.Name} - {Transport.ClassName(a)}");
            text.AppendLine($"{w.Name} - {Transport.ClassName(w)}");


            resultRichTextBox1.Text = text.ToString();
		}
	}
	// сделать наземны транспорт у него есть длина
}
