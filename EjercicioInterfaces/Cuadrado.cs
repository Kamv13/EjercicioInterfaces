
namespace EjercicioInterfaces
{
    public class Cuadrado : IOperaciones
    {
        const double Gravedad = 9.80;
        public double Base;
        public double Altura;
        public double Masa;
        public double Area()
        {
            return Base * Altura;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Base * Altura);
        }

        public double Perimetro()
        {
            return (Base * 4);
        }

        public double Peso()
        {
            return (Masa * Gravedad);
        }

        public double Volumen()
        {
            return (Base * Base * Base);
        }


        public void Imprimir()
        {
            Console.WriteLine($"El Area del cuadrado es {Area()}cm2");
            Console.WriteLine($"La diagonal del cuadrado es {Diagonal()}cm");
            Console.WriteLine($"El Perimetro del cuadrado es {Perimetro}cm");
            Console.WriteLine($"El Peso del cuadrado es {Peso()}N");
            Console.WriteLine($"El Volumen del cuadrado es {Volumen}cm3");
        }
    }
}