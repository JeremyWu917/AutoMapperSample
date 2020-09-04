using System;
using System.Collections.Generic;
using System.Text;

namespace SampleOneDTOs
{
    public class StudentDTO
    {
        /// <summary>
        /// System Unique Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ss' Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ss' Age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Ss' Gender
        /// </summary>
        public char Gender { get; set; }
        /// <summary>
        /// Ss' Class
        /// </summary>
        public string Class { get; set; }
        /// <summary>
        /// Ss' Grade
        /// </summary>
        public string Grade { get; set; }
        /// <summary>
        /// Ss' Phone Number
        /// </summary>
        public int Telephone { get; set; }
        /// <summary>
        /// Ss' Address
        /// </summary>
        public string Address { get; set; }
    }
}
