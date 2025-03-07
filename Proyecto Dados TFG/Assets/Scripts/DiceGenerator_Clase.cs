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

    public GameObject diceInstance;
    public GameObject instaciatedDice;

    public GameObject[] diceSpawnPosition;
    /*[HideInInspector]*/  public GameObject currentSpawnPosition;


    void Awake()
    {
        diceMovement_Clase = diceMovement.GetComponent<DiceMovement_Clase>();
        diceInfo_Clase = diceGameobject.GetComponent<DiceInfo_Clase>();

    }

    void Update()
    {
        //Random.seed = System.DateTime.Now.Millisecond; //randomiza mas el randomizer (por la cara)        
    }

    public IEnumerator DiceInstanceAnimation()
    {
        float diceFlickTImer = .10f;
        instaciatedDice = null;
        int random = Random.Range(0, 6);
        diceInstance = Instantiate(diceGameobject, currentSpawnPosition.transform.position, transform.rotation);
        #region ANIMACION DADO
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer);
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer);
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer); 
        random = Random.Range(0, 6);
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        yield return new WaitForSeconds(diceFlickTImer);
        random = Random.Range(0, 6);
        #endregion
        diceInstance.GetComponent<SpriteRenderer>().sprite = diceInfo_Clase.diceArtwork[random];
        diceInstance.GetComponent<DiceInfo_Clase>().diceValue = random + 1;

        instaciatedDice = diceInstance;
        Debug.Log("Instanciado dado " + diceInstance.GetComponent<DiceInfo_Clase>().diceValue);

    }

    public void GenerateDice()
    {
        StartCoroutine(DiceInstanceAnimation());
    }
}
