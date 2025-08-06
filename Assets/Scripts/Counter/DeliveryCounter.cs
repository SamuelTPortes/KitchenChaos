using UnityEngine;

public class DeliveryCounter : BaseCounter {

    public override void Interact(Player player) {
        if (player.HasKitchenObject()) {
            if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject)) {
                // Apenas acessa pratos
                player.GetKitchenObject().DestroySelf();
            }
        }
    }

}
