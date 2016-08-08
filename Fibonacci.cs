using System;

//namespace EjerciciosBasicos
//{
   public  class Fibonacci
    {
        private int x=0;
        private int y=1;
        private int suma;

        public void calcular()
        {
            Console.WriteLine("Secuencia Fibonacci iterada 1 veces.");
            Console.WriteLine("suma: " + x + "\n");//imprime los valores iniciales '0'
            Console.WriteLine("suma: " + y + "\n");//imprime los valores iniciales '1'

            for (int i=0;i<10;i++)
            {
                suma = x + y;//hacemos la suma de x e y
                x = y;//recorremos x; movemos el valor de y a x.
                y = suma; //recorremos y; movemos el nuevo valor 'suma' a 'y'.
                Console.WriteLine("suma: " + suma + "\n");



            }
        }
        public static void Main(string[]args)
        {
            Fibonacci obj = new Fibonacci();
            obj.calcular();
            Console.ReadKey();
        }
    }
//}
