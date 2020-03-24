using System.Collections.Generic;

namespace LeKebab
{
    class Kebab
    {
        private List<string> _ingredients = new List<string>();

        public Kebab(List<string> ingredients)
        {
            _ingredients = ingredients;
        }

        public bool IsVegan()
        {
            foreach (var ingredient in _ingredients)
            {
                if (ingredient != "tomate" || ingredient != "onion")
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPescetarian()
        {
            foreach(var ingredient in _ingredients)
            {
                if (ingredient != "tomate" || ingredient != "onion" || ingredient != "poisson"
                    || ingredient != "crevettes")
                {
                    return false;
                }
            }

            return true;
        }
    }
}