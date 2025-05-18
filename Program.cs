using TareaAbstracta;

Porcentaje porcentaje = new Porcentaje();
Tiempo tiempo = new Tiempo();
Velocidad velocidad = new Velocidad();
OpcionMenu();

void OpcionMenu()
{
    int opcion = 0;
    do
    {
        Console.WriteLine("Menu de opciones");
        Console.WriteLine("1.Calcular porcentaje");
        Console.WriteLine("2.Calcular velocidad");
        Console.WriteLine("3.Calcular tiempo de llegada");
        Console.WriteLine("4. Terminar aplicacion");
        Console.WriteLine("Favor ingresar el numero de la opcion que desea");

        opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                porcentaje.Imprimir(porcentaje.Calcular());
                Console.WriteLine();
                break;
            case 2:
                velocidad.Imprimir(velocidad.Calcular());
                Console.WriteLine();
                break;
            case 3:
                tiempo.Imprimir(tiempo.Calcular());
                Console.WriteLine();
                break;
            case 4:
                Console.WriteLine("Gracias por utilizar el programa, hasta pronto");
                Console.WriteLine();
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Ingreso un numero invalido");
                Console.WriteLine();
                break;
        }

    } while (opcion != 4);

}
