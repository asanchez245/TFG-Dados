using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;
using System.Collections;
using UnityEngine.UI;

public class DiceGenerator_Clase : MonoBehaviour
{
    [SerializeField] GameObject diceMovememt;
    DiceMovement_Clase diceMovement_Clase;
    DiceInfo_Clase diceInfo_Clase;
    GameObject diceInstance;

    [SerializeField] GameObject diceGameobject;

    void Awake()
    {
        diceMovement_Clase = diceMovememt.GetComponent<DiceMovement_Clase>();
        diceInfo_Clase = diceInstance.GetComponent<DiceInfo_Clase>();

    }

    void Update()
    {
        
    }

    public void GenerateDice()
    {
        int random = Random.Range(1, 7);
        diceInstance = Instantiate(diceGameobject);
        diceInfo_Clase.diceValue = random;
        //diceInfo_Clase.diceArtwork = diceInfo_Clase.diceArtwork[random];
    }
}
