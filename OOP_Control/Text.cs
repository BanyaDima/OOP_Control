using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Control
{
    class Text : File
    {
        public string Content { get; private set; }

        public override void Parse(string str)
        {
            base.Parse(str);
            string[] strInput = str.Split(';');
            Content = strInput[1];
        }
        public override string ToString()
        {
            return ($"{Name}({Size});{Content}");
        }

    }
}
