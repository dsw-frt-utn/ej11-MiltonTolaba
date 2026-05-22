namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<string> alumnos = new List<string>();
    public void AgregarAlumno(string alumno)
    {
        alumnos.Add(alumno);
    }
    public List<string> RetornarAlumnos()
    {
        return alumnos;
    }
    public bool BuscarAlumno(string nombre)
    {
        return alumnos.Contains(nombre);
    }
    public void EliminarAlumno(string alumno)
    {
        alumnos.Remove(alumno);
    }
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        alumnos.RemoveAt(posicion);
    }
}


