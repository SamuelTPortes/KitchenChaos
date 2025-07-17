using Unity.Multiplayer.Center.Common.Analytics;
using UnityEngine;

public class GameInput : MonoBehaviour {

    private PlayerInputActions playerInputActions;
    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();


        playerInputActions.Player.Interact.performed += interact_performed;
    }
    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        inputVector = inputVector.normalized;

        return inputVector;
    }
}
