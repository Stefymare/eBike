using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
