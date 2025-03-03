using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DiceMovement_Clase : MonoBehaviour
{
    [SerializeField] GameObject[] _diceStartPosition;
    public GameObject _currentStartPosition;

    [SerializeField] GameObject[] _firstRowSelection;
    GameObject _currentFirstRowSelection;

    [SerializeField] GameObject[] _rows;
    public GameObject _selectedRow;

    [SerializeField] GameObject diceGenerator;
    DiceGenerator_Clase diceGenerator_Clase; 
    [SerializeField] GameObject turnManager;
    TurnManager turnManager_Clase;

    void Start()
    {
        diceGenerator_Clase = diceGenerator.GetComponent<DiceGenerator_Clase>();
        turnManager_Clase = turnManager.GetComponent<TurnManager>();

        EventSystem.current.SetSelectedGameObject(_diceStartPosition[0]); //setea el boton seleccionado el de generar el dado del jugador 1

        diceGenerator_Clase.currentSpawnPosition = diceGenerator_Clase.diceSpawnPosition[0]; //al empezar default la pos de spawn del dado el la del p1
    }

    void Update()
    {
        if (InputManager.instance.SelectInput) //Se acciona el intro o boton A del mando
        {
            switch (turnManager_Clase.p1Turn)
            {
                case true: //turno de P1
                    _currentStartPosition = _diceStartPosition[0]; //setea la pos inicial del p1
                    _currentFirstRowSelection = _firstRowSelection[0]; //setea la primera fila escogida a la 1 del p1
                    diceGenerator_Clase.currentSpawnPosition = diceGenerator_Clase.diceSpawnPosition[0];
                    SelectAction();
                    break;
                case false: //turno de P2
                    _currentStartPosition = _diceStartPosition[1]; //setea la pos inicial del p2
                    _currentFirstRowSelection = _firstRowSelection[1]; //setea la primera fila escogida a la 1 del p2
                    diceGenerator_Clase.currentSpawnPosition = diceGenerator_Clase.diceSpawnPosition[1];
                    SelectAction();
                    break;
            }
        }
    }
    public void SelectAction()
    {
        if (EventSystem.current.currentSelectedGameObject == _currentStartPosition) //se selecciona el dado
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false; //desactiva el boton del dado
            diceGenerator_Clase.GenerateDice();
            EventSystem.current.SetSelectedGameObject(_currentFirstRowSelection); //psa automaticamente a seleccionar la primera fila
            return;
        }
        if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable) //selecciona una fila valida
        {
            //Switch segun el nombre del boton (flecha9 que selecciona la fila
            switch (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().transform.name)
            {
                case ("Flecha 1"):
                    _selectedRow = _rows[0];
                    FindValidPosition();

                    break;

                case ("Flecha 2"):
                    _selectedRow = _rows[1];
                    FindValidPosition();

                    break;

                case ("Flecha 3"):
                    _selectedRow = _rows[2];
                    FindValidPosition();

                    break;

                case ("Flecha 4"):
                    _selectedRow = _rows[3];
                    FindValidPosition();

                    break;

                case ("Flecha 5"):
                    _selectedRow = _rows[4];
                    FindValidPosition();

                    break;

                case ("Flecha 6"):
                    _selectedRow = _rows[5];
                    FindValidPosition();

                    break;
            }

        }
        else //la fila esta completa
        {
            Debug.Log("fila completa");
        }
    }

    public void FindValidPosition()
    {
        //Busca una posicion valida
        for (int i = 0; i < 3; i++) // busca en la fila
        {
            for (int x = 0; x < _selectedRow.transform.childCount; x++) //busca en las posiciones de la fila
            {
                if (_selectedRow.transform.GetChild(i).transform.childCount > 0) //si el primer hijo de la fila tiene dado
                {
                    //Casilla invalida
                    Debug.Log(_selectedRow.transform.GetChild(i).transform.name + " invalido");
                }
                else //si no tiene dado
                {
                    //Coloca el dado en esta casilla
                    diceGenerator_Clase.instaciatedDice.transform.parent = _selectedRow.transform.GetChild(i); //emparenta al dado con la casilla
                    diceGenerator_Clase.instaciatedDice.transform.position = _selectedRow.transform.GetChild(i).position; //lo coloca en el centro de esta
                    Debug.Log("Dado colocado en " + _selectedRow.transform.GetChild(i).transform.name);

                    _currentStartPosition = turnManager_Clase.p1Turn ? _diceStartPosition[1] : _diceStartPosition[0]; //if p1 turno select p2start pos y viceversa
                    diceGenerator_Clase.currentSpawnPosition = turnManager_Clase.p1Turn ? 
                        diceGenerator_Clase.diceSpawnPosition[1] : diceGenerator_Clase.diceSpawnPosition[0]; //if p1 turno select p2start pos y viceversa
                    EventSystem.current.SetSelectedGameObject(_currentStartPosition); //vuelve a seleccionar la pos inicial del dado
                    EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = true; //activa el boton

                    turnManager_Clase.ChangePlayerTurn();
                    return;
                }
            }
        }
    }
}
