using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Control
{
     public class File
    {
        public string Name { get; protected set; }
        public string Extencion { get; protected set; }
        public string Size { get; protected set; }

        public virtual void Parse( string str)
        {
            string[] strInput = str.Split(new char[] { '(', ')',}, StringSplitOptions.RemoveEmptyEntries);
            Name = strInput[0];
            Size = strInput[1];
            string[] ext = str.Split('.', '(');
            Extencion = ext[1];            
        }
        public virtual void Print()
        {
            Console.WriteLine($"{ Name}");
            Console.WriteLine($"\tExtencion: {Extencion}");
            Console.WriteLine($"\tSize: {Size}");
        }
       
    }
}
