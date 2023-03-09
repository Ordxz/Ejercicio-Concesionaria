namespace Ejercicio_Concesionaria;
class Program
{
    static void Main(string[] args)
    {
        bool mostrarMenu=true;
        while(mostrarMenu)
        {
            mostrarMenu=Menu();
        }

    }
    public static bool Menu(){ //El static es para poder llamar metodos de la misma clase
        Console.Clear();
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine("1 -- Agregar Automovil");
        Console.WriteLine("2 -- Eliminar Automovil");
        Console.WriteLine("3 -- Buscar Automovil");
        Console.WriteLine("4 -- Listar todos");
        Console.WriteLine("5 -- Salir");
        Console.Write("Opción: ");

        switch (Console.ReadLine()){
            
            case "1":
                Console.WriteLine("Seleccionaste 1 ");
                Console.ReadLine();
                return true;

            case "2":
                Console.WriteLine("Seleccionaste 2 ");
                Console.ReadLine();
                return true;
            case "3":
                Console.WriteLine("Seleccionaste 3 ");
                Console.ReadLine();
                return true;
            case "4":
                Console.WriteLine("Seleccionaste 4 ");
                Console.ReadLine();
                return true;
            case "5":
                return false;
            default:
                return true;
        }
        
        
    }
}
