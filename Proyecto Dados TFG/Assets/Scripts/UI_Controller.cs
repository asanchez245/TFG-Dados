using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] GameObject[] _botonVolver;
    GameObject _lastSelectedGO;
    [SerializeField] GameObject _panelPausa;
    [SerializeField] GameObject _panelControles;
    [SerializeField] GameObject _panelOpciones;
    [SerializeField] GameObject _panelAudio;

    //public float _delayInput;


    public bool isPaused;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //_delayInput = .5f;
        _panelPausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //_delayInput -= Time.deltaTime;
        if (InputManager.instance.GetMenu) //pulsa start o esc
        {
            if(_panelPausa != null && !isPaused)
            {
                ShowPausePanel();
            }
            else
            {
                HideAllPanels();            
            }

        }
        
    }

    public void ShowPausePanel()
    {
        _lastSelectedGO = EventSystem.current.currentSelectedGameObject;
        EventSystem.current.SetSelectedGameObject(_botonVolver[0]);
        Time.timeScale = 0;
        _panelPausa.SetActive(true);
        isPaused = true;
    }
    public void HideAllPanels()
    {
        EventSystem.current.SetSelectedGameObject(_lastSelectedGO);
        Time.timeScale = 1.0f;
        _panelPausa.SetActive(false);
        _panelAudio.SetActive(false);
        _panelControles.SetActive(false);
        _panelOpciones.SetActive(false);
        isPaused = false;
    }

    public void ShowOptionsPanel()
    {
        //_lastSelectedGO = EventSystem.current.currentSelectedGameObject;
        EventSystem.current.SetSelectedGameObject(_botonVolver[1]);
    }
    //public void HideOptionsPanel()
    //{
    //    EventSystem.current.SetSelectedGameObject(_lastSelectedGO);
    //    //se esconde el panel a traves del INSPECTOR de UNITY ojo
    //}
    public void ShowAudioPanel()
    {
        //_lastSelectedGO = EventSystem.current.currentSelectedGameObject;
        EventSystem.current.SetSelectedGameObject(_botonVolver[2]);
    }
    //public void HideAudioPanel()
    //{
    //    EventSystem.current.SetSelectedGameObject(_lastSelectedGO);
    //    //se esconde el panel a traves del INSPECTOR de UNITY ojo
    //}
    public void ShowControlsPanel()
    {
        //_lastSelectedGO = EventSystem.current.currentSelectedGameObject;
        EventSystem.current.SetSelectedGameObject(_botonVolver[3]);
    }
    //public void HideControlsPanel()
    //{
    //    EventSystem.current.SetSelectedGameObject(_lastSelectedGO);
    //    //se esconde el panel a traves del INSPECTOR de UNITY ojo
    //}

    public void ShowPlayPanel() //funcion solo del menu inicial del juego
    {
        EventSystem.current.SetSelectedGameObject(_botonVolver[0]);
        //_lastSelectedGO = EventSystem.current.currentSelectedGameObject;
    }
}
