﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSRGS
{
    class Api
    {
        public static void TextToSRGSXML(string text)
        {
            var p = new Parser(text);
            p.Parse();
        }
    }
}
