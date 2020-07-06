using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Security.Policy;
using System.Diagnostics;

namespace SKU_Maker
{
    [XmlRoot("Property")]
    public class ProductProperty
    {
        [XmlAttribute("title")]
        public string Title { get; set; }
        [XmlAttribute("conditional")]
        public bool Conditional { get; set; }
        public List<PropertyOption> Values { get; set; }

        public ProductProperty()
        {
        }

        public ProductProperty(string title, bool conditional)
        {
            Title = title;
            Conditional = conditional;
            Values = new List<PropertyOption>();
        }

        public void AddValidValue(string value, string code)
        {
            Values.Add(PropertyOption.Create(value, code));
        }
    }

    [XmlRoot("Valid Property Option")]
    public class PropertyOption
    {
        public enum ConditionMode { IS, ISNT }

        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("code")]
        public string Code { get; set; }
        [XmlAttribute("conditional")]
        public bool isConditional { get; set; }

        public ConditionMode? mode { get; set; }
        [XmlElement(IsNullable = true)]
        public string ConditionPropertyTarget { get; set; }
        [XmlElement(IsNullable = true)]
        public string ConditionValue { get; set; }

        public static PropertyOption Create(string name, string code, bool conditional = false, ConditionMode mode = ConditionMode.IS, string conditionalTarget = "", string conditionalValue = "")
        {
            PropertyOption prop = new PropertyOption();
            prop.set(name, code, conditional);

            if (conditional)
            {
                prop.ConditionPropertyTarget = conditionalTarget;
                prop.ConditionValue = conditionalValue;
                prop.mode = mode;
            }

            return prop;
        }

        public PropertyOption()
        {
        }

        public void set(string name, string code, bool conditional)
        {
            Name = name;
            Code = code;
            isConditional = conditional;
        }
    }
}
