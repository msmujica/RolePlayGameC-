using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Ucu.Poo.Roleplay;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


[TestClass]
[TestSubject(typeof(Elfo))]
public class ElfoTest
{

    private Elfo elfo;

    public void SetUp()
    {
        elfo = new Elfo("Legolas", "Masculino", 1000);
    }

    [TestMethod]
    public void TestCrearElfo_ValoresInicialesCorrectos()
    {
        Assert.AreEqual("Legolas", elfo.Name);
        Assert.AreEqual("Masculino", elfo.Genero);
        Assert.AreEqual(195, elfo.Edad);
        Assert.AreEqual(100, elfo.Hp); // Valor por defecto
        Assert.AreEqual(50, elfo.Dmg); // Valor por defecto
        Assert.IsTrue(elfo.Vivo); // El personaje debe estar vivo al inicio
        // Assert.IsEmpty(enano.Item); // Los items deberían estar vacíos al inicio
    }

    [TestMethod]
    public void TestValorAtaque_RestornaValorCorrecto()
    {
        Assert.AreEqual(50, elfo.valorAtaque());
    }
    
    //       [Test]
    //       public void TestAtacarMago_EnanoMuerto_NoHaceDaño()
    //       {
    //           Mago mago = new Mago("Gandalf", "Masculino", 100, new ArrayList());
    //           enano.RestarVida(150); // Enano muerto
    //           enano.atacarMago(mago);
    //           Assert.AreEqual(100, mago.Hp); // No se resta la vida del mago
    //        }

//        [TestMethod]
//        public void TestAtacarEnano_EnanoVivo_HaceDaño()
//        {
//            Elfo elfo = new Elfo("Legolas", "Masculino", 100, new ArrayList());
//            enano.atacarElfo(elfo);
//            Assert.AreEqual(50, elfo.Hp); // Resta vida al elfo
//        }

    [TestMethod]
    public void TestValorArmadura_RetornaValorCorrecto()
    {
        Assert.AreEqual(100, elfo.valorArmor());
    }

    [TestMethod]
    public void TestRestarVida_EnanoSigueVivo()
    {
        elfo.RestarVida(30);
        Assert.AreEqual(70, elfo.Hp);
        Assert.IsTrue(elfo.Vivo);
    }

    [TestMethod]
    public void TestRestarVida_EnanoMuere()
    {
        elfo.RestarVida(120); // Más que su HP
        Assert.AreEqual(-20, elfo.Hp);
        Assert.IsFalse(elfo.Vivo);
    }

    [TestMethod]
    public void TestCurar_ElfoVivo_AumentaHP()
    {
        elfo.RestarVida(50); // HP actual = 50
        elfo.cura();
        Assert.AreEqual(75, elfo.Hp); // Aumenta en 25
    }

    [TestMethod]
    public void TestCurar_ElfoMuerto_NoCura()
    {
        elfo.RestarVida(150); // Enano muerto
        elfo.cura();
        Assert.AreEqual(-50, elfo.Hp); // No cura porque está muerto
    }

    [TestMethod]
    public void TestAddItem_AumentaDmgYHp()
    {
        Item espada = new Item("Espada", 10, 5);
        elfo.Additem(espada);
        //     Assert.Contains(espada, enano.Item);
        Assert.AreEqual(60, elfo.Dmg); // Aumenta dmg en 10
        Assert.AreEqual(105, elfo.Hp); // Aumenta hp en 5
    }

    [TestMethod]
    public void TestEliminarItem_DisminuyeDmgYHp()
    {
        Item escudo = new Item("Escudo", 5, 10);
        elfo.Additem(escudo);
        elfo.DeleteItem(escudo);
        Assert.IsFalse(elfo.Item.Contains(escudo));
        Assert.AreEqual(50, elfo.Dmg); // Vuelve al dmg original
        Assert.AreEqual(100, elfo.Hp); // Vuelve al hp original

    }
}    
    

    
    

    
    
    