namespace DoFactory.HeadFirst.Factory.Abstract.Pizza
{
    using System;

    public class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        #region CONSTRUCTORS

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        #endregion

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            veggies = _ingredientFactory.CreateVeggies();
        }
    }
}