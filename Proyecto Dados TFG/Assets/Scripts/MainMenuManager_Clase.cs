using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuManager_Clase : MonoBehaviour
{
    [SerializeField] GameObject _botonJugar;

    //[SerializeField] GameObject _player1Select;
    //[SerializeField] GameObject _player2Select;



    void Start()
    {
        EventSystem.current.SetSelectedGameObject(_botonJugar);
    }

    void Update()
    {
        if (InputManager.instance.SelectInput)
        {
            Debug.Log("pulsado");
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

