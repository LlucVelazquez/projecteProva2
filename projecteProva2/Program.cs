namespace projecteProva2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            cosnt string Msg = "Introdueix els 20 numeros per separat: ";
            const string DemanarNum = "Introdueix un nombre: ";
            const string 
            int[] arrs = new int[20];
            int num = 0;

            Console.WriteLine(Msg);
            for(int i = 0; i < arrs.Length; i++)
            {
                arrs[i] = Int16.Parse(Console.ReadLine());
            }

            BubbleSort(arrs);

            for (int i = 0;i < arrs.Length; i++)
            {
                Console.Write($"{arrs[i]} ");
            }

            Console.WriteLine(DemanarNum);
            num = Int16.Parse(Console.ReadLine());
            Console.WriteLine(isNumberList(arrs, num);
        }
        public static void BubbleSort(int[] arrs)
        {
            for (int i=0; i < arrs.Length - 1; i++) 
            {
                for (int j = i + 1; j < arrs.Length; j++)
                {
                    if (arrs[i] < arrs[j])
                    {
                        int aux = arrs[i];
                        arrs[i] = arrs[j];
                        arrs[j] = aux;
                    }
                }
            }
        }
        public static bool isNumberList(int[] arrs, int num)
        {
            for ( int i = 0; i < arrs.Length; i++)
            {
                if (num == arrs[i]) return true;
            }
            return false;
        }
    }
}