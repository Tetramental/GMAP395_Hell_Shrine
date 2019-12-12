using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    [SerializeField]
    private float rotateSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x >= 1f)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }
        else if (transform.localScale.x <= -1f)
        {
            transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
        }
    }
}