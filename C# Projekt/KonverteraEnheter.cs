using System;
class LenghtUnit
{
    public double Meter;
    public double Yard;
    public double Fot;
    public double Tum;
    public double CentiMeter;
    public char InputUnit;
    public char OutputUnit;

    public void MeterMetod()
    {
        Boolean correct = true;
        do
        {
            try
            {
                Console.WriteLine("Skriv in talet!");
                Meter = Convert.ToDouble(Console.ReadLine());
                correct = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                correct = false;
            }

        } while (correct == false);
        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Skriv enheten du vill byta till? skriv T för tum, C för cm, Y för yard, M för meter, F för fot :) ");
                    OutputUnit = Convert.ToChar(Console.ReadLine());
                    OutputUnit = char.ToUpper(OutputUnit);
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    correct = false;

                }
            } while (correct == false);

            if (OutputUnit == 'T' || OutputUnit == 'C' || OutputUnit == 'Y' || OutputUnit == 'M' || OutputUnit == 'F')
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        } while (correct == false);
        if (InputUnit == 'M')
        {
            if (OutputUnit == 'T')
            {
                Console.WriteLine((Meter * 39.37));
            }
            else if (OutputUnit == 'C')
            {
                Console.WriteLine((Meter * 100));
            }
            else if (OutputUnit == 'F')
            {
                Console.WriteLine((Meter * 3.28));

            }
            else if (OutputUnit == 'Y')
            {
                Console.WriteLine((Meter * 1.093));

            }
            else
            {
                Console.WriteLine(Meter);
            }
        }
    }
    public void YardMetod()
    {
        Boolean correct = true;
        do
        {
            try
            {
                Console.WriteLine("Skriv in talet!");
                Yard = Convert.ToDouble(Console.ReadLine());
                correct = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                correct = false;
            }

        } while (correct == false);
        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Skriv enheten du vill byta till? skriv T för tum, C för cm, Y för yard, M för meter, F för fot :) ");
                    OutputUnit = Convert.ToChar(Console.ReadLine());
                    OutputUnit = char.ToUpper(OutputUnit);
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    correct = false;

                }
            } while (correct == false);

            if (OutputUnit == 'T' || OutputUnit == 'C' || OutputUnit == 'Y' || OutputUnit == 'M' || OutputUnit == 'F')
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        } while (correct == false);
        if (OutputUnit == 'T')
        {
            Console.WriteLine((Yard * 36));
        }
        else if (OutputUnit == 'C')
        {
            Console.WriteLine((Yard * 91.44));
        }
        else if (OutputUnit == 'F')
        {
            Console.WriteLine((Yard * 3));

        }
        else if (OutputUnit == 'M')
        {
            Console.WriteLine((Yard * 0.914));

        }
        else
        {
            Console.WriteLine(Yard);
        }

    }
    public void FotMetod()
    {
        Boolean correct = true;
        do
        {
            try
            {
                Console.WriteLine("Skriv in talet!");
                Fot = Convert.ToDouble(Console.ReadLine());
                correct = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                correct = false;
            }

        } while (correct == false);
        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Skriv enheten du vill byta till? skriv T för tum, C för cm, Y för yard, M för meter, F för fot :) ");
                    OutputUnit = Convert.ToChar(Console.ReadLine());
                    OutputUnit = char.ToUpper(OutputUnit);
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    correct = false;

                }
            } while (correct == false);

            if (OutputUnit == 'T' || OutputUnit == 'C' || OutputUnit == 'Y' || OutputUnit == 'M' || OutputUnit == 'F')
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        } while (correct == false);
        if (OutputUnit == 'T')
        {
            Console.WriteLine((Fot * 12));
        }
        else if (OutputUnit == 'C')
        {
            Console.WriteLine((Fot * 30.48));
        }
        else if (OutputUnit == 'Y')
        {
            Console.WriteLine((Fot * .333333));

        }
        else if (OutputUnit == 'M')
        {
            Console.WriteLine((Fot * 0.3048));

        }
        else
        {
            Console.WriteLine(Fot);
        }

    }
    public void TumMetod()
    {
        Boolean correct = true;
        do
        {
            try
            {
                Console.WriteLine("Skriv in talet!");
                Tum = Convert.ToDouble(Console.ReadLine());
                correct = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                correct = false;
            }

        } while (correct == false);
        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Skriv enheten du vill byta till? skriv T för tum, C för cm, Y för yard, M för meter, F för fot :) ");
                    OutputUnit = Convert.ToChar(Console.ReadLine());
                    OutputUnit = char.ToUpper(OutputUnit);
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    correct = false;

                }
            } while (correct == false);

            if (OutputUnit == 'T' || OutputUnit == 'C' || OutputUnit == 'Y' || OutputUnit == 'M' || OutputUnit == 'F')
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        } while (correct == false);
        if (OutputUnit == 'Y')
        {
            Console.WriteLine((Tum * 0.027778));
        }
        else if (OutputUnit == 'C')
        {
            Console.WriteLine((Tum * 2.54));
        }
        else if (OutputUnit == 'F')
        {
            Console.WriteLine((Tum * 0.083333));

        }
        else if (OutputUnit == 'M')
        {
            Console.WriteLine((Tum * 0.0254));

        }
        else
        {
            Console.WriteLine(Tum);
        }

    }
    public void CmMetod()
    {
        Boolean correct = true;
        do
        {
            try
            {
                Console.WriteLine("Skriv in talet!");
                CentiMeter = Convert.ToDouble(Console.ReadLine());
                correct = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                correct = false;
            }

        } while (correct == false);
        do
        {
            do
            {
                try
                {
                    Console.WriteLine("Skriv enheten du vill byta till? skriv T för tum, C för cm, Y för yard, M för meter, F för fot :) ");
                    OutputUnit = Convert.ToChar(Console.ReadLine());
                    OutputUnit = char.ToUpper(OutputUnit);
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    correct = false;

                }
            } while (correct == false);

            if (OutputUnit == 'T' || OutputUnit == 'C' || OutputUnit == 'Y' || OutputUnit == 'M' || OutputUnit == 'F')
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        } while (correct == false);
        if (OutputUnit == 'T')
        {
            Console.WriteLine((CentiMeter * 0.3937));
        }
        else if (OutputUnit == 'Y')
        {
            Console.WriteLine((CentiMeter * 0.01936133));
        }
        else if (OutputUnit == 'F')
        {
            Console.WriteLine((CentiMeter * 0.0328083));

        }
        else if (OutputUnit == 'M')
        {
            Console.WriteLine((CentiMeter * 0.01));

        }
        else
        {
            Console.WriteLine(CentiMeter);
        }

    }
}