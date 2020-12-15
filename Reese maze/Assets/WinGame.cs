using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    ScoreTracker highScore;
    // Start is called before the first frame update
    void Start()
    {
      highScore = GameObject.FindGameObjectWithTag("scoretracker").GetComponent<ScoreTracker>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag.Equals("Player"))
        {
          int coins = other.gameObject.GetComponent<TwoDMove>().coins;
		      float time = Time.timeSinceLevelLoad;
          highScore.CalculateScore(coins, time);  /* replace highScore with your variable name, and CalculateScore with whatever you named your calculate function */

	         SceneManager.LoadScene("win scene");
        }
                                            }

}
