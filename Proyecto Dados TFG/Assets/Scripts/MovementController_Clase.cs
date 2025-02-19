using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController_Clase : MonoBehaviour
{
    [Header("Variables filas")]

    [SerializeField] GameObject[] _rows;
    [SerializeField] GameObject _selectedRow;

    public PlayerControls playerControls;
    private InputAction move;
    private InputAction select;

    public bool jugando;
    void Awake()
    {
        playerControls = new PlayerControls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        move = playerControls.UI.Navigate;
        move.Enable();

        select = playerControls.UI.Submit;
        select.Enable();
        select.performed += Select;
    }

    public void OnDisable()
    {
        move.Disable();
        select.Disable();
    }


    public void Select(InputAction.CallbackContext context)
    {
        Debug.Log("pulsar");
    }

}
