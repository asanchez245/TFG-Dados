using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

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

    void Start()
    {
        diceMovement.SetActive(false);
        turnManager_Clase = turnManager.GetComponent<TurnManager>();
        _botonCara.SetActive(true);
        _botonCruz.SetActive(true);
        EventSystem.current.SetSelectedGameObject(_botonCara);
    }

    private void Update()
    {
        if (InputManager.instance.SelectInput && !uiController.GetComponent<UI_Controller>().isPaused)
        {
            if(EventSystem.current.currentSelectedGameObject == _botonCara)
            {
                chosenValue = 1;
            }
            else
            {
                chosenValue = 0;
            }
            _botonCara.SetActive(false);
            _botonCruz.SetActive(false);
        }
    }

    public void ActivarCorrutina()
    {
        StartCoroutine(LanzarMoneda());
    }

    public IEnumerator LanzarMoneda()
    {
        int random = Random.Range(0, 2);
        switch (random)
        {
            case 0:
                _monedaCruz.SetActive(true);
                break;
            case 1:
                _monedaCara.SetActive(true);
                break;
        }
        Debug.Log(random);


        yield return new WaitForSeconds(3); //espera 3 segundos para la animacion de tirar la moneda

        if(chosenValue == random)
        {
            //turno del player que elige la moneda se mantiene
            diceMovement.SetActive(true);
            turnManager_Clase.gameRunning = true;
            
        }
        else
        {
            //el turno del player que elige cambia
            turnManager_Clase.ChangePlayerTurn();
            diceMovement.SetActive(true);
            turnManager_Clase.gameRunning = true;
        }
        _monedaCruz.SetActive(false);
        _monedaCara.SetActive(false);
    }


    public void FuncionParaTesteoBorrarLuego()
    {
        EventSystem.current.SetSelectedGameObject(_botonCara);

    }
}
