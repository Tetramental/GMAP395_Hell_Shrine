using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject playerMovement;
    [SerializeField]
    private GameObject flyByCamMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement.GetComponent<PlayerMovement>().enabled = true;
        flyByCamMovement.GetComponent<SimpleCameraController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerMovement.GetComponent<PlayerMovement>().enabled = true;
            flyByCamMovement.GetComponent<SimpleCameraController>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerMovement.GetComponent<PlayerMovement>().enabled = false;
            flyByCamMovement.GetComponent<SimpleCameraController>().enabled = true;
        }
    }
}
