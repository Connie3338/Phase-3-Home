using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongPathController : MonoBehaviour
{
    public Vector2[] setPaths;
    public int currentPathIndex = 0;
    public float speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -0.1)
        {
            Destroy(this.gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, setPaths[currentPathIndex], speed * Time.deltaTime);
        
        
        
        if(transform.position.x == setPaths[currentPathIndex].x && transform.position.y == setPaths[currentPathIndex].y)
        {
            currentPathIndex++;
            if(currentPathIndex>=setPaths.Length)
            {
                currentPathIndex = 0;
            }
        }
    }
}
