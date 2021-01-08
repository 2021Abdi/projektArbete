using System;
//5. Räkna ut area och/eller volym på olika figurer, rektangel, triangel, cirkel, kub, pyramid, sfär.
class Figure
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Radius { get; set; }
    public double Breadth { get; set; }
    public Boolean tryAgain;


    public void Rektangel()
    {
        do
        {

            try
            {
                Console.Write("Write down the height:   ");
                Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write down the width:    ");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("rektangel: {0}", Height * Width);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);



    }
    public void Triangel()
    {
        do
        {

            try
            {
                Console.Write("Write down the height:  ");
                Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write down the width:    ");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("triangel: {0}", (Height * Width) / 2);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);
    }
    public void Cirkel()
    {
        do
        {
            try
            {
                Console.Write("radius:  ");
                Radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("cirkel: {0}", Math.Pow(Radius, 2) * Math.PI);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);
    }

    public void Kub()
    {
        do
        {
            try
            {
                Console.Write("Write down the height:  ");
                Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write down the width:  ");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write down the breadth:  ");
                Breadth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Volymen på kuben är:  {0}", Breadth * Width * Height);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);
    }

    public void Pyramid()
    {
        do
        {

            try
            {
                Console.Write("Write down the height:  ");
                Height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write down the width:  ");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write down the breadth:  ");
                Breadth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The volume of the pyramid is :  {0}", (Breadth * Width * Height) / 3);
                tryAgain = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tryAgain = true;
            }
        } while (tryAgain == true);
    }

    public void Sfar()
    {
        do
        {
            Console.Write("Write down the radius:  ");
            try
            {
                Radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The volume of the sphere is {0}", (4 * Math.PI * Math.Pow(Radius, 3)) / 3);
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