using System;


namespace HDDAndSSD
{

    class Program
    {

        static void Main(string[] args)
        {

           // SSD b = new SSD("SSD", 512, "Samsung");
           //
           // b.CopyTo(100);
           // b.CopyTo(100);
           // b.CopyTo(100);
           // b.BadSectorScaning();
           // Console.WriteLine();
           // b.Show();

            // Console.WriteLine();
            // Console.WriteLine();
            //
            //
            // HDD hdd = new HDD("HDD",512,"Toshiba");
            // hdd.CopyTo(100);
            // hdd.BadSectorScaning();
            // hdd.show();
            //
            string choose, choose1, choose2;

            int storage;
            // string Type;
            // string NameOfFirm;
            while (true)
            {
                Console.WriteLine($"Welcome to office.\nWhat type of storage device you want to take?\n1)DVD\n2)HDD\n3)SSD.\n4)Exit");
                choose = Console.ReadLine();
                TryToParse(choose);


                if (choose == "1")
                {
                    DVD dvd = new DVD("DVD", 512, "Toshiba");

                    Console.WriteLine("Okay you choose DVD");
                    Console.WriteLine("1)Write something to DVD disk.\n2)Bad sector scaning. \n3)Back. ");
                    choose = Console.ReadLine();
                    TryToParse(choose);
                    if (choose == "1")
                    {
                        Console.WriteLine("What is the size of the program you want to download : ");
                        choose = Console.ReadLine();
                        TryToParse(choose);
                        int tempstorage;
                        int.TryParse(choose, out tempstorage);
                        storage = tempstorage;
                        dvd.CopyTo(storage);



                    }
                    else if (choose == "2")
                    {
                        Console.WriteLine("Bad sector scaning...");
                        dvd.BadSectorScaning();
                    }
                    else
                    {
                        continue;
                    }




                }
                else if (choose == "2")
                {
                    HDD hdd = new HDD("HDD", 512, "Toshiba");
                    Console.WriteLine("Okay you choose DVD");
                    Console.WriteLine("1)Write something to HDD disk.\n2)Bad sector scaning. \n3)Back. ");
                    choose = Console.ReadLine();
                    TryToParse(choose);

                    if (choose == "1")
                    {
                        Console.WriteLine("What is the size of the program you want to download : ");
                        choose = Console.ReadLine();
                        TryToParse(choose);
                        int tempstorage;
                        int.TryParse(choose, out tempstorage);
                        storage = tempstorage;
                        hdd.CopyTo(storage);



                    }
                    else if (choose == "2")
                    {
                        Console.WriteLine("Bad sector scaning...");
                        hdd.BadSectorScaning();
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (choose == "3")
                {
                    SSD ssd = new SSD("SSD", 512, "Samsung");
                    Console.WriteLine("Okay you choose SSD");
                    Console.WriteLine("1)Write something to SSD disk.\n2)Bad sector scaning. \n3)Back. ");
                    choose = Console.ReadLine();
                    TryToParse(choose);

                    if (choose == "1")
                    {
                        Console.WriteLine("What is the size of the program you want to download : ");
                        choose = Console.ReadLine();
                        TryToParse(choose);
                        int tempstorage;
                        int.TryParse(choose, out tempstorage);
                        storage = tempstorage;
                        ssd.CopyTo(storage);



                    }
                    else if (choose == "2")
                    {
                        Console.WriteLine("Bad sector scaning...");
                        ssd.BadSectorScaning();
                    }
                    else
                    {
                        continue;
                    }

                }

                else
                {
                    break;
                }



            }



        }

        private static void TryToParse(int choose)
        {
            throw new NotImplementedException();
        }

        private static void TryToParse(string value)
        {
            short number;
            bool result = Int16.TryParse(value, out number);
            if (result)
            {

            }
            else
            {
                if (value == null) value = "";
                Console.WriteLine("Attempted conversion of '{0}' failed.", value);
            }
        }
    }
}
