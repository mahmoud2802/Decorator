using Decorator.Pizzas;

namespace Decorator.Decorators
{
    public class Garlic :MavadDecorator
    {
        public Garlic(Pizza pizza)
        {
            this._pizza = pizza;
        }

        public override string Description => _pizza.Description + " + Garlic ";



        public override double Cost()
        {
            return this._pizza.Cost() + 5000;
        }
    }
}