using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Control
{
    class File
    {
        public string Name { get; protected set; }
        public string Extencion { get; protected set; }
        public string Size { get; protected set; }

        public virtual void Parse( string str)
        {
            string[] strInput = str.Split(new char[] { '(', ')',}, StringSplitOptions.RemoveEmptyEntries);
            Name = strInput[0];
            Extencion = strInput[0];
            Size = strInput[1];
        }
        public override string ToString()
        {

            return ($"{Name}({Size})"); 
        }
    }
}
