using UnityEngine;

[CreateAssetMenu(fileName = "Dice", menuName = "Scriptable Objects/Dice")]
public class Dice : ScriptableObject
{
    public string diceName;
    public int diceValue;
    public Sprite diceSprite;
}
