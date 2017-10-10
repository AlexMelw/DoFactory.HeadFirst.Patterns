namespace DoFactory.HeadFirst.Factory.Abstract.Pizza
{
    using System;

    public class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        #region CONSTRUCTORS

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
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
        }
    }
}