
using PruebaTecnica.FredRodriguez.Logica;

bool EsEntero = false;
Cuestionario cuestionario = new Cuestionario();
Console.WriteLine("Punto 17 cuestionario division 2 numeros");
Console.WriteLine("Digite por favor el primer numero entero a dividir");
EsEntero = Int32.TryParse(Console.ReadLine(), out int num1);
if (!EsEntero)
{
    Console.WriteLine("El dato ingresado no es un entero");
}
else
{
    Console.WriteLine("Digite por favor el segundo numero entero a dividir");
    EsEntero = Int32.TryParse(Console.ReadLine(), out int num2);
    if (!EsEntero)
    {
        Console.WriteLine("El dato ingresado no es un entero");
    }
    else
    {
        double resultado = cuestionario.division(num1, num2);
        Console.WriteLine("Resultado de la division es " + resultado);
    }
}






