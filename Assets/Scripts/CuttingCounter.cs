using Unity.VisualScripting;
using UnityEngine;

public class CuttingCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;
    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            //Há uma comida aqui
            if (player.HasKitchenObject()) {
                //Jogador está carregando algo
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {
                //O Jogador não está segurando nada.
            }
        } else {
            //Há uma comida aqui
            if (player.HasKitchenObject()) {
                //Jogador está carregando algo
            } else {
                //O Jogador não está segurando nada.
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player) {
        if (HasKitchenObject()) {
            // Eis aqui o Kitchen Object(A comida)
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}
