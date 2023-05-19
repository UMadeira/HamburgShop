using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgShop
{
    internal class HamburgBuilder
    {
        private HamburgFactory Factory { get; }
        private IHamburg Hamburg { get; set; }
        private bool HasCheese { get; set; }

        public HamburgBuilder( HamburgFactory factory ) => Factory = factory;

        public HamburgBuilder SetGrassFeed()
        {
            Trace.Assert(Hamburg == null);
            Hamburg = Factory.Create<GrassFeedHamburg>();
            return this;
        }

        public HamburgBuilder SetWagyu()
        {
            Trace.Assert(Hamburg == null);
            Hamburg = Factory.Create<WagyuHamburg>();
            return this;
        }

        public HamburgBuilder SetBrisket()
        {
            Trace.Assert(Hamburg == null);
            Hamburg = Factory.Create<BrisketHamburg>();
            return this;
        }

        public HamburgBuilder AddLettuce()
        {
            Trace.Assert(Hamburg != null);
            Hamburg = Factory.CreateIngredient<LettuceIngredient>( Hamburg );
            return this;
        }

        public HamburgBuilder AddTomato()
        {
            Trace.Assert(Hamburg != null);
            Hamburg = Factory.CreateIngredient<TomatoIngredient>(Hamburg);
            return this;
        }

        public HamburgBuilder AddOnion()
        {
            Trace.Assert(Hamburg != null);
            Hamburg = Factory.CreateIngredient<OnionIngredient>(Hamburg);
            return this;
        }

        public HamburgBuilder AddCheddarCheese()
        {
            if (HasCheese) return this;
            HasCheese = true;

            Trace.Assert(Hamburg != null);
            Hamburg = Factory.CreateIngredient<CheddarCheeseIngredient>(Hamburg);
            return this;
        }

        public HamburgBuilder AddSwissCheese()
        {
            if (HasCheese) return this;
            HasCheese = true;

            Trace.Assert(Hamburg != null);
            Hamburg = Factory.CreateIngredient<SwissCheeseIngredient>(Hamburg);
            return this;
        }

        public IHamburg Build()
        {
            var hamburg = Hamburg;
            Hamburg = null;
            HasCheese = false;
            return hamburg;
        }
    }
}
