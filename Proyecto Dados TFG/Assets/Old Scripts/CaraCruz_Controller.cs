using System.Collections;
using UnityEngine;

public class CaraCruz_Controller : MonoBehaviour
{

    [SerializeField] GameObject turnManager;
    TurnManager turnManager_Clase;

    [SerializeField] GameObject diceMovement;
    [SerializeField] GameObject uiController;

    [SerializeField] GameObject _botonCara;
    [SerializeField] GameObject _botonCruz;
    [SerializeField] GameObject _monedaCara;
    [SerializeField] GameObject _monedaCruz;

    public int chosenValue;

    public GameObject cartelMoneda;
    public GameObject cartelTurnos;

    bool _coinFlipped;

    void Start()
    {
        cartelMoneda.SetActive(true);
        cartelTurnos.SetActive(false);
        diceMovement.SetActive(false);
        turnManager_Clase = turnManager.GetComponent<TurnManager>();
        _botonCara.SetActive(true);
        _botonCruz.SetActive(true);
    }


    public void CoinFlip(bool cara)
    {
        _botonCara.SetActive(false);
        _botonCruz.SetActive(false);
        StartCoroutine(LanzarMoneda(cara));
        _coinFlipped = true;
    }

    public IEnumerator LanzarMoneda(bool cara)
    {
        int random = Random.Range(0, 2);
        switch (random)
        {
            case 0://cara
                _monedaCara.SetActive(true);
                break;
            case 1://cruz
                _monedaCruz.SetActive(true);
                break;
        }
        Debug.Log(random);


        yield return new WaitForSeconds(3); //espera 3 segundos para la animacion de tirar la moneda

        if((cara && random == 0) || (!cara && random == 1)) //si elige cara y sale cara o elige cruz y sale cruz
        {
            diceMovement.SetActive(true);
            turnManager_Clase.gameRunning = true;
            
        }
        else
        {
            turnManager_Clase.ChangePlayerTurn();
            diceMovement.SetActive(true);
            turnManager_Clase.gameRunning = true;
        }

        _monedaCruz.SetActive(false);
        _monedaCara.SetActive(false);
        cartelTurnos.SetActive(true);
        cartelMoneda.SetActive(false);
    }
}
