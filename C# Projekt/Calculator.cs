using System;
namespace p
{
    //4. Räkna ut hastighet, tid i minuter och sträcka i km. hastighet=sträcka/tid.
    public class Calculator
    {
        public double Hastighet { get; set; }
        public double Tid { get; set; }
        public double Stracka { get; set; }

        public void Räknahastighet()
        {
            Boolean tryAgain;
            do
            {
                Console.Write("Skriv tiden i minuter:  ");
                try
                {
                    Tid = Convert.ToDouble(Console.ReadLine());
                    do
                    {
                        Console.Write("Skriv sträckan i km:  ");
                        try
                        {
                            Stracka = Convert.ToDouble(Console.ReadLine());
                            Hastighet = Stracka / (Tid / 60);
                            Console.WriteLine("hastighet = {0} km/h", Hastighet);
                            tryAgain = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            tryAgain = true;
                        }
                    } while (tryAgain == true);
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
        }
        public void Räknatid()
        {
            Boolean tryAgain;
            do
            {
                Console.Write("Skriv hatigheten i km/h:  ");
                try
                {
                    Hastighet = Convert.ToDouble(Console.ReadLine());
                    do
                    {
                        Console.Write("Skriv sträckan i km:  ");
                        try
                        {
                            Stracka = Convert.ToDouble(Console.ReadLine());
                            Tid = (Stracka / Hastighet) * 60;
                            Console.WriteLine("tid = {0} minuter", Tid);
                            tryAgain = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            tryAgain = true;
                        }
                    } while (tryAgain == true);
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
        }
        public void Räknastracka()
        {
            Boolean tryAgain;
            do
            {
                Console.Write("Skriv tiden i minute:  ");
                try
                {
                    Tid = Convert.ToDouble(Console.ReadLine());
                    do
                    {
                        Console.Write("Skriv hatigheten i km/h:  ");
                        try
                        {
                            Hastighet = Convert.ToDouble(Console.ReadLine());
                            Stracka = Hastighet * (Tid / 60);
                            Console.WriteLine("sträcka = {0} km", Stracka);
                            tryAgain = false;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            tryAgain = true;
                        }
                    } while (tryAgain == true);
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
        }
    }
}

