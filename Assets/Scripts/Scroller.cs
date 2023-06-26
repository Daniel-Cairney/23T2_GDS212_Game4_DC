using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float speed = 4f;
     private Vector3 StartPosition;

    private void Start()
    {
        StartPosition= transform.position;  
    }

    private void Update()
    {
        transform.Translate(translation:Vector3.down*speed*Time.deltaTime);
        if (transform.position.y < -10f)
        {
           transform.position= StartPosition;
        }
    }
}
