using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    int type;
    float size;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.6f, 2.6f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 5);

        if (type == 1)
        {
            size = 2.0f;
        }
        else if (type == 2)
        {
            size = 1.0f;
        }
        else if (type == 3)
        {
            size = 1.5f;
        }
        else
        {
            size = 0.5f;
        }

        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
