using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public bool SelectInput { get; private set; }
    public bool GetMenu { get; private set; }

    private PlayerInput _playerInput;

    private InputAction _selectAction;
    private InputAction _getMenu;


    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();
        _selectAction = _playerInput.actions["Submit"];
        _getMenu = _playerInput.actions["GetMenu"];

    }

    private void Update()
    {
        SelectInput = _selectAction.WasPressedThisFrame();
        GetMenu = _getMenu.WasPressedThisFrame();
    }
}
