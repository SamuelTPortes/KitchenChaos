using Unity.VisualScripting;
using UnityEngine;

public class CuttingCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(Player player) {
        // TEM QUE SER O MESMO CÓDIGO QUE O ELI FOR ESCREVER
        Debug.Log("Mesmo código");
    }

    public override void InteractAlternate(Player player) {
        if (HasKitchenObject()) {
            // Eis aqui o Kitchen Object(A comida)
            GetKithenObject(kitchenObject).DestroySelf();
        }
    }
}
