namespace Ejercicio_Concesionaria;

 class Concesionaria{

    public List<Automovil> lista;
    public int Limite;
    public int Actual;

    public Concesionaria(int Limite)
    {
        lista = new List<Automovil>();
        this.Limite=Limite;
        this.Actual=0;
    }
    public void AgregarAuto(Automovil a)
    {
        if(a!=null && Actual!=Limite)
        {
        Automovil? autoEncontrado = lista.Find((b)=>b.ID==a.ID); //b es cada Auto en la Lista, y a es Auto nuevo
        if(autoEncontrado==null){
            lista.Add(a);
            Actual=Actual+1;
        }
        
        }
        
    }
    public void MostrarAuto(string ID)
    {
        Automovil autoEncontrado = lista.Find((a)=>a.ID==ID);
        if(autoEncontrado!=null){
            Console.WriteLine(autoEncontrado.ToString());
        }
    }
    public void EliminarAuto(String ID)
    {
        if(ID!="" && Actual!=0) // || lista.Contains(a)
        {
            Automovil? autoEncontrado = lista.Find((a)=>a.ID==ID); 
            /*Find((a)=>a.ID==ID) 
            function(Automovil a){
                if(a.ID==ID)
                    return a;
            }
            */
            if(autoEncontrado!=null)
            {
                lista.Remove(autoEncontrado);
                Actual=Actual-1;
            }
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
        Actual=0;
    }
    
}