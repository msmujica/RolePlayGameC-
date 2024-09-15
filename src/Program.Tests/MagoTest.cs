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
}