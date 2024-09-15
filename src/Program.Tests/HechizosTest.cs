using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Restaurant;

namespace Program.Tests;

[TestClass]
[TestSubject(typeof(Hechizos))]
public class HechizosTest
{

    [TestMethod]
    public void createHechizo()
    {
        string nombre = "Fire Ball";
        int daño = 10;

        Hechizos fireBall = new Hechizos(nombre, daño);
        
        Assert.AreEqual(nombre, fireBall.NombreHechizo);
        Assert.AreEqual(daño, fireBall.DañoHechizo);

    }
}