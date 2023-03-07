int num, count=8;
int[] binario = new int[8] {0,0,0,0,0,0,0,0};

void converterParaBinario(int valor)
{
    count--;
    binario[count] = valor % 2;
    if (valor / 2 != 0)
        converterParaBinario(valor / 2);
}

do
{
    Console.Write("Informe um numero inteiro positivo para converte-lo para binario: ");
    num = int.Parse(Console.ReadLine());
} while (num < 0 || num > 255);

converterParaBinario(num);

Console.Write("\nA conversao para binario eh: ");

for(int i = 0; i < 8; i++)
{
    Console.Write(binario[i]);
}
