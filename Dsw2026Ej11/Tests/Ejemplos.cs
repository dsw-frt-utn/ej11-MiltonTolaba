using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList caso = new CasoList();

        caso.AgregarAlumno("Juan");
        caso.AgregarAlumno("Milton");
        caso.AgregarAlumno("Manolo");

        Console.WriteLine("=== LISTA DE ALUMNOS ===");

        foreach (string alumno in caso.RetornarAlumnos())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\n=== BUSCAR MILTON ===");

        if (caso.BuscarAlumno("Milton"))
        {
            Console.WriteLine("Milton existe");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n=== BUSCAR CARLOS ===");

        if (caso.BuscarAlumno("Carlos"))
        {
            Console.WriteLine("Carlos existe");
        }
        else
        {
            Console.WriteLine("No existe");
        }

        caso.EliminarAlumno("Juan");

        Console.WriteLine("\n=== ELIMINAR JUAN ===");

        foreach (string alumno in caso.RetornarAlumnos())
        {
            Console.WriteLine(alumno);
        }

        caso.EliminarAlumnoEnPosicion(0);

        Console.WriteLine("\n=== ELIMINAR PRIMER ELEMENTO ===");

        foreach (string alumno in caso.RetornarAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();

        caso.AgregarAlumno(57400, "Juan");
        caso.AgregarAlumno(57874, "Milton");
        caso.AgregarAlumno(57787, "Manolo");

        Console.WriteLine("\n=== DICCIONARIO DE ALUMNOS ===");

        foreach (var alumno in caso.RetornarAlumnos())
        {
            Console.WriteLine($"Legajo: {alumno.Key} - Nombre: {alumno.Value}");
        }

        Console.WriteLine("\n=== BUSCAR LEGAJO 57874 ===");

        if (caso.RetornarAlumnos().ContainsKey(57874))
        {
            Console.WriteLine(caso.BuscarAlumno(57874));
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\n=== BUSCAR LEGAJO 58400 ===");

        if (caso.RetornarAlumnos().ContainsKey(58400))
        {
            Console.WriteLine(caso.BuscarAlumno(58400));
        }
        else
        {
            Console.WriteLine("No existe");
        }

        caso.EliminarAlumnos(57400);

        Console.WriteLine("\n=== ELIMINAR LEGAJO 57400 ===");

        foreach (var alumno in caso.RetornarAlumnos())
        {
            Console.WriteLine($"Legajo: {alumno.Key} - Nombre: {alumno.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq caso = new CasoLinq();

        Console.WriteLine("=== PRIMER LIBRO ===");
        Console.WriteLine(caso.GetPrimero().Titulo);

        Console.WriteLine("\n=== ULTIMO LIBRO ===");
        Console.WriteLine(caso.GetUltimo().Titulo);

        Console.WriteLine("\n=== TOTAL PRECIOS ===");
        Console.WriteLine(caso.GetTotalPrecios());

        Console.WriteLine("\n=== PROMEDIO PRECIOS ===");
        Console.WriteLine(caso.GetPromedioPrecios());

        Console.WriteLine("\n=== LIBROS CON ID > 15 ===");

        foreach (Libro libro in caso.GetListById())
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine("\n=== LIBROS FORMATEADOS ===");

        foreach (string libro in caso.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\n=== LIBRO MAS CARO ===");
        Console.WriteLine(caso.GetMayorPrecio().Titulo);

        Console.WriteLine("\n=== LIBRO MAS BARATO ===");
        Console.WriteLine(caso.GetMenorPrecio().Titulo);

        Console.WriteLine("\n=== LIBROS MAYOR AL PROMEDIO ===");

        foreach (Libro libro in caso.GetMayorPromedio())
        {
            Console.WriteLine(libro.Titulo);
        }

        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        foreach (Libro libro in caso.GetLibrosOrdenados())
        {
            Console.WriteLine(libro.Titulo);
        }
    }
}
