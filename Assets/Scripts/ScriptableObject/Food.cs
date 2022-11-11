using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food",menuName ="New Food/Food")]
public class Food : ScriptableObject
{
    public string foodName;
    public Sprite foodImage;
    public GameObject prefab;
    public int Price;
    public List<Ingredients> recipe = new List<Ingredients>();
    public enum FOOD_TYPE
    {
        Stew,ApplePie,Beer,SpecialSet,HouseA,HouseB
    }

    public FOOD_TYPE foodType;

    public enum GOLD_TYPE
    {
        Gold,Silver,Bronze
    }

    public GOLD_TYPE goldType;

}
