using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class instructions : MonoBehaviour
{
    

    // Use this for initialization
    void Start()
    {
    }
    
    public void MainMenuPress()
    {
        SceneManager.LoadScene("menu");
    }
    public void MorePress()
    {
        SceneManager.LoadScene("more");
    }
    public void BackPress()
    {
        SceneManager.LoadScene("instructions");
    }
}
