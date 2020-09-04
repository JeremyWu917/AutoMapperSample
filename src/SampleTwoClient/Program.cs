using System;
using AutoMapper;
using SampleTwoDTOs;
using SampleTwoModels;

namespace SampleTwoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create map config and set mapping manually
            MapperConfiguration mapperConfiguration = new MapperConfiguration(
                mp => mp.CreateMap<Student, StudentDTO>().ForMember(stdto => stdto._id, st => st.MapFrom(p => p.Id > 0 ? 10 : p.Id)).ForMember(stdto => stdto._name, st => st.MapFrom(p => p.Name)).ForMember(stdto => stdto._age, st => st.MapFrom(p => p.Age)).ForMember(stdto => stdto._address, st => st.MapFrom(p => p.Address)));
            // Create mapper
            var mapConfig = mapperConfiguration.CreateMapper();
            // Add data 
            var data = mapConfig.Map<StudentDTO>(new Student
            {
                Id = 1,
                Name = "Jeremy Wu",
                Age = 28,
                Address = "Wuxi, JiangSu, China"
            });
            // Print data 
            Console.WriteLine("========== Below Data Is StudentDTO Information =========");
            Console.WriteLine($"Id:{data._id}\r\nName:{data._name}\r\nAge:{data._age}\r\nAddress:{data._address}");

            // Keeping hold
            Console.ReadKey();
        }
    }
}
