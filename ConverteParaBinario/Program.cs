int num, count=8;
int[] binario = new int[8] {0,0,0,0,0,0,0,0};

int converteParaBinario(int valor)
{
    count--;
    if (valor / 2 == 0)
        return binario[count] = (valor % 2);
    else
    {
        binario[count] = valor % 2;
        return converteParaBinario(valor / 2);
    }
}

Console.Write("Informe um numero decimal para converte-lo para binario: ");
num = int.Parse(Console.ReadLine());

converteParaBinario(num);
Console.Write("\nA conversao para binario eh: ");
for(int i = 0; i < 8; i++)
{
    Console.Write(binario[i]);
}
