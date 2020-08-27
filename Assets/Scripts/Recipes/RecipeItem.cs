using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "Recipe/Create new Recipe Item")]
public class RecipeItem : ScriptableObject
{
    [SerializeField] Ingredient ingr;
    [SerializeField] int qty;

    public Ingredient Ingr
    {
        get { return ingr; }
    }

    public int Qty
    {
        get { return qty; }
    }
}
