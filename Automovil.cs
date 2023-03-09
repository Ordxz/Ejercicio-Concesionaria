namespace Ejercicio_Concesionaria;
class Automovil{
    public string ID;
    public string Marca;
    public string Modelo;
    public int Kilometraje;
    public double Precio;

    public Automovil(string iD, string marca, string modelo, int kilometraje, double precio)
    {
        ID = iD;
        Marca = marca;
        Modelo = modelo;
        Kilometraje = kilometraje;
        Precio = precio;
    }

    //Sobreescritura del metodo ToString.
    public override string ToString()
    {
        //Puede ser con this. o solo con el nombre de la variable.
        return $"ID: {this.ID}, Marca; {this.Marca}, Modelo: {this.Modelo}, Kilometraje: {this.Kilometraje}, Precio: {this.Precio}";
    }
}