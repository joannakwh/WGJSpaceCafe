using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Person", menuName = "Person/Create new Person")]

public class Person : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] Sprite portraitSprite;
    //enum
    [SerializeField] FavouriteDrink favDrink;
    //rate at which a person gives relationship points
    [SerializeField] float multiplier;
    [SerializeField] int maxPoints = 100;
    [SerializeField] int points = 0;

    [SerializeField] List<Dialog> loveDialogs;
    [SerializeField] List<Dialog> likeDialogs;
    [SerializeField] List<Dialog> mehDialogs;
    [SerializeField] List<Dialog> yuckDialogs;
    //[SerializeField] Memento memento;

    //properties
    public string Name
    {
        get { return name; }
    }

    public Sprite PortraitSprite
    {
        get { return portraitSprite; }
    }

    public FavouriteDrink FavDrink
    {
        get { return FavDrink; }
    }

    public float Multiplier
    {
        get { return multiplier; }
    }

    public int MaxPoints
    {
        get { return MaxPoints; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public List<Dialog> LoveDialogs
    {
        get { return loveDialogs; }
    }

    public List<Dialog> LikeDialogs
    {
        get { return LikeDialogs; }
    }

    public List<Dialog> MehDialogs
    {
        get { return mehDialogs; }
    }

    public List<Dialog> YuckDialogs
    {
        get { return yuckDialogs; }
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public enum FavouriteDrink
    {
        None,
        Coffee,
        Latte,
        Milkshake
    }
}
