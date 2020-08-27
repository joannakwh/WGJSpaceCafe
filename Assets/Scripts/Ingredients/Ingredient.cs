using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ingredient", menuName = "Ingredient/Create new Ingredient")]
public class Ingredient : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] Sprite displaySprite;
    [SerializeField] Sprite inCupSprite;

    //properties
    public string Name
    {
        get { return name; }
    }

    public Sprite DisplaySprite
    {
        get { return displaySprite; }
    }

    public Sprite InCupSprite
    {
        get { return inCupSprite; }
    }
}
