// using EspacioCalculadora;

// Calculadora cal=new Calculadora(); //renombre de biblioteca?
// int a, b, op;
// Console.Clear();
// do{
//     Console.WriteLine("\n\n\nCalculadora\n");
//     Console.WriteLine("1-Sumar");
//     Console.WriteLine("2-Restar");
//     Console.WriteLine("3-Multiplicar");
//     Console.WriteLine("4-Dividir");
//     Console.WriteLine("5-Salir\n");
//     op=ingresarEntero();
//     switch (op)
//     {
//          case 1:
//             Console.WriteLine("Ingrese primer valor");
//             a=ingresarEntero();
//             Console.WriteLine("Ingrese segundo valor");
//             b=ingresarEntero();
//             if(a!=-999 && b!=-999){
//                 cal.Sumar(a);
//                 cal.Sumar(b);
//                 Console.WriteLine("\n"+a+"+"+b+"="+cal.Resultado+"\n");
//                 cal.Limpiar();
//             }   else{
//                 Console.WriteLine("Error");
//             }
//             Console.Write("Presione una tecla para continuar");
//             cal.Limpiar();            
//             Console.ReadKey();

//            break;
//         case 2:
//             Console.WriteLine("Ingrese primer valor");
//             a=ingresarEntero();
//             Console.WriteLine("Ingrese segundo valor");
//             b=ingresarEntero();
//             if(a!=-999 && b!=-999){
//                 cal.Sumar(a);
//                 cal.Restar(b);
//                 Console.WriteLine("\n"+a+"-"+b+"="+cal.Resultado+"\n");
//             }
//             cal.Limpiar();
//             Console.Write("Presione una tecla para continuar");
//             Console.ReadKey();

//             break;
//         case 3:
//             Console.WriteLine("Ingrese primer valor");
//             a=ingresarEntero();
//             Console.WriteLine("Ingrese segundo valor");
//             b=ingresarEntero();
//             if(a!=-999 && b!=-999){
//                 cal.Sumar(a);
//                 cal.Multiplicar(b);
//                 Console.WriteLine("\n"+a+"*"+b+"="+cal.Resultado+"\n");
//             }
//             cal.Limpiar();
//             Console.Write("Presione una tecla para continuar");
//             Console.ReadKey();
//             break;
//         case 4:
//             Console.WriteLine("Ingrese primer valor");
//             a=ingresarEntero();
//             Console.WriteLine("Ingrese segundo valor");
//             b=ingresarEntero();
//             if(a!=-999 && b!=-999 && b!=0){
//                 cal.Sumar(a);
//                 cal.Dividir(b);
//                 Console.WriteLine("\n"+a+"*"+b+"="+cal.Resultado+"\n");
//             }
//             cal.Limpiar();
//             Console.Write("Presione una tecla para continuar");
//             Console.ReadKey();
//             break;
//         case 5:
//             break;
//     }
// }while(op!=5);

// return 0;


// int ingresarEntero(){
//     int num;
//     if(int.TryParse(Console.ReadLine(), out num)){
//         return num;
//     } else{
//         return -999;
//     }
// }

// using EspacioEmpleados;

// Console.Write("Ingrese el nombre: ");           string nombre = Console.ReadLine().ToString();
// Console.Write("Ingrese el apellido: ");         string apellido = Console.ReadLine().ToString();
// Console.Write("\nIngrese fecha de nacimiento\n");         var fechaNacimiento= ingresaFecha();
// Console.Write("\nIngrese estado civil (s/c): ");         var estadoCivil= Convert.ToChar(Console.ReadLine().ToString());
// Console.Write("\nIngrese genero (m/f): ");          var genero= Convert.ToChar(Console.ReadLine().ToString());
// Console.Write("\nIngrese fecha de ingreso\n");         var fechaIngreso= ingresaFecha();
// Console.Write("\nIngrese sueldo basico: ");         var sueldoBasico= ingresaReal(); //Convert.ToDouble(Console.ReadLine());
// Console.Write("\nIngrese cargo: \n");         var cargo= ingresaCargo();

// Empleados empleado = new Empleados(nombre, apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

// Console.WriteLine("\nDatos de empleado\n");
// Console.WriteLine("Nombre: "+empleado.Nombre);
// Console.WriteLine("Apellido: "+empleado.Apellido);
// Console.WriteLine("Fecha de Nacimiento: "+empleado.FechaNacimiento);
// Console.WriteLine("Estado Civil: "+empleado.EstadoCivil);
// Console.WriteLine("Genero: "+empleado.Genero);
// Console.WriteLine("Fecha de Ingreso: "+empleado.FechaIngreso);
// Console.WriteLine("Sueldo basico: "+empleado.SueldoBasico);
// Console.WriteLine("Cargo: "+empleado.Cargo);
// Console.WriteLine("\n\n");
// Console.WriteLine("Antiguedad del empleado: "+empleado.antiguedad());
// Console.WriteLine("Edad del empleado: "+empleado.edad());
// Console.WriteLine("Años para jubilarse: "+empleado.jubilacion());
// Console.WriteLine("Salario: "+empleado.salario());



using EspacioEmpleados;

 Empleados[] empleados;
 empleados = new Empleados[3];
//Empleados[] empleados=new Empleados[3];


for (int i = 0; i < 3; i++)
{
Console.Write("\n\nEmpleado:"+i+"\n");
Console.Write("Ingrese el nombre: ");           string nombre = Console.ReadLine().ToString();
Console.Write("Ingrese el apellido: ");         string apellido = Console.ReadLine().ToString();
Console.Write("Ingrese fecha de nacimiento\n");         var fechaNacimiento= ingresaFecha();
Console.Write("Ingrese estado civil (s/c): ");         var estadoCivil= Convert.ToChar(Console.ReadLine().ToString());
Console.Write("Ingrese genero (m/f): ");          var genero= Convert.ToChar(Console.ReadLine().ToString());
Console.Write("Ingrese fecha de ingreso\n");         var fechaIngreso= ingresaFecha();
Console.Write("Ingrese sueldo basico: ");         var sueldoBasico= ingresaReal(); //Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese cargo: \n");         var cargo= ingresaCargo();

Empleados empleado = new Empleados(nombre, apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);
empleados[i]= empleado;
}

Console.WriteLine("\nDatos de empleado\n");

for (int i = 0; i < 3; i++)
{
Console.Write("\n\nEmpleado: "+i+"\n");
Console.WriteLine("Nombre: "+empleados[i].Nombre);
Console.WriteLine("Apellido: "+empleados[i].Apellido);
Console.WriteLine("Fecha de Nacimiento: "+empleados[i].FechaNacimiento);
Console.WriteLine("Estado Civil: "+empleados[i].EstadoCivil);
Console.WriteLine("Genero: "+empleados[i].Genero);
Console.WriteLine("Fecha de Ingreso: "+empleados[i].FechaIngreso);
Console.WriteLine("Sueldo basico: "+empleados[i].SueldoBasico);
Console.WriteLine("Cargo: "+empleados[i].Cargo);
Console.WriteLine("Antiguedad del empleado: "+empleados[i].antiguedad());
Console.WriteLine("Edad del empleado: "+empleados[i].edad());
Console.WriteLine("Años para jubilarse: "+empleados[i].jubilacion());
Console.WriteLine("Salario: "+empleados[i].salario());
}




int ingresaEntero(){
    int num;
        do{
            //Console.Write("\nIngrese numero entero: ");
            if(!(int.TryParse(Console.ReadLine(), out num))){
                num=-999;
                Console.Write("\nError. Valor invalido");
                Console.Write("\nVuelva a intentar");
            }
        }while(num==-999);
    return num; 
}  


double ingresaReal(){
    double num;
        do{
            //Console.Write("\nIngrese numero entero: ");
            if(!(double.TryParse(Console.ReadLine(), out num))){
                num=-999;
                Console.Write("\nError. Valor invalido");
                Console.Write("\nVuelva a intentar");
            }
        }while(num==-999);
    return num; 
}  


DateTime ingresaFecha(){
    DateTime fecha;
    Console.Write("Anio: ");        int anio = ingresaEntero();
    Console.Write("Mes: ");        int mes = ingresaEntero();
    Console.Write("Dia: ");        int dia = ingresaEntero();
    fecha = new DateTime(anio,mes,dia);
    return fecha;
} 



int ingresaCargo(){
    int num;
    do{
        Console.WriteLine("0 - Auxiliar");
        Console.WriteLine("1 - Administrativo");
        Console.WriteLine("2 - Ingeniero");
        Console.WriteLine("3 - Especialista");
        Console.WriteLine("4 - Investigador");
        Console.Write("Seleccione el cargo: ");
        num= ingresaEntero();
    }while(num<0 || num>4);
    return num;
}
