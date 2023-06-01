namespace EspacioCalculadora;

public class Calculadora{
    private double valor;

    public Calculadora(){
         valor=0;
    }

    public double Resultado{ get => valor;}
    //public double Valor { get => valor; set => valor = value; }

    public void Sumar(double sumando){//metodo publico
        valor+=sumando;
    }

    public void Restar(double termino){//metodo publico
        valor-=termino;
    }

    public void Multiplicar(double termino){//metodo publico
        valor*=termino;
    }

    public void Dividir(double termino){//metodo publico
        valor/=termino;
    }

    public void Limpiar(){//metodo publico
        valor=0;
    }
}