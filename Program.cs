using System;

class Estudiante
{
    // Propiedades de la clase (campos)
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos;

    // 💡 CONSTRUCTOR: Este método se llama automáticamente cuando se crea un nuevo objeto Estudiante.
    // Su propósito es inicializar las propiedades y evitar la advertencia CS8618.
    public Estudiante() 
    {
        // Inicializamos los strings como vacíos
        Nombres = string.Empty; 
        Apellidos = string.Empty;
        Direccion = string.Empty;
        
        // Inicializamos el array de teléfonos como un array vacío
        Telefonos = new string[0]; 
        
        // La propiedad Id se inicializa por defecto a 0 (para los tipos int)
    }
    
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Direccion: " + Direccion);
        
        // Usamos String.Join para listar los números separados por coma
        Console.Write("TELÉFONOS: ");
        if (Telefonos.Length > 0)
        {
            Console.WriteLine(string.Join(", ", Telefonos));
        }
        else
        {
            Console.WriteLine("N/A");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. Instanciación: El constructor sin argumentos se llama aquí.
        Estudiante miEstudiante = new Estudiante();

        // 2. Asignación de Valores
        miEstudiante.Id = 2025001;
        miEstudiante.Nombres = "María";
        miEstudiante.Apellidos = "Rodríguez";
        miEstudiante.Direccion = "Avenida Central #456";
        miEstudiante.Telefonos = new string[] { "555-9876", "555-5432", "555-1122" };

        // 3. Ejecución
        miEstudiante.MostrarDatos();
    }
}
