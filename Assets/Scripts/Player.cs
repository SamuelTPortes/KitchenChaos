using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {

        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("Hello, World!");
        }

    }
}
