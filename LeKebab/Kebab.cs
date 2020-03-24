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

        public void AddSauce(string sauce)
        {
            _ingredients.Add(sauce); 
        }

        public static Kebab SansOignon(Kebab kebab)
        {
            foreach (var ingredient in kebab._ingredients)
            {
                if (ingredient == "Oignon")
                {
                    kebab._ingredients.Remove(ingredient);
                    break;
                }
            }

            return kebab;
        }

        public static Kebab DoubleCheese(Kebab kebab)
        {
            foreach (var ingredient in kebab._ingredients)
            {
                if (ingredient .Contains("Cheese") )
                {
                    kebab._ingredients.Add("Double " + ingredient);
                    kebab._ingredients.Remove(ingredient);
                    break;
                }
            }

            return kebab;
        }
        /*
         *Ajouter une methode renvoit un kebab nommée SansOignon et qui renvoit
         * le kebab avec tous les ingrédients déjà configurés mais sans les oignons si
         * il y en avait
           
           Ajouter une methode renvoit un kebab nommée SupplémentFromage et qui renvoit
           le kebab avec tous les ingrédients déjà configurés mais pour chaque ingrédient
           fromage ca le double
         *
         */
    }
}