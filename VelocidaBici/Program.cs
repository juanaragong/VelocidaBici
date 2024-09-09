internal class Program
{
    private static void Main(string[] args)
    {
        double distancia;//Definicion Entrada de datos
        double tiempo; //Definicio salida de datos

        //Entrada
        Console.WriteLine("App que calcula el tiempo de un vato en bici"); //Escribir
        Console.WriteLine("Proporciona el valor de la distancia");//Escribir
        distancia=double.Parse(Console.ReadLine());//Leer
        //Proceso
        tiempo = distancia / 12;
        //Salida
        Console.WriteLine("El tiempo que se va a tardar el vato es de " + tiempo);

    }
}