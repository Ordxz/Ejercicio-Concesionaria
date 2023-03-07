namespace Ejercicio_Concesionaria;
class Automovil{
    public string ID;
    public string Marca;
    public string Modelo;
    public int Kilometraje;
    public double Precio;

    //Sobreescritura del metodo ToString
    public override string ToString()
    {
        return $"ID: {ID}, Marca; {Marca}, Modelo: {Modelo}, Kilometraje: {Kilometraje}, Precio: {Precio}";
    }
}