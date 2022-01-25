using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableDemoProj.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {


            GlaxiesList();

            //MemoryHungryExample();

            //YieldReturnExample();


            //WithTakeExample();
        }
       
        public static List<int> EvenNumbers(int max)
        {
            var result = new List<int>();

            int i = 0;

            while(result.Count < max)
            {
                result.Add(i += 2);
            }

            return result;
        }

        public static IEnumerable<int> OddNumbers(int max)
        {
            int i = 1;
            while(i < (max * 2))
            {
                yield return i;
                i += 2;
            }
        }

        //Memory Hungry Beast
        static void MemoryHungryExample()
        {            
            foreach (var i in EvenNumbers(1000000000))
            {
                Console.WriteLine($"Number: {i}");
            }

        }

        //Memory Friendly YieldReturn
        static void YieldReturnExample()
        {

            foreach (var i in OddNumbers(1000000000))
            {
                Console.WriteLine($"Number: {i}");
            }
        }

        static void WithTakeExample()
        {
            foreach (var i in OddNumbers(1000000000).Skip(5).Take(10))
            {
                Console.WriteLine($"Number: {i}");
            }
        }


        //Glaxies Example
        static void GlaxiesList()
        {
            var galaxies = new List<Galaxy>();

            galaxies.Add(new Galaxy { Name = "Tadpole", MegaLightYears = 400 });
            galaxies.Add(new Galaxy { Name = "Pinwheel", MegaLightYears = 25 });
            galaxies.Add(new Galaxy { Name = "Milky Way", MegaLightYears = 0 });
            galaxies.Add(new Galaxy { Name = "Andromeda", MegaLightYears = 3 });

            foreach (var galaxy in galaxies)
            {
                Console.WriteLine(galaxy.Name);
            }
        }

        public class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}
