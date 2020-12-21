// 예제 8.11 LINQ 쿼리 - 컬렉션의 모든 요소를 선택

using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1} in {2}", Name, Age, Address);
        }
    }

    class MainLanguage
    {
        public string Name { get; set; }
        public string Language { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Tom", Age = 63, Address = "Korea" },
                new Person { Name = "Winnie", Age = 40, Address = "Tibet" },
                new Person { Name = "Anders", Age = 47, Address = "Sudan" },
                new Person { Name = "Hans", Age = 25, Address = "Tibet" },
                new Person { Name = "Eureka", Age = 32, Address = "Sudan" },
                new Person { Name = "Hawk", Age = 15, Address = "Korea" },
            };

            List<MainLanguage> languages = new List<MainLanguage>
            {
                new MainLanguage { Name = "Anders", Language = "Delphi" },
                new MainLanguage { Name = "Anders", Language = "C#" },
                new MainLanguage { Name = "Tom", Language = "Borland C++" },
                new MainLanguage { Name = "Hans", Language = "Visual C++" },
                new MainLanguage { Name = "Winnie", Language = "R" },
            };


            var all = from person in people
                      select person;

            foreach (var item in all)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // nameList의 타입은 IEnumerable<string>
            var nameList = from person in people
                           select person.Name;

            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var dateList = from person in people
             select new { Name = person.Name, Year = DateTime.Now.AddYears(-person.Age).Year };

            foreach (var item in dateList)
            {
                Console.WriteLine(string.Format("{0} - {1}", item.Name, item.Year));
            }
            Console.WriteLine();


            var ageOver30 = from person in people
                            where person.Age > 30
                            select person;

            foreach (var item in ageOver30)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var endWithS = from person in people
                            where person.Name.EndsWith("s")
                            select person;
            
            foreach (var item in endWithS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var ageSort = from person in people
                          orderby person.Age // 나이순으로 정렬
                          select person;

            foreach (var item in ageSort)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var ageSortDesc = from person in people
                              orderby person.Age descending
                              select person;

            foreach (var item in ageSortDesc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var addrGroup = from person in people
                                group person by person.Address;
            
            foreach (var itemGroup in addrGroup) // group by로 묶여진 그룹을 나열하고,
            {
                Console.WriteLine(string.Format("[{0}]", itemGroup.Key));
                foreach (var item in itemGroup) // 해당 그룹 내에 속한 항목을 나열
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }


            var nameAgeList = from person in people
                        group new { Name = person.Name, Age = person.Age }  by person.Address;
            
            foreach (var itemGroup in nameAgeList)
            {
                Console.WriteLine(string.Format("[{0}]", itemGroup.Key));
                foreach (var item in itemGroup)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }


            var nameToLangList = from person in people
             join language in languages on person.Name equals language.Name
             select new { nameList= person.Name, Age = person.Age, Language = language.Language };

            foreach (var item in nameToLangList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            var nameToLangAllList = from person in people
              join language in languages on person.Name equals language.Name into lang
              from language in lang.DefaultIfEmpty(new MainLanguage())
              select new { Name = person.Name, Age = person.Age, Language = language.Language };
            
            foreach (var item in nameToLangAllList)
            {
                Console.WriteLine(item);
            }
        }
    }
}