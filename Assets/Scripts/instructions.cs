using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class instructions : MonoBehaviour
{
    
    public Button mainMenu;

    // Use this for initialization
    void Start()
    {
        mainMenu = mainMenu.GetComponent<Button>();
    }
    
    public void MainMenuPress()
    {
        SceneManager.LoadScene("menu");
    }
}
