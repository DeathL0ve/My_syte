using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DanilinWindowsFormsApp
{
    public class Section
    {
        string name;
        Dictionary<string, string> parameters;    
        public Section(string name)
        {
            // задать имя секции
            this.name = name;
            // создать экземпляр словаря
            parameters = new Dictionary<string, string>(); 
        }
        public bool AddParameter(string paramName)
        {
            
            if (parameters.ContainsKey(paramName))
                return false;//секция уже есть

           
            parameters.Add(paramName, String.Empty);
            return true;
        }
        public bool DeleteParameter(string paramName)
        {
            if(parameters.ContainsKey(paramName))
            {
                parameters.Remove(paramName);   
                return true;
            }
            return true;
        }

        public bool SetValue(string paramName, string value)
        {
            if (parameters.ContainsKey(paramName))
            {
                parameters[paramName] = value;
                return true;
            }
            return true;
        }

        public bool GetValue(string paramName, out string value)
        {
            value = string.Empty;
            if(parameters.ContainsKey(paramName))
            {
                value = parameters[paramName];
                return true;
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"[{name}]"); // имя секции
            // параметры со значениеми 
            foreach (KeyValuePair<string, string> p in parameters)
                text.AppendLine($"{p.Key} = {p.Value}");

            return text.ToString();
        }
    }
}
