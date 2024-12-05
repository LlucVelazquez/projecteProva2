using Prova;

namespace projecteProva2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int n = 5;
            int y = 0;
            num = Int16.Parse(Console.ReadLine());
            int[] ints = { 10, 4, 6, 4, 8, -13, 2, 3 };
            
            isNumberList(ints, num);

            SecondSort.Order(ints, n, y);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write($"{ints[i]} ");
            }
        }
        public static void isNumberList(int[] arrs, int num) // No se quina llibreria es per fer la a
        {
            const string IsInList = "El Numero esta en la llista";

            for (int i = 0; i < arrs.Length; i++)
            {
                if (num == arrs[i])
                {
                    Console.WriteLine(IsInList);
                }
            }

        }
    }
}