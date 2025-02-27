﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structogreiner.Xml.Objects.ControlStructures.Loops
{
    internal class While : LoopBase
    {
        public While(string ifValue) : base("while")
        {
            this.qLoops = new QWhile();
            this.AddAttribute("text", Program.I18n.While(ifValue));
            this.AddAttribute("commit", "");
            this.AddAttribute("disable", "0");
        }

        private class QWhile : LoopBase.QLoops
        {
            public QWhile() : base("qWhile") { }
        }
    }
}
