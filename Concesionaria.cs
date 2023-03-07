namespace Ejercicio_Concesionaria;

class Concesionaria{

    public List<Automovil> lista;
    public int Limite;
    public int Actual;

    Concesionaria(int Limite)
    {
        lista = new List<Automovil>();
        this.Limite=Limite;
        this.Actual=0;
    }
    public void AgregarAuto(Automovil a)
    {
        if(Actual<=Limite)
        {
        lista.Add(a);
        Actual=Actual+1;
        }
        
    }
    
    public void MostrarAuto(Automovil a)
    {
        Console.WriteLine(a.ToString());
    }
    public void EliminarAuto(Automovil a)
    {
        if(Actual>0)
        {
            lista.Remove(a);
            Actual=Actual-1;
        }
    }
    public void MostrarAutos()
    {
        foreach (Automovil item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }
    public void VaciarConcesionaria()
    {
        lista.Clear();
    }
    
}