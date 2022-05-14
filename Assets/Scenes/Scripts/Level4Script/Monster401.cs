using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster401 : MonoBehaviour
{
    public Transform[] positions1;

    public int index = 0;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    void Moving()
    {
        transform.Translate(speed * Time.deltaTime * (positions1[index].position - transform.position).normalized);
        if (Vector3.Distance(positions1[index].position, transform.position) < 0.5f)
        {
            index++;
            if (index == 4)
            {
                index = 0;
                index++;
            }
        }
    }
}
