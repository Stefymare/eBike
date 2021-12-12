using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This code should be added into the level manager in order to see if the game is ended and to check the average speed

public class FailQuotes : MonoBehaviour
{
    public float AvgSpeed;
    public float AvgSuccesrate;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndQuote()
    {
        if ((AvgSpeed < 20) && (AvgSuccesrate > 90)) { myText.text = "That's perfect. Keep doing the good work!"; }
        else if ((AvgSpeed >= 20) | (AvgSuccesrate <= 90)) {myText.text = "Try again. But this time slower."; }

    }
}
