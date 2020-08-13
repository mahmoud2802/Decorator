using Decorator.Pizzas;

namespace Decorator.Decorators
{
    public  abstract class MavadDecorator:Pizza
    {
        protected Pizza _pizza;
        public abstract override string Description { get; }

    }
}