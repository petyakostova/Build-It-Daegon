﻿namespace Build_It_Daegon.Resources
{
    using Build_It_Daegon.Interfaces;

    public class Water : Resource, IResourceable, IValuable
    {
        public Water(int amount)
        {
            this.Amount = amount;
        }

        public void Add(int resource)
        {
            this.Amount += resource;
        }

        public int IsPositive()
        {
            if (this.Amount >= 0)
            {
                return 1;
            }

            return 0;
        }

        public void Remove(int resource)
        {
            this.Amount -= resource;
        }
    }
}