using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DanilinWindowsFormsApp
{
    public class Config
    {
        Dictionary<string, Section> sections;
        public Config()
        {
            sections = new Dictionary<string, Section>();
        }
        public bool Read(string fileName)
        {

            return true;

        }
        public bool Write(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                return false;
            
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            
            writer.Write(ToString());
            
            writer.Close();

            return true;
        }

        public bool AddSection(string section)
        {
            if (sections.ContainsKey(section))
                return false;//секция уже есть

            //секции нет, создаем новую
            Section sec = new Section(section);
            //добавляем в словарь
            sections.Add(section, sec);

            return true;
        }
        public bool DeleteSection(string section)
        {
            if(sections.ContainsKey(section))
            {
                sections.Remove(section);
                return true;
            }
            return true;
        }

        public bool AddParameter(string section, string paramName)
        {
            if(sections.ContainsKey(section))
            {
                // получение секции 

                Section sec = sections[section];

                return sec.AddParameter(paramName);
            }
            return false;
        }
        public bool DeleteParameter(string section, string paramName)
        {
            if(sections.ContainsKey(section))
            {
                Section sec = sections[section];
                return sec.DeleteParameter(paramName);

            }
            return false;
        }

        public bool SetValue(string section, string paramName, string value)
        {
            if (sections.ContainsKey(section))
            { 
              Section sec = sections[section];
              return sec.SetValue(paramName, value);
            }
            return false;
        }

        public bool GetValue(string section, string paramName, out string value)
        {   
            value = string.Empty;
            if (sections.ContainsKey(section))
            {
                return sections[section].GetValue(paramName, out value);

            }
            
            return false;
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            foreach (KeyValuePair<string, Section> s in sections)
                text.AppendLine(s.Value.ToString());

            return text.ToString();
        }

    }
}
