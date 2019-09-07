using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Control
{
    class Images : File
    {
        public string Resolution { get; protected set; }

        public override void Parse(string str)
        {
            base.Parse(str);
            string[] strInput = str.Split(';');
            Resolution = strInput[1];

        }
        public override string ToString()
        {
            return ($"{Name}({Size});{Resolution}");
        }

    }
}
