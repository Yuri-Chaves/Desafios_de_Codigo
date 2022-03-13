int n, nota, quociente, resto;

n = int.Parse(Console.ReadLine());
Console.WriteLine(n);

resto = n;

for (int i = 0; i < 7; i++)
{
    nota = 0;
    switch (i)
    {
        case 0:
            nota = 100;
            break;
        case 1:
            nota = 50;
            break;
        case 2:
            nota = 20;
            break;
        case 3:
            nota = 10;
            break;
        case 4:
            nota = 5;
            break;
        case 5:
            nota = 2;
            break;
        case 6:
            nota = 1;
            break;
    }
    quociente = resto / nota;
    Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
    resto = resto % nota;
}
Console.ReadKey();
