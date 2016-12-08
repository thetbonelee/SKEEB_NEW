using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class medals : MonoBehaviour {
    public Sprite gold;
    public Sprite silver;
    public Sprite bronze;
	// Use this for initialization
	void Start () {
        if (Data.Score >= 5000)
            GetComponent<Image>().sprite = gold;
        else if (Data.Score < 5000 && Data.Score >= 3500)
            GetComponent<Image>().sprite = silver;
        else
            GetComponent<Image>().sprite = bronze;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
