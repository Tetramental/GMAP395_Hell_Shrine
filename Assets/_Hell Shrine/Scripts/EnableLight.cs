using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLight : MonoBehaviour
{
    [SerializeField]
    private GameObject object1;
    [SerializeField]
    private GameObject object2;
    [SerializeField]
    private GameObject object3;

    // Start is called before the first frame update
    void Start()
    {
        object1.SetActive(false);
        object2.SetActive(false);
        object3.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        object1.SetActive(true);
        object2.SetActive(true);
        object3.SetActive(true);
    }
}