Console.Clear();



 Console.WriteLine("--- Esperto Contra Sabido ---");

 Console.Write("Quantos alimentos serão distribuídos? ");


int totalAlimentos = int.Parse(Console.ReadLine());
int picaPau = 0;
int raposinha = 0;
int round = 1;
int restante = totalAlimentos;
 

 while (totalAlimentos > 0)

{
    if (totalAlimentos > 0)


    {
        int picaPauAlimentos = Math.Min(1, restante);
        Console.Write($"{picaPauAlimentos} para você. ");
        picaPau += picaPauAlimentos;
        restante -= picaPauAlimentos;
    }



    if (restante > 0)


    {
        Console.Write("1, ");
        for (int i = 0; i <= round && totalAlimentos > 0; i++)

        {
            Console.Write(i + (i < round ? ", " : ""));
            totalAlimentos--;
            raposinha = +restante;
        }


        Console.WriteLine(" para mim.");
    }


    round++;
}


Console.WriteLine();

Console.WriteLine($"Pica-pau recebeu {picaPau} alimento(s).");
Console.WriteLine($"Raposinha recebeu {raposinha} alimento(s).");
    

