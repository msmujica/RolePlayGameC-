using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;


[TestClass]
[TestSubject(typeof(Item))]
public class ItemTest
{

    [TestMethod]
    public void createItem()
    {
        string nombre = "El poder";
        int valorataque = 90;
        int valordefensa = 10;

        Item Elpoder = new Item(nombre, valorataque, valordefensa);
        
        Assert.AreEqual(nombre, Elpoder.Nombre);
        Assert.AreEqual(valorataque, Elpoder.ValorAtaque);
        Assert.AreEqual(valordefensa, Elpoder.ValorDefensa);

    }
}