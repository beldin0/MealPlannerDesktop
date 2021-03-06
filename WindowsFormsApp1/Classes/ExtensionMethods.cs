﻿using MealPlannerApp.EFClasses;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MealPlannerApp.Classes
{
    public static class ExtensionMethods
    {
        public static string ToProper(this string value)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }

        public static void Remove(this DataTable dataTable, string matchString)
        {
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                string mealName = ((string)(dataTable.Rows[i].ItemArray[0]));
                if ((mealName.Equals(matchString)))
                {
                    dataTable.Rows[i].Delete();
                    return;
                }
            }
        }

        public static void Add(this DataTable table, Meal m)
        {
            DataRow d = table.NewRow();
            d[0] = m.Name;
            d[1] = m.CookTime;
            d[2] = string.Join(", ", m.Proteins.ConvertAll(i => i.Name));
            d[3] = string.Join(", ", m.Carbs.ConvertAll(i => i.Name));
            table.Rows.Add(d);
        }

        public static List<string> ConcatList(this List<string> list, int maxlength = 90)
        {
            List<string> copyOfList = new List<string>(list);
            list.Clear();
            string line = "";
            foreach (string ingredient in copyOfList)
            {
                if (line.Length + ingredient.Length < maxlength)
                {

                    line += (line.Length > 0 ? ", " : "") + ingredient;
                }
                else
                {
                    list.Add(line);
                    line = "";
                }
            }
            if (line != "") list.Add(line);
            return list;
        }

        public static bool SharesIngredientsWith(this Meal meal1, Meal meal2)
        {
            foreach (Ingredient i in meal1.Ingredients)
            {
                if (meal2.Ingredients.Contains(i)) return true;
            }
            foreach (Ingredient i in meal2.Ingredients)
            {
                if (meal1.Ingredients.Contains(i)) return true;
            }
            return false;
        }
    }
}
