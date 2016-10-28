using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class endLevelMenu : MonoBehaviour {

    public Button playAgain;
    public Button mainMenu;
    public Text score;

    // Use this for initialization
    void Start () {
        score = score.GetComponent<Text>();
        score.text = (Data.Score.ToString().PadLeft(4, '0'));
        playAgain = playAgain.GetComponent<Button>();
        mainMenu = mainMenu.GetComponent<Button>();
    }

    public void PlayAgainPress()
    {
        SceneManager.LoadScene("game");
    }

    public void MainMenuPress()
    {

    }
}
