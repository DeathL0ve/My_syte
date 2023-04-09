using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanilinWindowsFormsApp
{
    public abstract class Transport
    {
        double x;
        double y;
        string name;

        public Transport(string name, double x, double y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public string Name { get => name; set => name = value; }
        public virtual void Move(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"{name} X = {x}, Y = {y}";
        }
        public static string ClassName(Transport t)
        {
            string result = "Неизвестное";

            if(t == null)
                return result;
            if (t is Transport)
                result = "Транспорт";
            if (t is AirTransport)
                result = "Воздушный транспорт";
            if (t is WaterTransport)
                result = "Водный транспорт";


            return result;
        }

    }
    public class AirTransport : Transport
    {
        double z;

        public AirTransport(string name, double x, double y,  double z) : base(name, x, y) // конструктор базового класса
        {
            this.z = z;
        }

        public double Z { get => z; set => z = (value < 0) ? 0 : value; }
        public override string ToString()
        {
            string text = base.ToString() + $", Z={z}";
            //text = $"{Name} X={X}, Y={Y}, Z={Z}";
            return text;
        }
    }
    public class WaterTransport : Transport
    {
        double volume;

        public WaterTransport(string name, double x, double y,  double volume) : base(name, x, y)
        { 
            this.volume = volume;
        }

        public double Volume { get => volume; set => volume = value; }

        public override string ToString()
        {
            string text = base.ToString() + $", volume={volume}";
            return text;
        }
    }
}
