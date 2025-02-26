using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DiceMovement_Clase : MonoBehaviour
{
    [SerializeField] GameObject _diceStartPosition;
    [SerializeField] GameObject _firstRowSelection;
    [SerializeField] GameObject[] _rows;
    GameObject _selectedRow;

    public GameObject instaciatedDice;


    [SerializeField] GameObject diceGenerator;
    DiceGenerator_Clase diceGenerator_Clase;

    void Start()
    {
        diceGenerator_Clase = diceGenerator.GetComponent<DiceGenerator_Clase>();
        EventSystem.current.SetSelectedGameObject(_diceStartPosition);
    }

    void Update()
    {
        if (InputManager.instance.SelectInput) //Se acciona el intro o boton A del mando
        {
            if (EventSystem.current.currentSelectedGameObject == _diceStartPosition) //se selecciona el dado
            {
                EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false; //desactiva el boton del dado
                diceGenerator_Clase.GenerateDice();
                EventSystem.current.SetSelectedGameObject(_firstRowSelection); //psa automaticamente a seleccionar la primera fila
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
                }

            }
            else
            {
                Debug.Log("fila completa");
            }
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
                    instaciatedDice.transform.parent = _selectedRow.transform.GetChild(i); //emparenta al dado con la casilla
                    instaciatedDice.transform.position = _selectedRow.transform.GetChild(i).position; //lo coloca en el centro de esta
                    Debug.Log("Dado colocado en " + _selectedRow.transform.GetChild(i).transform.name);


                    EventSystem.current.SetSelectedGameObject(_diceStartPosition); //vuelve a seleccionar la pos inicial del dado
                    EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = true; //activa el boton
                    return;
                }
            }
        }
    }
}
