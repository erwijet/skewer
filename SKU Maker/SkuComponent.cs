using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SKU_Maker
{
    [XmlRoot]
    public class SkuComponent
    {
        private ProductProperty _property;
        private string _staticText;

        public enum SkuComponentType { MUTABLE, CONDITIONAL, STATIC, NULL }
        public SkuComponentType Type { get; set; }
        public ProductProperty Property
        {
            get => _property; 
            set
            {
                Type = value.Conditional ? SkuComponentType.CONDITIONAL : SkuComponentType.MUTABLE; // autoset if property is defined
                _property = value;
            }
        }
        public string StaticText { 
            get => _staticText; 
            set
            {
                Type = SkuComponentType.STATIC;
                _staticText = value;
            }
        }

        public SkuComponent()
        {
        }
    }
}