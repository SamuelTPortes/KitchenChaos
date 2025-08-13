using System;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    [SerializeField] private AudioClipRefsSO audioClipRefsSO;

    private void Start() {
        DeliveryManager.Instance.OnRecipeSuccess += DeliveryManager_OnRecipeSuccess;
        DeliveryManager.Instance.OnRecipeSuccess += DeliveryManager_OnRecipeFailed;
    }

    private void DeliveryManager_OnRecipeFailed(object sender, EventArgs e) {
        PlaySound(audioClipRefsSO.deliveryFail, Camera.main.transform.position);
    }

    private void DeliveryManager_OnRecipeSuccess(object sender, EventArgs e) {
        PlaySound(audioClipRefsSO.deliverySuccess, Camera.main.transform.position);
    }

    private void PlaySound(AudioClip[] audioClipArray, Vector3 position, float volume = 1f) {
        PlaySound(audioClipArray[UnityEngine.Random.Range(0, audioClipArray.Length)], position, volume);
    }

    private void PlaySound(AudioClip audioClip, Vector3 position, float volume = 1f) {
        AudioSource.PlayClipAtPoint(audioClip, position, volume);
    }
}
