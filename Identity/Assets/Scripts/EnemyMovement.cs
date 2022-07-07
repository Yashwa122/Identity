using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public Transform theEnemies;   
    public Transform startPoint;
    public Transform endPoint;

    public float speed;

    bool goingBack = false;

    // Start is called before the first frame update
    void Start()
    {
        theEnemies.position = startPoint.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (goingBack == false)
        {
            theEnemies.position = Vector3.MoveTowards(theEnemies.position, endPoint.position, speed);

            if (theEnemies.position == endPoint.position)
            {
                goingBack = true;
            }

        }
        else
        {
            theEnemies.position = Vector3.MoveTowards(theEnemies.position, startPoint.position, speed);

            if (theEnemies.position == startPoint.position)
            {
                goingBack = false;
            }
        }
    }
}
