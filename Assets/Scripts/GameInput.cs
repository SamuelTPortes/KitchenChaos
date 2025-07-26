using System;
using Unity.Multiplayer.Center.Common.Analytics;
using UnityEngine;

public class GameInput : MonoBehaviour {


    public event EventHandler OnInteractAction;
    private PlayerInputActions playerInputActions;
    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();


        playerInputActions.Player.Interact.performed += Interact_perfomed;
    }

    private void Interact_perfomed(UnityEngine.InputSystem.InputAction.CallbackContext obj) {
        // if (OnInteractAction != null) {
        //     OnInteractAction(this, EventArgs.Empty);
        // }
        OnInteractAction?.Invoke(this, EventArgs.Empty); // Mesma coisa do código de cima
    }
    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;
    }
}
