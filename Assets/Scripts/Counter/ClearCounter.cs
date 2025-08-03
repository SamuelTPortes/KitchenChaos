using UnityEngine;

public class ClearCounter : BaseCounter {


    [SerializeField] private KitchenObjectSO kitchenObjectSO;

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
                if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject)) {
                    //Jogador está segurando um pratinho
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO())) {
                        GetKitchenObject().DestroySelf();
                    }
                } else {
                    // O jogador não está segurando um prato mas sim outra coisa
                    if (GetKitchenObject().TryGetPlate(out plateKitchenObject)) {
                        // O counter está "segurando"/está com um prato em cima

                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectSO())) {
                            player.GetKitchenObject().DestroySelf();
                        }
                    }
                }
            } else {
                //O Jogador não está segurando nada.
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
