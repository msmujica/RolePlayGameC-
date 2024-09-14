using System.Collections;

namespace Program;

public class elfos
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
    public Elfos(string Name, string Genero, int Edad, int Hp, int Dmg, ArrayList item)
    {
        this.Name = name;
        this.Genero = genero;   
        this.Edad = edad;
        this.Dmg = 50;
        this.Hp = 100;
        this.Item = item;
        
    }

    public int valorAtaque()
    {
        return this.dmg;
    }

    public void valorArmor()
    {
        return 
    }

    public int atacarElfo()
    {
        
    }

    public int cura()
    {
        return this.Hp += 25;
    }

    public void Additem(Item nombre)
    {
        this.Item.Add(nombre);
        this.Dmg += nombre.Daño;
        this.Hp += nombre.Vida;
    }

    public void DeleteItem(Item nombre)
    {
        
    }
}