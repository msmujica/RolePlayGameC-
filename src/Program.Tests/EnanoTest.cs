using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
[TestSubject(typeof(Enano))]
public class EnanoTest
{
    [TestMethod]
    public void testFuncionalidadesEnanos()
    {
        Enano enano = new Enano("Thorin", "Masculino", 195);
        Assert.AreEqual("Thorin", enano.Name);
        Assert.AreEqual("Masculino", enano.Genero);
        Assert.AreEqual(195, enano.Edad);
        Assert.AreEqual(100, enano.Hp); // Valor por defecto
        Assert.AreEqual(50, enano.Dmg); // Valor por defecto
        Assert.IsTrue(enano.EstoyVivo); // El personaje debe estar vivo al inicio
        // Assert.IsEmpty(enano.Item); // Los items deberían estar vacíos al inicio
        Assert.AreEqual(50, enano.valorAtaque());
        Assert.AreEqual(100, enano.valorArmadura());
        enano.RestarVida(30);
        Assert.AreEqual(70, enano.Hp);
        Assert.IsTrue(enano.EstoyVivo);
        
    //           Mago mago = new Mago("Gandalf", "Masculino", 100, new ArrayList());
    //           enano.RestarVida(150); // Enano muerto
    //           enano.atacarMago(mago);
    //           Assert.AreEqual(100, mago.Hp); // No se resta la vida del mago
        Elfo elfo = new Elfo("Legolas", "Masculino", 100);
        enano.atacarElfo(elfo);
        Assert.AreEqual(50, elfo.Hp); // Resta vida al elfo
        enano.RestarVida(20); // HP actual = 15
        enano.curar();
        Assert.AreEqual(75, enano.Hp); // Aumenta en 25
        enano.RestarVida(150); // Enano muerto
        enano.curar();
        Assert.AreEqual(-75, enano.Hp); // No cura porque está muerto
        Item espada = new Item("Espada", 10, 5);
        Enano ENano = new Enano("Fujin", "Masculino", 195);

        ENano.AddItem(espada);
        Assert.AreEqual(60, ENano.Dmg); // Aumenta dmg en 10
        Assert.AreEqual(105, ENano.Hp); // Aumenta hp en 5
        ENano.EliminarItem(espada);
        Assert.IsFalse(ENano.Item.Contains(espada));
        Assert.AreEqual(50, ENano.Dmg); // Vuelve al dmg original
        Assert.AreEqual(100, ENano.Hp); // Vuelve al hp original
    }
}