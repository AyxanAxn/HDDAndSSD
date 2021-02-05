using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDDAndSSD
{
    // Base class
    abstract class Storage
    {
        protected Storage( string type,int storageOf,string nameOfFirm)
        {
            Type = type;

            StorageOf = storageOf;
        
            
            NameOfFirm = nameOfFirm;
        }
        public string Type { get; set; }
        public int StorageOf { get; set; }
        public int BadSector { get; set; } = 0;
      
        public string NameOfFirm { get; set; }

        public void Show() {
            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine($"Name of firm   : {NameOfFirm}");
            Console.WriteLine($"Type of device : {Type}");
            Console.WriteLine($"Bad sector     : {BadSector}");
            Console.WriteLine($"Free memory    : {StorageOf}");
            
        }

    }
}
