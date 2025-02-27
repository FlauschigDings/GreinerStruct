﻿using Structogreiner.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structogreiner.Xml.Objects.ControlStructures.Loops
{
    internal class For : XmlObject
    {
        private readonly QFor qFor;

        public For(
            string variableName,
            IntVariable startValue,
            IntVariable endValue,
            IntVariable stepConst
        ) : base("for")
        {
            this.qFor = new QFor();
            String forText = Program.I18n.For(
                variableName,
                startValue,
                endValue,
                stepConst
                );

            this.AddAttribute("text", forText);
            this.AddAttribute("comment", "");
            this.AddAttribute("counterVar", variableName);
            this.AddAttribute("startValue", startValue);
            this.AddAttribute("endValue", endValue);
            this.AddAttribute("stepConst", stepConst);
            this.AddAttribute("style", "COUNTER");
            this.AddAttribute("color", "ffffff");
            this.AddAttribute("disabled", "0");
        }

        public For AddXmlObject<T>(T t) where T : XmlObject
        {
            this.qFor.AddXmlObject(t);
            this.SetInnerXml(this.qFor);
            return this;
        }

        // idk why they do it that way 
        private class QFor : XmlObject
        {
            public QFor() : base("qFor")
            {
                this.AddAttribute("color", "ffffff");
            }

            public QFor AddXmlObject<T>(T t) where T : XmlObject
            {
                this.AddInnerXml(t);
                return this;
            }
        }
    }
}
