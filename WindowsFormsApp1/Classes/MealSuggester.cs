using MealPlannerApp.EFClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlannerApp.Classes
{
    public class MealSuggester
    {
        private Dictionary<Ingredient, List<Meal>> SuggestionsDictionary { get; set; }
        private Ingredient LastSuggestion = Ingredient.NULL;

        public MealSuggester(List<Meal> Meals)
        {
            SuggestionsDictionary = CreateSuggestionsDictionary(Meals);
        }

        public KeyValuePair<Ingredient, List<Meal>> NextSuggestion()
        {
            Random rand = new Random();
            List<Ingredient> values = Enumerable.ToList(SuggestionsDictionary.Keys);
            int size = SuggestionsDictionary.Count;
            Ingredient ChosenIngredient;
            do
            {
                ChosenIngredient = values[rand.Next(size)];
            } while (ChosenIngredient.Equals(LastSuggestion));
            LastSuggestion = ChosenIngredient;
            var entry = new KeyValuePair<Ingredient, List<Meal>>
                (ChosenIngredient, SuggestionsDictionary[ChosenIngredient]);
            return entry;
        }

        public void Remove(Meal meal)
        {
            foreach (Ingredient i in SuggestionsDictionary.Keys)
            {
                List<Meal> list = SuggestionsDictionary[i];
                foreach (Meal m in list)
                {
                    if (meal.SharesIngredientsWith(m))
                    {
                        list.Remove(m);
                        if (list.Count == 0)
                        {
                            SuggestionsDictionary.Remove(i);
                        }
                    }
                }
            }
            foreach (Ingredient i in meal.Ingredients)
            {
                SuggestionsDictionary.Remove(i);
            }
        }

        private static Dictionary<Ingredient, List<Meal>> CreateSuggestionsDictionary(IEnumerable<Meal> Meals)
        {
            Dictionary<Ingredient, List<Meal>> suggestions = new Dictionary<Ingredient, List<Meal>>();
            foreach (Meal meal in Meals)
            {
                foreach (Ingredient i in meal.Ingredients)
                {
                    if (i.IsCarb || i.IsProtein)
                    {
                        if (suggestions.ContainsKey(i))
                        {
                            suggestions[i].Add(meal);
                        }
                        else
                        {
                            suggestions[i] = new List<Meal>() { meal };
                        }
                    }
                }
            }
            return suggestions;
        }
    }
}
