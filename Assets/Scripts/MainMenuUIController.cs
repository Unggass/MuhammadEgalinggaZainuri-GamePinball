using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditSceneButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditSceneButton.onClick.AddListener(CreditScene);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("PinballGame");
    }

    private void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
