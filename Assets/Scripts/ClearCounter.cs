using UnityEngine;

public class ClearCounter : BaseCounter {


    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {

        if (!HasKitchenObject())
        {
            //Há uma comida aqui
            if (player.HasKitchenObject())
            {
                //Jogador está carregando algo
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //O Jogador não está segurando nada.
            }
        }
        else
        {
            //Há uma comida aqui
            if (player.HasKitchenObject())
            {
                //Jogador está carregando algo
            }
            else
            {
                //O Jogador não está segurando nada.
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
