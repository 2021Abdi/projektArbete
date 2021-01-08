using System;
public class Ohmslag
{
    public double Späning;
    public double Ström;
    public double Resistance;



    public void GetResistance()
    {
        Boolean tryAgain = true;
        do
        {
            do
            {
                Console.WriteLine("Skriv in späningen");
                try
                {
                    Späning = Convert.ToDouble(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
            do
            {
                try
                {
                    Console.WriteLine("Skriv in strömen");
                    Ström = Convert.ToDouble(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
            Resistance = Späning / Ström;
            Console.WriteLine("Resistance är {0} Ohm", Resistance);


        } while (tryAgain == true);

    }
    public void GetSpäning()
    {
        Boolean tryAgain = true;
        do
        {
            do
            {
                Console.WriteLine("Skriv in resistansen");
                try
                {
                    Resistance = Convert.ToDouble(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
            do
            {
                try
                {
                    Console.WriteLine("Skriv in strömen");
                    Ström = Convert.ToDouble(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);


            Späning = Resistance * Ström;
            Console.WriteLine("Späningen är {0} Volt.", Späning);
        } while (tryAgain == true);
    }

    public void GetStröm()
    {
        Boolean tryAgain = true;
        do
        {
            do
            {
                Console.WriteLine("Skriv in resistansen");
                try
                {
                    Resistance = Convert.ToDouble(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);
            do
            {
                try
                {
                    Console.WriteLine("Skriv in Späningen");
                    Späning = Convert.ToDouble(Console.ReadLine());
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    tryAgain = true;
                }
            } while (tryAgain == true);


            Ström = Späning / Resistance;
            Console.WriteLine("Strömen är {0} Ampere", Ström);
        } while (tryAgain == true);

    }

}