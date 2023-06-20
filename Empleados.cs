namespace EspacioEmpleados;

public enum cargos{ //  Cuando uso enum cada uno de estos valores se le asigna automaticamente un numero 
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }
    
public class Empleados{
    private string? nombre; //  Es importante poner el signo de pregunta para que el string pueda aceptar el NULL de manera adecuada 
    private string? apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private char genero;    
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private cargos cargo;
    //Todo lo que sea privado se recomiendo declararlo en minuscula
    //Importante: Seleccionar todo public class Empleados hacer clic en el foquito y
    //Encapsular campos y usar propiedad


    //Constructor empleados
    public Empleados(string? nombre, string? apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, int cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        switch (cargo)
                    {
                        case 0:
                            Cargo= cargos.Auxiliar;
                            break;
                        case 1:
                            Cargo= cargos.Administrativo;
                            break;
                        case 2:
                            Cargo= cargos.Ingeniero;
                            break;
                        case 3:
                            Cargo = cargos.Especialista;
                            break;
                        case 4:
                            Cargo = cargos.Investigador;
                            break;                    
                    }
    }
    
    //Importante: para obtener el constructor Empleados primero seleccionar todos los public de los empleados hacer clic en el foco y 
    //Generar el constructor empleados


    //Encapsulamiento de campos
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargos Cargo { get => cargo; set => cargo = value; }


    public DateTime ingresaFecha(){
        DateTime fecha;

        Console.WriteLine("Ingrese fecha de nacimiento");

        int.TryParse(ageInput, out var age)
         
        Console.Write("Anio: ");        int anio = Convert.ToInt16(Console.ReadLine());
        Console.Write("Mes: ");        int mes = Convert.ToInt16(Console.ReadLine());
        Console.Write("Dia: ");        int dia = Convert.ToInt16(Console.ReadLine());
        fecha = new DateTime(anio,mes,dia);
        
        return fecha;
    } 

    public int antiguedad(){
        int fechaActual = DateTime.Now.Year;

        return (fechaActual - FechaIngreso.Year);
    }
}



