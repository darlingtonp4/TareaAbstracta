namespace TareaAbstracta;

public class Tiempo : FormulaMatematica
{
       public override double Calcular()
    {
        Console.WriteLine("Favor ingresar la distancia");
        double Distancia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Favor ingresar la velocidad");
        double Velocidad = Convert.ToDouble(Console.ReadLine());
        return Distancia/Velocidad;  
    }

    public override void Imprimir(double total)
    {
        Console.WriteLine($"Tiempo de Llegada es:{total} Horas");
        Console.WriteLine();
    }
}
