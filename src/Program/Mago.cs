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

    private bool estoyvivo;
    public bool EstoyVivo
    {
        get { return estoyvivo; }
        set { estoyvivo = value; }
    }
    
    public Mago(string Name, string Genero, int Edad, Libros grimorio)
    {
        this.Name = Name;
        this.Genero = Genero;   
        this.Edad = Edad;
        this.Dmg = 50;
        this.Hp = 100;
        this.Item = new ArrayList();
        this.EstoyVivo = true;

        this.Item.Add(grimorio);
    }

    public int ValorAtaque()
    {
        return this.dmg;
    }

    public int ValorArmor()
    {
        return this.Hp;
    }

    public void AtacarEnano(Enano personaje, Hechizos hechiz)
    {
        if (this.EstoyVivo == true)
        {
            foreach (var item in this.Item)
            {
                foreach (var h in ((Libros)item).SetHechizos)
                {
                    if (hechiz.NombreHechizo == h)
                    {
                        personaje.RestarVida(hechiz.DañoHechizo + this.Dmg);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Estas Muerto.");
        }
    }
    
    public void AtacarElfo(Elfo personaje)
   {
      if (this.EstoyVivo == true){ 
          
          personaje.RestarVida(this.Dmg);
      }
      else
      {
          Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
      }    
   }
    
    public void Heal()
    {
        this.Hp += 25;
    }

    public void RestarVida(int Daño)
    {
        if (this.EstoyVivo == true)
        {
            this.Hp -= Daño;
            if (this.Hp <= 0)
            {
                this.EstoyVivo = false;
            }
            else
            {
                Console.WriteLine("Estas Muerto.");
            }
        }
    }

    public void Additem(Item nombre)
    {
        if (this.EstoyVivo == true)
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
        if (this.EstoyVivo == true){
            
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