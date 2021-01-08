using System;


namespace p
{
    class Program
    {
        static void Main(string[] args)
        {
            int alternativ = 0;
            do
            {
                Boolean tryAgain = false;

                Console.WriteLine("\n Hej välkommen :)");
                Console.WriteLine("-----------------------");
                Console.WriteLine("[1] Omvandla mellan Fahrenheit/Celsius/Kelvin.");
                Console.WriteLine("[2] Räkna ut hastighet, tid i minuter och sträcka i km.");
                Console.WriteLine("[3] Räkna ut area/volym på olika figurer, rektangel, triangel, cirkel, kub, pyramid, sfä");
                Console.WriteLine("[4] Omvandla mellan Meter, Yard osv");
                Console.WriteLine("[5] Räkna ut Ohmslag!");
                Console.WriteLine("[6] Avsluta!");

                do
                {
                    try
                    {
                        Console.Write("\nVälj ett alternativ: ");
                        alternativ = Convert.ToInt32(Console.ReadLine());
                        tryAgain = false;

                    }
                    catch (Exception ex)
                    {
                        if (alternativ > 6 || alternativ <= 0)
                        {
                            tryAgain = false;
                        }
                        else
                        {
                            tryAgain = true;
                        }
                        Console.WriteLine(ex.Message);
                        tryAgain = true;
                    }
                } while (tryAgain == true);


                switch (alternativ)
                {
                    case 1:
                        OmvandlaFahrenheitCelsiusKelvin();
                        break;

                    case 2:
                        HastighetTidStrack();
                        break;
                    case 3:
                        AreaVolym();
                        break;
                    case 4:
                        ConvertUnit();
                        break;
                    case 5:
                        NewOhmsLag();
                        break;
                }
            } while (alternativ != 6);
            Console.Clear();
        }

        static void HastighetTidStrack()
        {
            Calculator hastig = new Calculator();

            bool tryAgain = false;
            Console.WriteLine("Vad vill du räkna ut?");
            Console.WriteLine("h: hastighet");
            Console.WriteLine("t: tid");
            Console.WriteLine("s: sträcka");
            Console.Write("Enter h, t or s: ");
            {
                string answerOption = (Console.ReadLine()).ToUpper();
                if (answerOption == "H" || answerOption == "T" || answerOption == "S")
                {
                    tryAgain = false;
                    switch (answerOption)
                    {
                        case "H":
                            hastig.Räknahastighet();
                            break;
                        case "T":
                            hastig.Räknatid();
                            break;
                        case "S":
                            hastig.Räknastracka();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please enter h, t or s.");
                    tryAgain = true;
                }

            } while (tryAgain == true) ;
        }

        static void OmvandlaFahrenheitCelsiusKelvin()
        {
            Temperature temperature = new Temperature();
            bool tryAgain = false;
            Console.WriteLine("What do you want to convert?");
            Console.WriteLine("c: celsius");
            Console.WriteLine("k: kelvin");
            Console.WriteLine("f: fahrenheit");
            Console.Write("Enter c, k or f: ");
            do
            {
                string answerOption = (Console.ReadLine()).ToLower();
                if (answerOption == "c" || answerOption == "k" || answerOption == "f")
                {
                    tryAgain = false;
                    switch (answerOption)
                    {
                        case "c":
                            temperature.Cel();
                            break;
                        case "k":
                            temperature.Kel();
                            break;
                        case "f":
                            temperature.Fahren();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltigt, försök skriv c, k eller f.");
                    tryAgain = true;
                }

            } while (tryAgain == true);
        }

        static void AreaVolym()
        {
            Figure f1 = new Figure();
            bool tryAgain = false;
            Console.WriteLine("Hej skriv vad för figure du vill räkna ut? skriv 'r' för rektangle,'t' för triangle, 'c' för cirkel,'k' för kub, 'p'för pyramid och 's' för sfär.");
            do
            {
                string choice = (Console.ReadLine()).ToLower();
                if (choice == "r" || choice == "t" || choice == "c" || choice == "k" || choice == "p" || choice == "s")
                {
                    tryAgain = false;
                    switch (choice)
                    {
                        case "t":
                            f1.Triangel();
                            break;
                        case "r":
                            f1.Rektangel();
                            break;
                        case "c":
                            f1.Cirkel();
                            break;
                        case "k":
                            f1.Kub();
                            break;
                        case "p":
                            f1.Pyramid();
                            break;
                        case "s":
                            f1.Sfar();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ogiltigt, skriv vad för figure du vill räkna ut? skriv 'r' för rektangle,'t' för triangle, 'c' för cirkel,'k' för kub, 'p'för pyramid och 's' för sfär.");
                    tryAgain = true;
                }

            } while (tryAgain == true);
        }
        static void ConvertUnit()
        {
            LenghtUnit inputUnit = new LenghtUnit();
            LenghtUnit outputUnit = new LenghtUnit();
            Boolean correct = true;
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Hej skriv enheten du vill byta ifrån? skriv T för tum, C för cm, Y för yard, M för meter, F för fot :) ");
                        char input = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                        inputUnit.InputUnit = input;
                        correct = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        correct = false;

                    }
                } while (correct == false);

                if (inputUnit.InputUnit == 'T' || inputUnit.InputUnit == 'C' || inputUnit.InputUnit == 'Y' || inputUnit.InputUnit == 'M' || inputUnit.InputUnit == 'F')
                {
                    correct = true;
                }
                else
                {
                    correct = false;
                }
            } while (correct == false);

            if (inputUnit.InputUnit == 'T')
            {
                inputUnit.TumMetod();
            }
            if (inputUnit.InputUnit == 'C')
            {
                inputUnit.CmMetod();
            }
            if (inputUnit.InputUnit == 'Y')
            {
                inputUnit.YardMetod();
            }
            if (inputUnit.InputUnit == 'M')
            {
                inputUnit.MeterMetod();
            }
            if (inputUnit.InputUnit == 'F')
            {
                inputUnit.FotMetod();
            }

        }
        public static void NewOhmsLag()
        {
            Ohmslag ohmslag = new Ohmslag();
            Boolean correct = false;
            char choice = ' ';
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Vad vill du räkna ut? skriv U för späning R för resistans och I för ström");
                        choice = Convert.ToChar(Console.ReadLine());
                        choice = char.ToUpper(choice);
                        correct = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        correct = false;
                    }
                } while (correct == false);

                if ((choice == 'U' || choice == 'R' || choice == 'I'))
                {
                    correct = true;
                }
                else
                {
                    correct = false;
                }
            } while (correct == false);

            if (choice == 'U')
            {
                ohmslag.GetSpäning();
            }
            if (choice == 'I')
            {
                ohmslag.GetStröm();
            }
            if (choice == 'R')
            {
                ohmslag.GetResistance();
            }

        }
    }
}


