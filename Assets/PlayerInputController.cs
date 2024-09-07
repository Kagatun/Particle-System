using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private NewControls _newControls;

    private void Awake()
    {
        _newControls = new NewControls();
        _newControls.Player.Move.performed += OnMove;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveDirection = context.action.ReadValue<Vector2>();
        Debug.Log(moveDirection);//Покажет от -1 до 1 в зависимости от нажатия. Так и будет выдаваться направление
    }

    private void OnEnable()
    {
        _newControls.Enable();
    }

    private void OnDisable()
    {
        _newControls.Disable();
    }
}
