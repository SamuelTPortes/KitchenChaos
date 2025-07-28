using UnityEngine;

public class BaseCounter : MonoBehaviour {

    public virtual void Interact(Player player) {
        Debug.LogError("BaseCounter.Interact();");
    }

}
