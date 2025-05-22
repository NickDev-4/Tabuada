Console.Clear();

int numero, resultado;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Tabuada do {0}", numero);

for (int i = 0; i < 10; i++) {
    resultado = numero * i;

    Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
}