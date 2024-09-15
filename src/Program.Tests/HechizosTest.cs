using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Roleplay;

[TestClass]
public class HechizosTests
{
    // Prueba que se inicialicen correctamente los valores del hechizo.
    [TestMethod]
    public void TestInicializacionHechizo()
    {
        // Crea un hechizo con nombre y daño específicos
        Hechizos hechizo = new Hechizos("Bola de Fuego", 50);

        // Verifica que el nombre del hechizo sea correcto
        Assert.AreEqual("Bola de Fuego", hechizo.NombreHechizo);

        // Verifica que el daño del hechizo sea correcto
        Assert.AreEqual(50, hechizo.DañoHechizo);
    }

    // Prueba la asignación de un nuevo nombre al hechizo.
    [TestMethod]
    public void TestAsignarNombreHechizo()
    {
        Hechizos hechizo = new Hechizos("Bola de Fuego", 50);

        // Cambia el nombre del hechizo
        hechizo.NombreHechizo = "Rayo Congelante";

        // Verifica que el nuevo nombre sea correcto
        Assert.AreEqual("Rayo Congelante", hechizo.NombreHechizo);
    }

    // Prueba la asignación de un nuevo valor de daño al hechizo.
    [TestMethod]
    public void TestAsignarDañoHechizo()
    {
        Hechizos hechizo = new Hechizos("Bola de Fuego", 50);

        // Cambia el valor del daño del hechizo
        hechizo.DañoHechizo = 75;

        // Verifica que el nuevo valor del daño sea correcto
        Assert.AreEqual(75, hechizo.DañoHechizo);
    }

    // Prueba que el daño del hechizo no sea negativo.
    [TestMethod]
    public void TestDañoHechizoNoNegativo()
    {
        Hechizos hechizo = new Hechizos("Bola de Fuego", -10);

        // El daño del hechizo no debe ser negativo, se debería modificar la implementación
        // para evitar valores negativos. Aquí verificamos que el valor sea ajustado a cero
        // o que el programa maneje el caso correctamente.
        Assert.IsTrue(hechizo.DañoHechizo >= 0, "El daño del hechizo no puede ser negativo.");
    }
}