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

using EspacioEmpleados;

// string nombre="javi";
// string apellido="isasmendi";
// DateTime FechaNacimiento, FechaIngreso;
// char estadoCivil='x', genero='c';
var nombre= Console.ReadLine();
var apellido= Console.ReadLine();
var fechaNacimiento= new DateTime(2014,12,12);
var estadoCivil= Convert.ToChar(Console.ReadLine().ToString());
var genero= Convert.ToChar(Console.ReadLine().ToString());
var fechaIngreso= new DateTime(2014,12,12);
var sueldoBasico= Convert.ToDouble(Console.ReadLine());
//var cargo= int.TryParse(Console.ReadLine(), out empleado.SueldoBasico);
var cargo=1;

Empleados empleado = new Empleados(nombre, apellido,fechaNacimiento,estadoCivil,genero,fechaIngreso,sueldoBasico,cargo);

// empleado.Nombre=Console.ReadLine();
// empleado.Apellido=Console.ReadLine();
// DateTime empleado.FechaNacimiento = new DateTime(2014,12,12);
// empleado.EstadoCivil=Console.ReadLine();
// empleado.Genero=Console.ReadLine();
// DateTime empleado.FechaIngreso = new DateTime(2014,12,12);
// double.TryParse(Console.ReadLine(), out empleado.SueldoBasico);
// empleado.Cargo=Console.ReadLine();


Console.WriteLine(empleado.Nombre);

empleado.antiguedad();