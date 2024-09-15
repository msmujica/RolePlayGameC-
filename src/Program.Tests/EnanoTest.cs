using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Restaurant;



[TestClass]
[TestSubject(typeof(Enano))]
public class EnanosTest
{

    private Enano enano;

    public void SetUp()
    {
        enano = new Enano("Thorin", "Masculino", 195);
    }

    [TestMethod]
    public void TestCrearEnano_ValoresInicialesCorrectos()
    {
        Assert.AreEqual("Thorin", enano.Name);
        Assert.AreEqual("Masculino", enano.Genero);
        Assert.AreEqual(195, enano.Edad);
        Assert.AreEqual(100, enano.Hp); // Valor por defecto
        Assert.AreEqual(50, enano.Dmg); // Valor por defecto
        Assert.IsTrue(enano.EstoyVivo); // El personaje debe estar vivo al inicio
        // Assert.IsEmpty(enano.Item); // Los items deberían estar vacíos al inicio
    }

    [TestMethod]
    public void TestValorAtaque_RetornaValorCorrecto()
    {
        Assert.AreEqual(50, enano.valorAtaque());
    }

    [TestMethod]
    public void TestValorArmadura_RetornaValorCorrecto()
    {
        Assert.AreEqual(100, enano.valorArmadura());
    }

    [TestMethod]
    public void TestRestarVida_EnanoSigueVivo()
    {
        enano.RestarVida(30);
        Assert.AreEqual(70, enano.Hp);
        Assert.IsTrue(enano.EstoyVivo);
    }

    [TestMethod]
    public void TestRestarVida_EnanoMuere()
    {
        enano.RestarVida(120); // Más que su HP
        Assert.AreEqual(-20, enano.Hp);
        Assert.IsFalse(enano.EstoyVivo);
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
//        public void TestAtacarElfo_EnanoVivo_HaceDaño()
//        {
//            Elfo elfo = new Elfo("Legolas", "Masculino", 100, new ArrayList());
//            enano.atacarElfo(elfo);
//            Assert.AreEqual(50, elfo.Hp); // Resta vida al elfo
//        }

    [TestMethod]
    public void TestCurar_EnanoVivo_AumentaHp()
    {
        enano.RestarVida(50); // HP actual = 50
        enano.curar();
        Assert.AreEqual(75, enano.Hp); // Aumenta en 25
    }

    [TestMethod]
    public void TestCurar_EnanoMuerto_NoCura()
    {
        enano.RestarVida(150); // Enano muerto
        enano.curar();
        Assert.AreEqual(-50, enano.Hp); // No cura porque está muerto
    }

    [TestMethod]
    public void TestAddItem_AumentaDmgYHp()
    {
        Item espada = new Item("Espada", 10, 5);
        enano.AddItem(espada);
        //     Assert.Contains(espada, enano.Item);
        Assert.AreEqual(60, enano.Dmg); // Aumenta dmg en 10
        Assert.AreEqual(105, enano.Hp); // Aumenta hp en 5
    }

    [TestMethod]
    public void TestEliminarItem_DisminuyeDmgYHp()
    {
        Item escudo = new Item("Escudo", 5, 10);
        enano.AddItem(escudo);
        enano.EliminarItem(escudo);
        Assert.IsFalse(enano.Item.Contains(escudo));
        Assert.AreEqual(50, enano.Dmg); // Vuelve al dmg original
        Assert.AreEqual(100, enano.Hp); // Vuelve al hp original

    }
}