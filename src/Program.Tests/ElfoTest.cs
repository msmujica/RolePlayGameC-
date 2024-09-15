using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
[TestSubject(typeof(Elfo))]
public class ElfoTest
{

    [TestMethod]
    public void TestCrearElfo_ValoresInicialesCorrectos()
    {
        Elfo elfo = new Elfo("Thorin", "Masculino", 195);
        Assert.AreEqual("Thorin", elfo.Name);
        Assert.AreEqual("Masculino", elfo.Genero);
        Assert.AreEqual(195, elfo.Edad);
        Assert.AreEqual(100, elfo.Hp); // Valor por defecto
        Assert.AreEqual(50, elfo.Dmg); // Valor por defecto
        Assert.IsTrue(elfo.Vivo); // El personaje debe estar vivo al inicio
        // Assert.IsEmpty(elfo.Item); // Los items deberían estar vacíos al inicio
        Assert.AreEqual(50, elfo.valorAtaque());
        Assert.AreEqual(100, elfo.valorArmor());
        elfo.RestarVida(30);
        Assert.AreEqual(70, elfo.Hp);
        Assert.IsTrue(elfo.Vivo);
        
    //           Mago mago = new Mago("Gandalf", "Masculino", 100, new ArrayList());
    //           elfo.RestarVida(150); // Elfo muerto
    //           elfo.atacarMago(mago);
    //           Assert.AreEqual(100, mago.Hp); // No se resta la vida del mago
        Enano enano = new Enano("Thorin", "Masculino", 195);
        elfo.atacarEnano(enano);
        Assert.AreEqual(50, enano.Hp); // Resta vida al elfo
        elfo.RestarVida(20); // HP actual = 50
        elfo.cura();
        Assert.AreEqual(75, elfo.Hp); // Aumenta en 25
        elfo.RestarVida(150); // Elfo muerto
        elfo.cura();
        Assert.AreEqual(-75, elfo.Hp); // No cura porque está muerto
        Item espada = new Item("Espada", 10, 5);
        Elfo elfo2 = new Elfo("Fujin", "Masculino", 195);

        elfo2.Additem(espada);
        Assert.AreEqual(60, elfo2.Dmg); // Aumenta dmg en 10
        Assert.AreEqual(105, elfo2.Hp); // Aumenta hp en 5
        elfo2.DeleteItem(espada);
        Assert.IsFalse(elfo2.Item.Contains(espada));
        Assert.AreEqual(50, elfo2.Dmg); // Vuelve al dmg original
        Assert.AreEqual(100, elfo2.Hp); // Vuelve al hp original
    }
}