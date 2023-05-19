
namespace HamburgShop
{
    internal class HamburgFactory
    {   
        private HamburgFactory() { }
        public static HamburgFactory Instance { get; } = new HamburgFactory();

        public T Create<T>() where T : IHamburg
        {
            return (T) Activator.CreateInstance( typeof(T) );
        }

        public T CreateIngredient<T>( IHamburg hamburg ) where T : Ingredient
        {
            return (T) Activator.CreateInstance( typeof(T), hamburg );
        }
    }
}
