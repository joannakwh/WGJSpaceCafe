using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Recipe/Create new Recipe")]
public class Recipe : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] List<RecipeItem> ingredients;
    //[SerializeField] List<string> directions;

    public string Name
    {
        get { return name; }
    }

    public List<RecipeItem> Ingredients
    {
        get { return ingredients; }
    }
}

