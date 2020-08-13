using Decorator.Pizzas;

namespace Decorator.Decorators
{
    public class Soocis:MavadDecorator
    {
        public Soocis(Pizza pizza)
        {
            this._pizza = pizza;
        }
        public override string Description => _pizza.Description + " + Socis ";

     

        public override double Cost()
        {
            return _pizza.Cost() + 2000;
        }
    }
}