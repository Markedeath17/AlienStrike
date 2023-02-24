using UnityEngine;

public class InputController : MonoBehaviour
{
    private InputSystem _inputSystem;

    private IControllable _controllable;

    private Vector2 InputMovement => _inputSystem.Player.Keyboard.ReadValue<Vector2>();

    private void Awake()
    {
        _inputSystem = new();
        _inputSystem.Enable();

        _controllable = GetComponent<IControllable>();

        if(_controllable == null)
        {
            throw new System.Exception("IControllable has not been on this object");
        }
    }

    private void Update()
    {
        _controllable.Move(InputMovement);
    }
}
