namespace DoFactory.HeadFirst.Composite.MenuIterator
{
    using System;
    using System.Collections.Generic;

    public abstract class MenuComponent
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public bool Vegetarian { get; set; }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public abstract IEnumerator<MenuComponent> CreateIterator();

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}