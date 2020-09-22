using Ac4yClassModule.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSClassLibForJavaOData
{
    public class MyCar : Ac4yClass
    {
        public int Id { get; set; }
        public string Manufacture { get; set; }
        public long Price { get; set; }
        public bool Automata { get; set; }
        public DateTime BuyingDate { get; set; }
    }
}
