using System;
//2. Omvandla mellan Fahrenheit/Celsius/Kelvin.
class Temperature
{
    public double Celsius;
    public double Kelvin;
    public double Fahrenheit;

    public void Cel()
    {
        Boolean tryAgain;
        do
        {
            Console.Write("Skriv hur många celsius:  ");
            try
            {
                Celsius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kelvin = {0}", Celsius + 273);
                Console.WriteLine("Fahrenheit = {0}", Celsius * 18 / 10 + 32);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);
    }
    public void Kel()
    {
        Boolean tryAgain;
        do
        {

            try
            {
                Console.Write("Skriv hur många kelvin:  ");
                Kelvin = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("celsius = {0}", Kelvin - 273);
                Console.WriteLine("fahrenheit = {0}", (Kelvin - 273.15) * 9 / 5 + 32);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);
    }
    public void Fahren()
    {
        Boolean tryAgain;

        do
        {

            try
            {
                Console.Write("Skriv hur många fahrenheit:  ");
                Fahrenheit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("celsius = {0}", Fahrenheit * 18 / 10 - 32);
                Console.WriteLine("kelvin = {0}", (Fahrenheit - 32) * 5 / 9 + 273.15);
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
