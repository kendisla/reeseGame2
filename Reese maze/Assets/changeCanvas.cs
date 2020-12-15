using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCanvas : MonoBehaviour
{
  public GameObject oldCanvas;
  public GameObject newCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SwitchCanvas() {
        oldCanvas.SetActive(false);
        newCanvas.SetActive(true);
    }
}
