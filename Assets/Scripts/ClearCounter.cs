using UnityEngine;

public class ClearCounter : MonoBehaviour
{


    [SerializeField] private Transform tomatoPrefab;
    [SerializeField] private Transform counterTopPoint;

    public void Interact()
    {

        Debug.Log("Interagiu!");
        Transform tomatoTransform = Instantiate(tomatoPrefab, counterTopPoint);
        tomatoTransform.localPosition = Vector3.zero;
    }


}
