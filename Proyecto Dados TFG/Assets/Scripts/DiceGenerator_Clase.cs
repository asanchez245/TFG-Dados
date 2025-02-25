using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;
using System.Collections;
using UnityEngine.UI;

public class DiceGenerator_Clase : MonoBehaviour
{
    [SerializeField] GameObject diceMovememt;
    DiceMovement_Clase diceMovement_Clase;
    public Dice[] dices;

    void Awake()
    {
         diceMovement_Clase = diceMovememt.GetComponent<DiceMovement_Clase>();
    }

    void Update()
    {
        
    }

    public void GenerateDice()
    {
       //dices[Random.Range(0, dices.Length)].diceValue ;



    }
}
