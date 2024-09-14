using System.Collections;
using System.Security.Cryptography;

namespace Program;

public class Enano
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
    public Enano(string Name, string Genero, int Edad, ArrayList Item)
    {
        this.Name = Name;
        this.Genero = Genero;
        this.Edad = Edad;
        this.hp = 100;
        this.dmg = 50;
        this.item = Item;
    }

    public int valorAtaque()
    {
        return this.Dmg;
    }

    public int valorArmadura()
    {
        return this.Hp;
    }

    public void atacarMago()
    {
        
    }

    public int curar()
    {
        return this.Hp += 25;
    }

    public void AddItem(Item nombre)
    {
        this.Item.Add(nombre);
        this.Dmg += nombre.Daño;
        this.Hp += nombre.Vida;
    }

    public void EliminarItem(Item nombre)
    {
        this.Item.Add(nombre);
        this.Dmg += nombre.Daño;
        this.Hp += nombre.Vida;
    }
}