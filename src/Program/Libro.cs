using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Text;
namespace Ucu.Poo.Roleplay;

public class Libros
{
    private string nombreLibro;
    private ArrayList hechizos;

    public string NombreLibro
    {
        get { return nombreLibro; }
        set { nombreLibro = value; }
    }

    public ArrayList setHechizos
    {
        get { return hechizos; }
        set { hechizos = value; }
    }

    public Libros(string nombreLibro)
    {
        this.NombreLibro = nombreLibro;
        this.hechizos = new ArrayList();
    }

    public string agregarHechizo(Hechizos ponerHechizo)
    {
        foreach (var g in this.hechizos)
        {
            if (((Hechizos)g).NombreHechizo == ponerHechizo.NombreHechizo)
            {
                Console.Write("Ya tiene el hechizo");
                return "Ya tiene el hechizo";
            }
            else
            {
                this.setHechizos.Add(ponerHechizo);
            }
        }


        return $"{ponerHechizo.NombreHechizo}";
    }

    public string eliminarHechizos(Hechizos sacarHechizo)
    {
        foreach (var g in this.hechizos)
        {
            if (((Hechizos)g).NombreHechizo == sacarHechizo.NombreHechizo)
            {
                this.setHechizos.Remove(sacarHechizo);
            }
            else
            {
                return "No puedes eliminar un hechizo que no existe";
            }
        }

        return "Eliminado";
    }

    public string mostrarHechizos()
    {
        StringBuilder mostrar = new StringBuilder();
        foreach (var hechizo in this.setHechizos)
        {
            mostrar.Append(hechizo);
        }
        return $"Los hechizos que tienes son {mostrar}";
    }
}