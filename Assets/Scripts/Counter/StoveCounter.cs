using UnityEngine;

public class StoveCounter : BaseCounter {

    private enum State {
        Idle,
        Frying,
        Fried,
        Burned,
    }


    [SerializeField] private FryingRecipeSO[] fryingRecipeSOArray;
    private float fryingTimer;
    private FryingRecipeSO fryingRecipeSO;

    public void Update() {
        if (HasKitchenObject()) {
            fryingTimer += Time.deltaTime;
            if (fryingTimer > fryingRecipeSO.fryingTimerMax) {
                // cozinha
                fryingTimer = 0f;
                Debug.Log("Cozinhado");
                GetKitchenObject().DestroySelf();

                KitchenObject.SpawnKitchenObject(fryingRecipeSO.output, this);
            }
            Debug.Log(fryingTimer);
        }
    }

    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            //Há uma comida aqui
            if (player.HasKitchenObject()) {
                //Jogador está carregando algo
                if (HasRecipeWithInput(player.GetKitchenObject().GetKitchenObjectSO())) {
                    // Jogador carregando algo que pode ser cozinhado
                    player.GetKitchenObject().SetKitchenObjectParent(this);
                    fryingRecipeSO = GetFryingRecipeSOWithInput(GetKitchenObject().GetKitchenObjectSO());
                }
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

    private bool HasRecipeWithInput(KitchenObjectSO inputKitchenObjectSO) {
        FryingRecipeSO fryingRecipeSO = GetFryingRecipeSOWithInput(inputKitchenObjectSO);
        return fryingRecipeSO != null;
    }

    private KitchenObjectSO GetOutputForInput(KitchenObjectSO inputKitchenObjectSO) {
        FryingRecipeSO fryingRecipeSO = GetFryingRecipeSOWithInput(inputKitchenObjectSO);
        if (fryingRecipeSO != null) {
            return fryingRecipeSO.output;
        } else {
            return null;
        }
    }

    private FryingRecipeSO GetFryingRecipeSOWithInput(KitchenObjectSO inputKitchenObjectSO) {
        foreach (FryingRecipeSO fryingRecipeSO in fryingRecipeSOArray) {
            if (fryingRecipeSO.input == inputKitchenObjectSO) {
                return fryingRecipeSO;
            }
        }
        return null;
    }

}
