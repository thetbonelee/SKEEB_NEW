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
       
        one = one.GetComponent<Button>();
        two = two.GetComponent<Button>();
        three = three.GetComponent<Button>();
        instruction = instruction.GetComponent<Button>();

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
    public void InstructionPress()
    {
        SceneManager.LoadScene("instructions");
    }
}
