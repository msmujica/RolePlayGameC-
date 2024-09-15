using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
[TestSubject(typeof(Mago))]
public class MagoTest
{
    [TestMethod]
    public void testAtacarEnano()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);

        Hechizos FireBall = new Hechizos("FireBall", 20);
        Libros grimorio = new Libros("5 trvols");
        grimorio.AddHechizo(FireBall);
        
        
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);
        
        mago.AtacarEnano(enano, FireBall);

        Assert.AreEqual(70, enano.Hp);
    }
    
    [TestMethod]
    public void testAtacarElfo()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);

        Hechizos FireBall = new Hechizos("FireBall", 20);
        Libros grimorio = new Libros("5 trvols");
        grimorio.AddHechizo(FireBall);
        
        
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);
        
        mago.AtacarElfo(elfo, FireBall);

        Assert.AreEqual(70, elfo.Hp);
    }

    [TestMethod]
    public void testValorAtaque()
    {
        Libros grimorio = new Libros("5 trvols");
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);

        int valorEsperado = 10;
        
        Assert.AreEqual(valorEsperado, mago.ValorAtaque());
    }

    [TestMethod]
    public void testValorAramadura()
    {
        Libros grimorio = new Libros("5 trvols");
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);

        int valorEsperado = 100;
        
        Assert.AreEqual(valorEsperado, mago.ValorArmor());
    }

    [TestMethod]
    public void testHeal()
    {
        Libros grimorio = new Libros("5 trvols");
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);

        int valorEsperado = 100;
        mago.Heal();
        
        Assert.AreEqual(valorEsperado, mago.Hp);
    }

    [TestMethod]
    public void testRestarVida()
    {
        Libros grimorio = new Libros("5 trvols");
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);

        int valorEsperado = 80;
        mago.RestarVida(20);
        
        Assert.AreEqual(valorEsperado, mago.Hp);
    }

    [TestMethod]
    public void testAddItem()
    {
        Libros grimorio = new Libros("5 trvols");
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);
        Item espada = new Item("Espada", 10, 5);
        
        mago.Additem(espada);
        Assert.AreEqual(105, mago.Hp);
        Assert.AreEqual(15, mago.Dmg);
    }

    [TestMethod]
    public void testDeleteItem()
    {
        Libros grimorio = new Libros("5 trvols");
        Mago mago = new Mago("Gandalf", "Masculino", 100, grimorio);
        Item espada = new Item("Espada", 10, 5);
        
        mago.Additem(espada);
        mago.DeleteItem(espada);
        Assert.AreEqual(100, mago.Hp);
        Assert.AreEqual(10, mago.Dmg);
    }
}