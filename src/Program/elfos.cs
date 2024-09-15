using System.Collections;
using System.ComponentModel.Design;

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

    private bool vivo;
    public bool Vivo
    {
        get { return vivo; }
        set { vivo = value; }
    }
    
    public Elfos(string Name, string Genero, int Edad, int Hp, int Dmg)
    {
        this.Name = name;
        this.Genero = genero;   
        this.Edad = edad;
        this.Dmg = 50;
        this.Hp = 100;
        this.Item = item;
        this.Vivo = true;

    }

    public int valorAtaque()
    {
        return this.dmg;
    }

    public void valorArmor()
    {
        return this.Hp;
    }

    public void atacarEnano(Enano personaje)
    {   
        if (this.Vivo == True){
        
            personaje.RestarVida(this.Dmg);
        }
        else
        {
            Console.WriteLine("Estas Muerto.");
        }
    }

    public void atacarMago(Mago personaje)
    {   
        if (this.Vivo == True){
        
            personaje.RestarVida(this.Dmg);
        }
        else
        {
            Console.WriteLine("Estas Muerto.");
        }
    }

    public int cura()
    {
        return this.Hp += 25;
    }

    public void RestarVida(int Daño)
    {   
        if (this.Vivo == True){
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

    public void Additem(Item nombre)
    {
        if (this.Vivo == True){
        this.Item.Add(nombre);
        this.Dmg += nombre.Daño;
        this.Hp += nombre.Vida;
    }
        else
        {
            Console.WriteLine("Estas Muerto.");
        }

    public void DeleteItem(Item nombre)
    {
        if (this.Vivo == True){
            
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