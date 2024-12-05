namespace projecteProva2
{
    internal class Program
    {
        const string MsgErrorDia = "Introdueix el dia";
        const string MsgErrorMes = "Introdueix el mes";
        const string MsgErrorAny = "Introdueix el any";
        public static void Main(string[] args)
        {
            int dia = 0;
            int mes = 0;
            int any = 0;


            Console.WriteLine(MsgErrorDia);
            dia = Int16.Parse(Console.ReadLine());
            Console.WriteLine(MsgErrorMes);
            mes = Int16.Parse(Console.ReadLine());
            Console.WriteLine(MsgErrorAny);
            any = Int16.Parse(Console.ReadLine());
            DiaCorrecte(dia);
            MesCorrecte(mes);
            AnyCorrecte(any);
        }
        public static void DiaCorrecte(int dia)
        {
            while (dia < 1 || dia > 31)
            {
                Console.WriteLine(MsgErrorDia);
                dia = Int16.Parse(Console.ReadLine());
            }
        }
        public static void MesCorrecte(int mes)
        {
            while (mes < 1 || mes > 12)
            {
                Console.WriteLine(MsgErrorMes);
                mes = Int16.Parse(Console.ReadLine());
            }
        }
        public static void AnyCorrecte(int any)
        {
            while ((any % 400 == 0) || ((any % 4 == 0) && (any % 100 != 0)))
            {
                Console.WriteLine(MsgErrorAny);
                any = Int16.Parse(Console.ReadLine());
            }
        }
    }
}