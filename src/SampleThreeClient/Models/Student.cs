using System;
using System.Collections.Generic;

namespace SampleThreeClient.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public int DeleteFlag { get; set; }
    }
}
