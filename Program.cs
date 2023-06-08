using EspacioCalculadora;

Calculadora cal=new Calculadora(); //renombre de biblioteca?
int a, b, op;
Console.Clear();
do{
    Console.WriteLine("\n\n\nCalculadora\n");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Salir\n");
    op=ingresarEntero();
    switch (op)
    {
         case 1:
            Console.WriteLine("Ingrese primer valor");
            a=ingresarEntero();
            Console.WriteLine("Ingrese segundo valor");
            b=ingresarEntero();
            if(a!=-999 && b!=-999){
                cal.Sumar(a);
                cal.Sumar(b);
                Console.WriteLine("\n"+a+"+"+b+"="+cal.Resultado+"\n");
                cal.Limpiar();
            }   else{
                Console.WriteLine("Error");
            }
            Console.Write("Presione una tecla para continuar");
            cal.Limpiar();            
            Console.ReadKey();

           break;
        case 2:
            Console.WriteLine("Ingrese primer valor");
            a=ingresarEntero();
            Console.WriteLine("Ingrese segundo valor");
            b=ingresarEntero();
            if(a!=-999 && b!=-999){
                cal.Sumar(a);
                cal.Restar(b);
                Console.WriteLine("\n"+a+"-"+b+"="+cal.Resultado+"\n");
            }
            cal.Limpiar();
            Console.Write("Presione una tecla para continuar");
            Console.ReadKey();

            break;
        case 3:
            Console.WriteLine("Ingrese primer valor");
            a=ingresarEntero();
            Console.WriteLine("Ingrese segundo valor");
            b=ingresarEntero();
            if(a!=-999 && b!=-999){
                cal.Sumar(a);
                cal.Multiplicar(b);
                Console.WriteLine("\n"+a+"*"+b+"="+cal.Resultado+"\n");
            }
            cal.Limpiar();
            Console.Write("Presione una tecla para continuar");
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("Ingrese primer valor");
            a=ingresarEntero();
            Console.WriteLine("Ingrese segundo valor");
            b=ingresarEntero();
            if(a!=-999 && b!=-999 && b!=0){
                cal.Sumar(a);
                cal.Dividir(b);
                Console.WriteLine("\n"+a+"*"+b+"="+cal.Resultado+"\n");
            }
            cal.Limpiar();
            Console.Write("Presione una tecla para continuar");
            Console.ReadKey();
            break;
        case 5:
            break;
    }
}while(op!=5);

return 0;


int ingresarEntero(){
    int num;
    if(int.TryParse(Console.ReadLine(), out num)){
        return num;
    } else{
        return -999;
    }
}

