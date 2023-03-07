namespace Ejercicio_Concesionaria;

class Concesionaria{

    public List<string> lista;
    public int Limite;
    public int Actual;

    Concesionaria(int Limite)
    {
        lista = new List<string>();
        this.Limite=Limite;
        Actual=0;
    }


}