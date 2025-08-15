using UnityEngine;

public class PlayerSounds : MonoBehaviour {


    private Player player;
    private float footsteepTimer;
    private float footsteepTimerMax = .25f;
    private void Awake() {
        player = GetComponent<Player>();
    }

    private void Update() {
        footsteepTimer -= Time.deltaTime;
        if (footsteepTimer < 0f) {
            footsteepTimer = footsteepTimerMax;

            if (player.IsWalking()) {
                float volume = 1f;
                SoundManager.Instance.PlayFootstepsSound(player.transform.position, volume);
            }
        }
    }
}