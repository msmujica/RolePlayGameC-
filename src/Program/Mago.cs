using System.Collections;


namespace Ucu.Poo.Roleplay;


public class Mago
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string genero;
    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }
    private int edad;
    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }
    private int hp;
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    private int dmg;
    
    public int Dmg
    {
        get { return dmg; }
        set { dmg = value; }
    }
    
    private ArrayList item;
    public ArrayList Item
    {
        get { return item; }
        set { item = value; }
    }

    private bool vivo;
    public bool Vivo
    {
        get { return vivo; }
        set { vivo = value; }
    }
    
    public Mago(string Name, string Genero, int Edad, Libros grimorio)
    {
        this.Name = Name;
        this.Genero = Genero;   
        this.Edad = Edad;
        this.Dmg = 10;
        this.Hp = 100;
        this.Item = new ArrayList();
        this.Vivo = true;

        this.Item.Add(grimorio);
    }

    public int ValorAtaque()
    {
        return this.Dmg;
    }

    public int ValorArmor()
    {
        return this.Hp;
    }

    public void AtacarEnano(Enano personaje, Hechizos hechiz)
    {
        if (this.Vivo)
        {
            foreach (var grimorio in this.Item)
            {
                if (grimorio is Libros libros)
                {
                    foreach (var h in libros.SetHechizos)
                    {
                        if (hechiz.NombreHechizo == ((Hechizos)h).NombreHechizo)
                        {
                            int dañoTotal = ((Hechizos)h).DañoHechizo + this.Dmg;
                            personaje.RestarVida(dañoTotal);
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("El hechizo no está en el grimorio.");
        }
        else
        {
            Console.WriteLine("El mago está muerto y no puede atacar.");
        }
    }
    
    public void AtacarElfo(Elfo personaje, Hechizos hechiz)
   {
       if (this.Vivo)
       {
           foreach (var grimorio in this.Item)
           {
               if (grimorio is Libros libros)
               {
                   foreach (var h in libros.SetHechizos)
                   {
                       if (hechiz.NombreHechizo == ((Hechizos)h).NombreHechizo)
                       {
                           int dañoTotal = ((Hechizos)h).DañoHechizo + this.Dmg;
                           personaje.RestarVida(dañoTotal);
                           return;
                       }
                   }
               }
           }
           Console.WriteLine("El hechizo no está en el grimorio.");
       }
       else
       {
           Console.WriteLine("El mago está muerto y no puede atacar.");
       }
   }
    
    public void Heal()
    {
        if (this.Vivo == true){
            this.Hp += 25;
            if (this.Hp > 100)
            {
                this.Hp = 100;
            }
        }
        else
        {
            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
        }    
    }

    public void RestarVida(int Daño)
    {
        if (this.Vivo == true)
        {
            this.Hp -= Daño;
            if (this.Hp <= 0)
            {
                this.Vivo = false;
            }
            else
            {
                Console.WriteLine("Estas Muerto.");
            }
        }
    }

    public void Additem(Item nombre)
    {
        if (this.Vivo == true)
        {
            if(this.Item.Count < 2){
                this.Item.Add(nombre);
                this.Dmg += nombre.ValorAtaque;
                this.Hp += nombre.ValorDefensa;
            }
        }
        else
        {
            Console.WriteLine("Estas Muerto.");
        }
    }

    public void DeleteItem(Item nombre)
    {
        if (this.Vivo == true){
            
            if (this.Item.Contains(nombre))
            {
                this.Item.Remove(nombre);
                this.Dmg -= nombre.ValorAtaque;
                this.Hp -= nombre.ValorDefensa;
            }
            else
            { 
                Console.WriteLine("No puedes eliminar un item que no existe");
            }
        }
        else
        {
            Console.WriteLine("Estas Muerto.");

        }
    }
}