using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Control
{
    public class Movies : Images
    {
        public string Length { get; private set; }
        public override void Parse(string str)
        {
            base.Parse(str);
            string[] strInput = str.Split(';');
            string[] ext = str.Split('.', '(');
            Extencion = ext[2];
            Resolution = strInput[1];
            Length = strInput[2];
        }
        public override string ToString()
        {
            return ($"{Name}({Size});{Resolution};{Length}");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"\tResolution: {Resolution}");
            Console.WriteLine($"\tLength: {Length}");
        }
    }
}
