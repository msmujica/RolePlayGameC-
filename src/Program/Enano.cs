using System.Collections;
using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant;

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

    private bool estoyvivo;
    public bool EstoyVivo
    {
        get { return estoyvivo; }
        set { estoyvivo = value; }
    }
    
    public Enano(string Name, string Genero, int Edad)
    {
        this.Name = Name;
        this.Genero = Genero;
        this.Edad = Edad;
        this.hp = 100;
        this.dmg = 50;
        this.item = new ArrayList();
        this.EstoyVivo = true;
    }

    public int valorAtaque()
    {
        return this.Dmg;
    }

    public int valorArmadura()
    {
        return this.Hp;
    }

//    public void atacarMago(Mago personaje)
//    {
//        if (this.EstoyVivo == true){
//            personaje.RestarVida(this.Dmg);
//        }
//        else
//        {
//            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
//        }
//    }

//    public void atacarElfo(Elfo personaje)
//    {
//        if (this.EstoyVivo == true){
//            personaje.RestarVida(this.Dmg);
//        }
//        else
//        {
//            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
//        }    
//    }

    public void RestarVida(int Daño)
    {
        if (this.EstoyVivo == true){
            this.Hp -= Daño;
        if (this.Hp <= 0)
        {
            this.EstoyVivo = false;
        }
        
        }
        else
        {
            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
        }    
    }

    public void curar()
    { 
        if (this.EstoyVivo == true){

            this.Hp += 25;
        }
        else
        {
            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
        }    
    }
    public void AddItem(Item nombre)
    {
        if (this.EstoyVivo == true){

            this.Item.Add(nombre);
            this.Dmg += nombre.ValorAtaque;
            this.Hp += nombre.ValorDefensa;
        }
        else
        {
            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
        }
    }

    public void EliminarItem(Item nombre)
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
            Console.WriteLine("No puedes hacer ninguna accion tu personaje esta muerto");
        }
    }

    }
