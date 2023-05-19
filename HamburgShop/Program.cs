namespace HamburgShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //IHamburg hamburg = new GrassFeedHamburg();
            //hamburg = new LettuceIngredient( hamburg );
            //hamburg = new CheddarCheeseIngredient(hamburg);
            //hamburg = new TomatoIngredient(hamburg);
            //hamburg = new OnionIngredient(hamburg);

            var factory = HamburgFactory.Instance;

            //IHamburg hamburg = factory.Create<GrassFeedHamburg>();
            //hamburg = factory.CreateIngredient<LettuceIngredient>( hamburg );
            //hamburg = factory.CreateIngredient<CheddarCheeseIngredient>(hamburg);
            //hamburg = factory.CreateIngredient<CheddarCheeseIngredient>(hamburg);
            //hamburg = factory.CreateIngredient<TomatoIngredient>(hamburg);
            //hamburg = factory.CreateIngredient<OnionIngredient>(hamburg);

            var builder = new HamburgBuilder(factory);

            var hamburg1 = builder
                .SetGrassFeed()
                .AddLettuce()
                .AddCheddarCheese()
                .AddTomato()
                .AddOnion()
                .Build();       

            Console.WriteLine("Your first hamburg:");
            Console.WriteLine();
            Console.WriteLine(hamburg1.ToString());

            var hamburg2 = hamburg1.Clone();
            hamburg2 = factory.CreateIngredient<TomatoIngredient>( hamburg2 );

            Console.WriteLine("Your second hamburg:");
            Console.WriteLine();
            Console.WriteLine(hamburg2.ToString());

        }
    }
}