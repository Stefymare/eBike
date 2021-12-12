using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public float speed;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed == 0) { myText.color = Color.gray; }
                        else {
            if (speed < 10)
            {
                myText.color = Color.green;
            }
            else if (speed < 20)
            {
                myText.color = Color.yellow;
            }
            else myText.color = Color.red;
        };
        myText.text = speed.ToString();
    }
}
