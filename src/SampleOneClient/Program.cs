using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SampleOneDTOs;
using SampleOneModels;

namespace SampleOneClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Config map and set mapping from student to studentdto 
            MapperConfiguration configuration = new MapperConfiguration(mp => mp.CreateMap<Student, StudentDTO>());
            // Create map
            var mapConfiguration = configuration.CreateMapper();
            // Mapping data from student to studentdto
            var datas = mapConfiguration.Map<List<StudentDTO>>(new List<Student> { new Student {

                Id = 1,
                Name = "Jeremy Wu",
                Age = 28,
                Gender = 'M',
                Class = "One",
                Grade = "One",
                Telephone = 1111234,
                Address ="Wuxi, JiangSu, China"
            }});
            // Get one studentdto record info
            StudentDTO studentDTO = datas.FirstOrDefault();
            // Print studentdto infomation
            Console.WriteLine("======= Below is the class student dto information =======");
            Console.WriteLine($"Id:{studentDTO.Id}\n\rName:{studentDTO.Name}\n\rAge:{studentDTO.Age}\r\nGender:{studentDTO.Gender}\r\nClass:{studentDTO.Class}\r\nGrade:{studentDTO.Gender}\r\nTelephone:{studentDTO.Telephone}\r\nAddress:{studentDTO.Address}");
            // Keep holding
            Console.ReadKey();

        }
    }
}
