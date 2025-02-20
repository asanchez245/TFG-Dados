using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DiceMovement_Clase : MonoBehaviour
{
    [SerializeField] GameObject _diceStartPosition;


    void Start()
    {
        EventSystem.current.SetSelectedGameObject(_diceStartPosition);
    }

    void Update()
    {
        if (InputManager.instance.SelectInput) //Se acciona el intro o boton A del mando
        {
            if (EventSystem.current.currentSelectedGameObject == _diceStartPosition) //se selecciona el dado
            {
                EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false; //desactiva el boton del dado

                EventSystem.current.SetSelectedGameObject(_diceStartPosition);
                Debug.Log("dado seleccionado"); //bucle for busca posiciones disponibles

            }
            if (EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable) //se selecciona una casilla vacia
            {
                Transform currentParent = EventSystem.current.currentSelectedGameObject.transform.parent;
                for (int i = 0; i < currentParent.childCount; i++) //revisa las casillas de la fila
                {
                    if (!currentParent.GetChild(i).GetComponent<Button>().interactable) //si la casilla no es interactuable
                    {
                        currentParent.GetChild(i).GetComponent<Button>().interactable = true;
                        EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
                        EventSystem.current.SetSelectedGameObject(_diceStartPosition);
                    }
                    else
                    {
                        return;
                    }

                }
            }
            else
            {
                EventSystem.current.SetSelectedGameObject(_diceStartPosition);
            }
        }
    }
}
