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
                if (player.GetKitchenObject() is PlateKitchenObject)
                {
                    //Jogador está segurando um pratinho
                    PlateKitchenObject plateKitchenObject = player.GetKitchenObject() as PlateKitchenObject;
                    plateKitchenObject.AddIngredient(GetKitchenObject().GetKitchenObjectSO());
                    GetKitchenObject().DestroySelf();
                }
            }
            else
            {
                //O Jogador não está segurando nada.
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
