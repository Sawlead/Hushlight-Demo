using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRotate : MonoBehaviour
{
    public int speed = 5;

    // Use this for initialization
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
