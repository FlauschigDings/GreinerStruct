﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structogreiner.Xml.Objects.ControlStructures.Loops
{
    internal class DoWhile : LoopBase
    {
        public DoWhile(string ifValue) : base("repeat")
        {
            this.qLoops = new QDoWhile();
            this.AddAttribute("text", Program.I18n.DoWhile(ifValue));
            this.AddAttribute("commit", "");
            this.AddAttribute("disable", "0");
        }

        private class QDoWhile : LoopBase.QLoops
        {
            public QDoWhile() : base("qRepeat") { }
        }
    }
}
