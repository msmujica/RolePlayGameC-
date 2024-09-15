using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ucu.Poo.Restaurant;

namespace Program.Tests;

[TestClass]
[TestSubject(typeof(Libros))]
public class LibroTest
{

    [TestMethod]
    public void createLibro()
    {
        string nombre = "Grimorio de 5 Trevols";
        Libros book = new Libros(nombre);

        Assert.AreEqual(nombre, book.NombreLibro);
    }

    [TestMethod]
    public void agregarHechizoTest()
    {
        string nombre = "Grimorio de 5 Trevols";
        Libros book = new Libros(nombre);

        Hechizos hechizos = new Hechizos("FireBall", 10);

        string resultado = book.agregarHechizo(hechizos);

        Assert.AreEqual("FireBall", resultado);
    }

    [TestMethod]
    public void eliminarHechizoTest()
    {
        string nombre = "Grimorio de 5 Trevols";
        Libros book = new Libros(nombre);

        Hechizos hechizos = new Hechizos("FireBall", 10);

        string resutlado = book.eliminarHechizos(hechizos);

        Assert.AreEqual("Eliminado", resutlado);
    }
    
    [TestMethod]
    public void mostrarHechizoTest()
    {
        string nombre = "Grimorio de 5 Trevols";
        Libros book = new Libros(nombre);

        Assert.AreEqual("Los hechizos que tienes son ", book.mostrarHechizos());
    }
}