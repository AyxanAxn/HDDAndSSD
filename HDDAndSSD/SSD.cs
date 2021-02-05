using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HDDAndSSD
{
    class SSD : Storage
    {
        int sum=0;
        int timer = 0;
        int forBadSector;
        int j = 0;
        private readonly Random _random = new Random();
        private int SpeedOfUSB { get; set; } = 10;
        public SSD(string type,int storageOf,  string nameOfFirm)
            :base(type, storageOf,nameOfFirm)    
        {
          
        }
       
        public void CopyTo(int value) {
                sum += value;  
            if (sum>=0&&sum<StorageOf)
            {
                    Console.WriteLine("Melumat yazilir...... ");
                while (value>0)
                {
                 
                    value -= _random.Next(SpeedOfUSB); 
                    
                    if (value<=0)
                    {
                        Console.WriteLine("One minute....");
                        value = 0;
                    }
                    timer++;
                    Thread.Sleep(15);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Something happened");
            }
            Console.WriteLine($"Total time : {timer} seconds.");
            StorageOf -= sum;
            sum = 0;
            Console.WriteLine($"Free space  : {StorageOf}");
        }

        public void BadSectorScaning() {
            Console.WriteLine("It is SMART technology and it will scan your SSD and will tell you\n" +
                " you have bad sectors or not...");
            for (int i = 0; i < StorageOf; i++)
            {
                Console.Write("*.");
                Console.ForegroundColor = ConsoleColor.White;
                forBadSector= _random.Next(50);
                if (j==forBadSector)
                {
                    j++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    BadSector += 1;
                    if (j==50)
                    {
                        j = 0;
                    }
                    
                }
               // Thread.Sleep(50);

            }
        
        }




        public void Show() {
            base.Show();
            Console.WriteLine($"Speed          : {SpeedOfUSB}");
            Console.WriteLine("==============================");
        }

      
    }
}
