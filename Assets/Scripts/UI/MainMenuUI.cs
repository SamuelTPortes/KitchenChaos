using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour {

    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;


    private void Awake() {
        playButton.onClick.AddListener(() => {
            Loader.Load(Loader.Scene.GameScene);
        });

        quitButton.onClick.AddListener(() => {
            Application.Quit();
        });

        // !!! NOME DO CONTEUDO: C# DELEGATES !!!
        //
        // é igual a:
        // playButton.onClick.AddListener(playClick()){
        //   click
        // }
        //
        // private void playClick(){
        // 
        //}

        Time.timeScale = 1f;
    }
}
