using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour
{
    int obstacleSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 1.5)
        {
            obstacleSpeed = 1;
        }
        if (transform.position.x >= 2.5)
        {
            obstacleSpeed = -1;
        }
        transform.Translate(obstacleSpeed * Time.deltaTime, 0, 0);
    }

}
