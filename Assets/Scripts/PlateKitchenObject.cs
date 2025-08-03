using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject {
    [SerializeField] private List<KitchenObjectSO> validKitchenObjectSOList;
    private List<KitchenObjectSO> kitchenObjectSOList;

    private void Awake() {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }

    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO) {
        if (!validKitchenObjectSOList.Contains(kitchenObjectSO)) {
            // a comida não é valida para colocar no prato
            return false;
        }
        if (kitchenObjectSOList.Contains(kitchenObjectSO)) {
            // já tem desse tipo
            return false;
        } else {
            kitchenObjectSOList.Add(kitchenObjectSO);
            return true;
        }
    }

}
