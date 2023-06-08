namespace EspacioEmpleados;

public enum cargos{
        Auxiliar;
        Administrativo;
        Ingeniero;
        Especialista;
        Investigador;
    }
    
public class Empleados{
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiento;
    private char EstadoCivil;
    private char Genero;    
    private string FechaIngreso;
    private double SueldoBasico;
    private cargos Cargo;



    public Empleados(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, string fechaIngreso, double sueldoBasico, cargos cargo)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }
}



