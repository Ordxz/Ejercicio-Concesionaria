namespace Ejercicio_Concesionaria
{
   class Menu{

Concesionaria concesionaria = new Concesionaria(10);
    public bool showMenu()
    {
        Console.Clear();
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine("1 -- Agregar Automovil");
        Console.WriteLine("2 -- Eliminar Automovil");
        Console.WriteLine("3 -- Buscar Automovil");
        Console.WriteLine("4 -- Listar todos");
        Console.WriteLine("5 -- Salir");
        Console.Write("Opción: ");

        switch (Console.ReadLine())
        {

            case "1":
                Console.WriteLine("Seleccionaste 1 ");
                agregarAutomovil();
                Console.ReadLine();
                return true;

            case "2":
                Console.WriteLine("Seleccionaste 2 ");
                eliminarAutomovil();
                Console.ReadLine();
                return true;
            case "3":
                Console.WriteLine("Seleccionaste 3 ");
                buscarAutomovil();
                Console.ReadLine();
                return true;
            case "4":
                Console.WriteLine("Seleccionaste 4 ");
                mostrarAutomoviles();
                Console.ReadLine();
                return true;
            case "5":
                return false;
            default:
                return true;
        }


    }

    public void agregarAutomovil()
    {
        Console.Clear();
        Console.WriteLine("Creando nuevo automóvil...");
        Console.Write("ID: ");
        string? id = Console.ReadLine();
        Console.Write("Marca: ");
        string? marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string? modelo = Console.ReadLine();
        Console.Write("Kilometraje: ");
        string? KM = Console.ReadLine();
        Console.Write("Precio: ");
        string? precio = Console.ReadLine();
        Automovil nuevo = new Automovil(
            id,
            marca,
            modelo,
            int.Parse(KM),
            double.Parse(precio)
        );
        concesionaria.AgregarAuto(nuevo);
        Console.WriteLine("Automovil agregado correctamente");    
        }

        public void eliminarAutomovil()
        {
            Console.Clear();
            Console.Write("ID: ");
            string? id = Console.ReadLine();
            concesionaria.EliminarAuto(id);
            Console.WriteLine("Automovil eliminado correctamente");
        }

        public void mostrarAutomoviles(){
            Console.Clear();
            concesionaria.MostrarAutos();

        }

        public void buscarAutomovil(){
            Console.Clear();
            Console.Write("ID: ");
            string? id = Console.ReadLine();
            concesionaria.MostrarAuto(id);

        }

    }
}