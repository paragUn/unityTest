using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerControls : MonoBehaviour
{
    private int laserSpeed = 15;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);   

        if(transform.position.y >=5.7)
        {
            Destroy(this.gameObject, 1);
        }
    }
}
