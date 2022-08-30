namespace HelloWorld
{
    class Parse
    {
        static void Main() 
        {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é {0} e sua idade é {1}", nome, idade);
        }
    }
}