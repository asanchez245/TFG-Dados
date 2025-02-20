using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuManager_Clase : MonoBehaviour
{
    [SerializeField] GameObject _playerStartPosition;

    //[SerializeField] GameObject _player1Select;
    //[SerializeField] GameObject _player2Select;



    void Start()
    {
        EventSystem.current.SetSelectedGameObject(_playerStartPosition);
    }

    void Update()
    {
        if (InputManager.instance.SelectInput)
        {
            if(EventSystem.current.currentSelectedGameObject == _playerStartPosition) //se selecciona el dado
            {
                Debug.Log("dado seleccionado"); //bucle for busca posiciones disponibles

            }
            else
            {
                EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;

                EventSystem.current.SetSelectedGameObject(_playerStartPosition);

            }

        }
    }
    
    //public void SelectPlayer1()
    //{
    //    _player1Select.GetComponent<Button>().interactable = false;
    //    EventSystem.current.SetSelectedGameObject(_playerStartPosition);
    //}
    //public void SelectPlayer2()
    //{
    //    _player2Select.GetComponent<Button>().interactable = false;
    //    EventSystem.current.SetSelectedGameObject(_playerStartPosition);

    //}
}
