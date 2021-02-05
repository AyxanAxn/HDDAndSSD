using System;
using System.Threading;

namespace HDDAndSSD
{
    class DVD:Storage
    {

        private int _forBadSector = 0;
        private int j = 0;
        private readonly Random _random = new Random();
        private int _timer = 0;
        private int _sum = 0;

        public int SpeedOfDVD { get; set; } = 10;
        public DVD(string type,int storageOf, string nameOfFirm)
          : base(type,storageOf, nameOfFirm)
        {

        }


        public void CopyTo(int value)
        {
            _sum += value;
            if (_sum >= 0 && _sum < StorageOf)
            {
                Console.WriteLine("Melumat yazilir...... ");
                while (value > 0)
                {

                    value -= _random.Next(SpeedOfDVD);

                    if (value <= 0)
                    {
                        Console.WriteLine("One minute....");
                        value = 0;
                    }
                    _timer++;
                    Thread.Sleep(15);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Something happened");
            }
            Console.WriteLine($"Total time : {_timer} seconds.");
            StorageOf -= _sum;
            _sum = 0;
            Console.WriteLine($"Free space  : {StorageOf}");
        }



        public void BadSectorScaning()
        {
            Console.WriteLine("It is SMART technology and it will scan your DVD and will tell you\n" +
                " you have bad sectors or not...");
            for (int i = 0; i < StorageOf; i++)
            {
                Console.Write("*.");
                Console.ForegroundColor = ConsoleColor.White;
                _forBadSector = _random.Next(50);
                if (j == _forBadSector)
                {
                    j++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    BadSector += 1;
                    if (j == 50)
                    {
                        j = 0;
                    }

                }
                // Thread.Sleep(50);

            }

        }


      

        public void Show() {
            base.Show();
            Console.WriteLine($"Speed          : {SpeedOfDVD}");
            Console.WriteLine("==============================");
        }
    }
}
