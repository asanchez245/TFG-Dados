using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;

    public bool SelectInput {  get; private set; }

    private PlayerInput _playerInput;

    private InputAction _selectAction;


    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();
        _selectAction = _playerInput.actions["Submit"];
    }

    private void Update()
    {
        SelectInput = _selectAction.WasPressedThisFrame();
    }
}
