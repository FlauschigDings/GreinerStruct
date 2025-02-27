﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structogreiner.Xml.Objects.ControlStructures.Loops
{

    internal class Foreach : XmlObject
    {
        private readonly QForeach qFor;

        public Foreach(string variableName, string array) : base("for")
        {
            this.qFor = new QForeach();
            this.AddAttribute("text", Program.I18n.Foreach(variableName, array));
            this.AddAttribute("comment", "");
            this.AddAttribute("counterVar", variableName);
            this.AddAttribute("startValue", 1);
            this.AddAttribute("endValue", 0);
            this.AddAttribute("stepConst", 1);
            this.AddAttribute("style", "COUNTER");
            this.AddAttribute("color", "ffffff");
            this.AddAttribute("disabled", "0");
        }

        public Foreach AddXmlObject<T>(T t) where T : XmlObject
        {
            this.qFor.AddXmlObject(t);
            this.SetInnerXml(this.qFor);
            return this;
        }

        // idk why they do it that way 
        private class QForeach : XmlObject
        {
            public QForeach() : base("qFor")
            {
                this.AddAttribute("color", "ffffff");
            }

            public QForeach AddXmlObject<T>(T t) where T : XmlObject
            {
                this.AddInnerXml(t);
                return this;
            }
        }
    }
}
