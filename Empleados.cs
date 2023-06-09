using System;

namespace EspacioEmpleados;

public enum cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }
    
public class Empleados{
    private string? Nombre;
    private string? Apellido;
    private DateTime FechaNacimiento;
    private char EstadoCivil;
    private char Genero;    
    private DateTime FechaIngreso;
    private double SueldoBasico;
    private cargos Cargo;



    public Empleados(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, cargos cargo)
    {
        Nombre1 = nombre;
        Apellido1 = apellido;
        FechaNacimiento1 = fechaNacimiento;
        EstadoCivil1 = estadoCivil;
        Genero1 = genero;
        FechaIngreso1 = fechaIngreso;
        SueldoBasico1 = sueldoBasico;
        Cargo1 = cargo;
    }

    public string? Nombre1 { get => Nombre; set => Nombre = value; }
    public string? Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
    public char EstadoCivil1 { get => EstadoCivil; set => EstadoCivil = value; }
    public char Genero1 { get => Genero; set => Genero = value; }
    public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
    public double SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value; }
    public cargos Cargo1 { get => Cargo; set => Cargo = value; }


    public int antiguedad(){
        int fechaActual = DateTime.Now.Year;

        return (fechaActual - FechaIngreso1.Year);
    }
}



