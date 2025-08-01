using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject
{


    private List<KitchenObjectSO> kitchenObjectSOList;

    private void Awake()
    {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }

    public void AddIngredient(KitchenObjectSO kitchenObjectSO)
    {
        kitchenObjectSOList.Add(kitchenObjectSO);
    }    

}
