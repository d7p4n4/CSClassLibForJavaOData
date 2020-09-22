using Ac4yClassModule.Class;
using System;

namespace CSClassLibForJavaOData
{
    public class Cars : Ac4yClass
    {
        public int Id { get; set; }
        public string Manufacture { get; set; }
        public string Type { get; set; }
        public string color { get; set; }
    }
}
