namespace TareaAbstracta; 
public class Porcentaje : FormulaMatematica
{

    public override double Calcular()
    {
        Console.WriteLine("Favor ingresar el valor parcial");
        double ValorParcial = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Favor ingresar el valor total");
        double ValorTotal = Convert.ToDouble(Console.ReadLine());
        return ValorParcial/ValorTotal * 100;
    }

    public override void Imprimir(double total)
    {
        Console.WriteLine($"El promedio es de: {total}");
        Console.WriteLine();
    }
}
