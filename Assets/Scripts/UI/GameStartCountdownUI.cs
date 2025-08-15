using System;
using TMPro;
using UnityEngine;

public class GameStartCountdownUI : MonoBehaviour {


    [SerializeField] private TextMeshProUGUI countdownText;

    private void Start() {
        GameManager.Instance.OnStateChanged += GameManager_OnStateChanged;
    }

    private void GameManager_OnStateChanged(object sender, EventArgs e) {
        if (GameManager.Instance.IsCountdownToStartActive()) {
            Show();
        } else {
            Hide();
        }
    }

    private void Update() {
        countdownText.text = Mathf.Ceil(GameManager.Instance.GetCountdownToStartTimer()).ToString(); // Diversos formatos de mostrar o texto no método ToString(), ex: "F2", "#.##"
    }
    private void Show() {
        gameObject.SetActive(true);
    }

    private void Hide() {
        gameObject.SetActive(false);
    }
}