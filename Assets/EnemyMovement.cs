using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //due to time its set bewteen points
    public Transform initposition;
    public Transform position2;
    bool inverse = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inverse)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, initposition.position, Time.deltaTime);
            if (Vector3.Distance(transform.position, initposition.position) < 0.4)
            {
                inverse = true;
            }
        }
        else
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, position2.position, Time.deltaTime);
            if (Vector3.Distance(transform.position, position2.position) < 0.4)
            {
                inverse = false;
            }
        }
        
    }
}
