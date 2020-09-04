using AutoMapper;
using SampleThreeClient.ModelDTOs;
using SampleThreeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleThreeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Config map and set mapping from student to studentdto 
            MapperConfiguration configuration = new MapperConfiguration(mp => mp.CreateMap<Student, StudentDTO>());
            // Create map
            var mapConfiguration = configuration.CreateMapper();
            using (var DB = new IITMSTestContext())
            {
                // View the data
                var datas = mapConfiguration.Map<List<StudentDTO>>(DB.Student.Where(s => s.DeleteFlag == 0));
                if (datas != null && datas.Count() > 0)
                {
                    Console.WriteLine("Show Message About StudentDTO");
                    foreach (var item in datas)
                    {
                        Console.WriteLine($"Id:{item.Id} Remark:{item.Remark}");
                    }
                }
                Console.ReadKey();

                //// Separation of read and write, direct manipulation of database entity classes when writing data.
                // Update the data
                //StudentDTO studentDTO = new StudentDTO();
                //studentDTO.Id = 1;
                //studentDTO.Remark = "Update testing";
                //DB.Entry(studentDTO).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //DB.SaveChanges();
                //// View the data again
                //var datasNew = mapConfiguration.Map<List<StudentDTO>>(DB.Student.Where(s => s.DeleteFlag == 0));
                //if (datasNew != null && datas.Count() > 0)
                //{
                //    Console.WriteLine("Show Message About StudentDTO");
                //    foreach (var item in datasNew)
                //    {
                //        Console.WriteLine($"Id:{item.Id} Remark:{item.Remark}");
                //    }
                //}
            }
            Console.ReadKey();
        }
    }
}
