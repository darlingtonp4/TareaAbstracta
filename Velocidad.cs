namespace TareaAbstracta; 

public class Velocidad : FormulaMatematica {
    public override double Calcular()
    {
        Console.WriteLine("Favor ingresar la distancia en KM");
        double Distancia = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Favor ingresar el tiempo");
        double Tiempo = Convert.ToDouble(Console.ReadLine());
        return Distancia/Tiempo;  
    }

    public override void Imprimir(double total)
    {
        Console.WriteLine($"La velocidad es de:{total} KM/H");
        Console.WriteLine();
    }
}
