using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinCounter : MonoBehaviour
{
  Text coinCollect;
  TwoDMove moveScript;
    // Start is called before the first frame update
    void Start()
    {
        coinCollect = GetComponent<Text>();
        moveScript =
        GameObject.FindGameObjectWithTag("Player").GetComponent<TwoDMove>();

    }

    // Update is called once per frame
    void Update()
    {
      coinCollect.text = "Coins collected: " + moveScript.coins.ToString();
/* you can change “Coins collected: “ to whatever you want to display before the number of coins */

    }
}
