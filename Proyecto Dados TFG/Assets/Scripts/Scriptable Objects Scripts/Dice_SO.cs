using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dice_SO", menuName = "Scriptable Objects/Dice_SO")]
public class Dice_SO : ScriptableObject
{
    public string diceName;
    public List<Sprite> facesSprites;


    [SerializeField] 
    public enum DiceType
    {
        Normal, 
    }
}
