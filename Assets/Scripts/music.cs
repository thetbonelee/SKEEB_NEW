using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

    static bool AudioBegin = false;
    void Awake()
    {
        if (!AudioBegin)
        {
            GetComponent<AudioSource>().Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        if (Application.loadedLevelName == "level1" || Application.loadedLevelName == "level2" || Application.loadedLevelName == "level3" || Application.loadedLevelName == "level4" || Application.loadedLevelName == "level5" || Application.loadedLevelName == "level6" || Application.loadedLevelName == "level7" || Application.loadedLevelName == "level8" || Application.loadedLevelName == "level9")
        {
            GetComponent<AudioSource>().Stop();
            AudioBegin = false;
        }
    }
}
