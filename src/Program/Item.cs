using System;
namespace Ucu.Poo.Roleplay;

public class Item
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private int valorataque;
    public int ValorAtaque
    {
        get { return valorataque; }
		set { valorataque = value; }
    }

    private int valordefensa;
    public int ValorDefensa
    {
        get { return valordefensa; }
        set { valordefensa = value; }
    }
	
	public Item(string nombre, int valorataque, int valordefensa)
	{
		this.Nombre = nombre;
		this.ValorAtaque = valorataque;
		this.ValorDefensa = valordefensa;
	}
}

