using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public Button one;
    public Button two;
    public Button three;
    public Button instruction;

    // Use this for initialization
    void Start()
    {


    }
    public void OnePress()
    {
        SceneManager.LoadScene("level1");
    }
    public void TwoPress()
    {
        SceneManager.LoadScene("level2");
    }
    public void ThreePress()
    {
        SceneManager.LoadScene("level3");
    }
    public void FourPress()
    {
        SceneManager.LoadScene("level4");
    }
    public void FivePress()
    {
        SceneManager.LoadScene("level5");
    }
    public void SixPress()
    {
        SceneManager.LoadScene("level6");
    }
    public void InstructionPress()
    {
        SceneManager.LoadScene("instructions");
    }
    public void MainPress()
    {
        SceneManager.LoadScene("menu");
    }
    public void levelSelectPress()
    {
        SceneManager.LoadScene("levelSelect");
    }
    public void exitPress()
    {
        Application.Quit();
    }
}
