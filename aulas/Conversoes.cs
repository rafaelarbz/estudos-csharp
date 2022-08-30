namespace HelloWorld
{
    class Conversoes
    {
        static void Main() 
        {
            //Implicita
            int x = 4;
            double x = y;
            Console.WriteLine(y);

            //Explicita
            double nota = 8.6;
            int notaConvertida = (int)nota;
            Console.WriteLine(notaConvertida);

            //Usando Convert
            Console.WriteLine("Informe o número de sua casa: ");
            string numeroCasa = Console.ReadLine();
            int numero = (int)numeroCasa;
            Console.WriteLine("O número de sua casa é {0}", numero);

            numero = Convert.ToInt32(numeroCasa);
            Console.WriteLine(numero);
        }
    }
}