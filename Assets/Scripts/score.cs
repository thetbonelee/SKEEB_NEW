using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{

    public int scoreValue = 0;
    public string level;
	public bool selectedMult = false;
    public TextMesh scoreboard;
    public TextMesh ballCount;
    public GameObject ball;
    public GameObject launcher;
    public GameObject[] launchers;
    public static int balls = 8;
	public static int multiplier = 1;
	public ParticleSystem ps;
	private bool psStarted = false;
	//private int multiplier = 1;
	//public static int prevScore = 0;
	public const int MAX_MULT = 8;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        launchers = GameObject.FindGameObjectsWithTag("Launcher");
        foreach (GameObject launch in launchers)
        {
            Destroy(launch);
        }

		int score = scoreValue * multiplier;
		Debug.Log (multiplier);

		if (selectedMult) {
			if (multiplier < MAX_MULT) {
				multiplier *= 2;
			}
		} else {
			multiplier = 1;
		}
		//Debug.Log (multiplier);
		//scoreValue *= multiplier;
        scoreboard.text = (int.Parse(scoreboard.text) + score).ToString().PadLeft(4, '0');
        if (scoreValue != 0)
        {
            ballCount.text = "BALLS: " + (--balls).ToString();
			this.GetComponent<AudioSource> ().Play ();
        }
        if (balls == 0)
        {
            balls = 8;
            Data.Level = level;
            Data.Score = int.Parse(scoreboard.text);
            if (int.Parse(scoreboard.text) >= 3000)
            {
                SceneManager.LoadScene("win");
            }
            else
            {
                SceneManager.LoadScene("lose");
            }
        }
        Instantiate(launcher, new Vector3(0.011f, 0.393f, -10.721f), transform.rotation);
        Invoke("Reload", 3);
    }

	void Update()
	{
		/*if (!psStarted) {
			StartPS ();
		}*/
	}

	void StartPS()
	{
		ps.Emit (2000);
		psStarted = true;
	}

	void SetSelected(bool select)
	{
		selectedMult = select;
	}
}