using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;
using System.Collections;
using UnityEngine.UI;

public class DiceGenerator_Clase : MonoBehaviour
{
    DiceInfo_Clase diceInfo_Clase;
    DiceMovement_Clase diceMovement_Clase;
    [SerializeField] GameObject diceMovement;
    [SerializeField] GameObject diceGameobject;

    [SerializeField] GameObject diceInstancePos;
    public GameObject diceInstance;


    void Awake()
    {
        diceMovement_Clase = diceMovement.GetComponent<DiceMovement_Clase>();
        diceInfo_Clase = diceGameobject.GetComponent<DiceInfo_Clase>();

    }

    void Update()
    {
        Random.seed = System.DateTime.Now.Millisecond; //randomiza mas el randomizer (por la cara)
        
    }

    public void GenerateDice()
    {
        diceMovement_Clase.instaciatedDice = null;
        int random = Random.Range(0, 6);
        diceInstance = Instantiate(diceGameobject, diceInstancePos.transform.position, transform.rotation);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        diceInstance.GetComponent<DiceInfo_Clase>().diceValue = random + 1;

        diceMovement_Clase.instaciatedDice = diceInstance;
        Debug.Log("Instanciado dado " + diceInstance.GetComponent<DiceInfo_Clase>().diceValue);

    }
}
