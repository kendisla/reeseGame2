using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScores : MonoBehaviour
{
  ScoreTracker scoreTrackerVariable;
  public Text currentScore;
  public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
      scoreTrackerVariable = GameObject.FindGameObjectWithTag("scoretracker" ).GetComponent<ScoreTracker>();
      currentScore.text = "Your score: " + scoreTrackerVariable.currentScore.ToString();
      highScore.text = "High score: " + scoreTrackerVariable.highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
