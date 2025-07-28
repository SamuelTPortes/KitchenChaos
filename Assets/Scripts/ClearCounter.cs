using UnityEngine;

public class ClearCounter : BaseCounter {


    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player) {
        if (kitchenObject == null) {
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        } else {
            //Entrega comida para o player
            kitchenObject.SetKitchenObjectParent(player);
        }
    }
}
