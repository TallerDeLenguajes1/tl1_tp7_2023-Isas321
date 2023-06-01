

using EspacioCalculadora;

//Console.WriteLine()
Calculadora cal=new Calculadora(); //renombre de biblioteca?
int a,b, op;
do{
    //Console.WriteLine("Valor Inicial"+cal.Resultado);

    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Limpiar");
    Console.WriteLine("6-Salir");
    op=ingresarEntero();

    Console.WriteLine("Ingrese primer valor");
    a=ingresarEntero();
    Console.WriteLine("Ingrese segundo valor");
    b=ingresarEntero();

    switch (op)
    {
         case 1:
            if(a!=-999 && b!=-999){
                cal.Sumar(a);
                cal.Sumar(b);
                Console.WriteLine("\n"+a+"+"+b+"="+cal.Resultado+"\n");
                cal.Limpiar();
            }   else{
                Console.WriteLine("Error");
            }

           break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
    }
}while(op!=6);



//Console.ReadKey();


int ingresarEntero(){
    int num;
    if(int.TryParse(Console.ReadLine(), out num)){
        return num;
    } else{
        return -999;
    }
}



// cal.Restar(5);
// Console.WriteLine(cal.Resultado);

// cal.Multiplicar(5);
// Console.WriteLine(cal.Resultado);

// cal.Dividir(5);
// Console.WriteLine(cal.Resultado);

// cal.Limpiar(15);
// Console.WriteLine(cal.Resultado);


