using UnityEngine;

public class ClearCounter : MonoBehaviour {


    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact() {

        Debug.Log("Interagiu!");
        Transform kitcheObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        kitcheObjectTransform.localPosition = Vector3.zero;
    }


}
