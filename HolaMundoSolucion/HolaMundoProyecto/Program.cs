internal class Program
{
    enum DiaSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo

    }

    

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("-------------- ");


        Console.WriteLine("       z$$$$$. $$");
        Console.WriteLine("      $$$$$$$$$$$");
        Console.WriteLine("     $$$$$$**$$$$                eeeer");
        Console.WriteLine("    $$$$$%   '$$$                $$$$F");
        Console.WriteLine(@"   4$$$$P     *$$                $$$$F");
        Console.WriteLine(@"   $$$$$      '$$    .ee.        $$$F ");
        Console.WriteLine(@"   $$$$$       ""   .$$$$$$b      $$$F 4$$$$$$ ");
        Console.WriteLine(@"   4$$$$F          4$$$""$$$$     $$$F '*$$$$*   $$$$$$");
        Console.WriteLine(@"   4$$$$F         .$$$F  ^$$$b   $$$F  J$$$   $$$$  ^$$$.");
        Console.WriteLine(@"   4$$$$F         d$$$    $$$$   $$$F J$$P   .$$$F   $$$$");
        Console.WriteLine(@"   4$$$$F         $$$$    3$$$F  $$$FJ$$P    4$$$   $$$$");
        Console.WriteLine(@"   4$$$$F        4$$$$    4$$$$  $$$$$$$r    $$$$$$$$$$$$");
        Console.WriteLine(@"   4$$$$$        4$$$$    4$$$$  $$$$$$$$    $$$$********");
        Console.WriteLine(@"    $$$$$        4$$$$    4$$$F  $$$F4$$$b   *$$$r");
        Console.WriteLine(@"    3$$$$F       d$$$$    $$$$   $$$   *$$$   $$$       .");
        Console.WriteLine(@"     $$$$$.     d$$$$$.   $$$$   $$$F  $$$$.  $$$$     z$P");
        Console.WriteLine(@"      $$$$$e. .d$$$$$$    $$$$   J$$$L  '$$$$ '$$$b. .d$$");
        Console.WriteLine(@"       *$$$$$$$$$  ^$$$be$$$     $$$$$$$  $$$$  $$$$$$$$");
        Console.WriteLine(@"        ^*$$$$P       $$$$       $$$$$$$  $$$$   $$$$$");

        Console.WriteLine("Introduce un numero del 1 al 7, o 0 para salir: ");
        string NumSemana = Console.ReadLine();

        while (NumSemana != "0")
        {
            switch (NumSemana)
            {
                case "1":
                    Console.WriteLine(DiaSemana.Lunes);
                    break;
                case "2":
                    Console.WriteLine(DiaSemana.Martes);
                    break;
                case "3":
                    Console.WriteLine(DiaSemana.Miercoles);
                    break;
                case "4":
                    Console.WriteLine(DiaSemana.Jueves);
                    break;
                case "5":
                    Console.WriteLine(DiaSemana.Viernes);
                    break;
                case "6":
                    Console.WriteLine(DiaSemana.Sabado);
                    break;
                case "7":
                    Console.WriteLine(DiaSemana.Domingo);
                    break;
                default:
                    Console.Write("Numero no valido, ");
                    break;
            }

            Console.WriteLine("Introduce un numero del 1 al 7, o 0 para salir: ");
            NumSemana = Console.ReadLine();
        }

        Console.WriteLine("Hasta Luego!");
    }

}