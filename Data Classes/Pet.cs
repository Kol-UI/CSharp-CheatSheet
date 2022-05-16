using System;
using System.Collections.Generic;

namespace CSharp_CheatSheet
{
    public class Pet{
        public string Name { get; set; }
        public int Age { get; set; }

        public static List<Pet> GetAllCats()
        {
            return new List<Pet>(){
                new Pet { Name="Barley", Age = 8 },
                new Pet { Name="Boots", Age = 4 },
                new Pet { Name="Whiskers", Age = 1 }
            };
        }

        public static List<Pet> GetAllDogs()
        {
            return new List<Pet>(){
                new Pet { Name="Bounder", Age = 3 },
                new Pet { Name="Snoopy", Age = 14 },
                new Pet { Name="Fido", Age = 9 }
            };
        }

        public static List<Pet> GetAllBirds()
        {
            return new List<Pet>(){
                new Pet { Name="Pic", Age = 3 },
                new Pet { Name="Poc", Age = 2 },
                new Pet { Name="Pac", Age = 4 }
            };
        }

    }
}