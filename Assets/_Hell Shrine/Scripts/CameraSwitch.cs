using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private Camera firstPersonCamera;
    [SerializeField]
    private Camera staticCamera;
    [SerializeField]
    private Camera flyByCamera;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera.enabled = true;
        staticCamera.enabled = false;
        flyByCamera.enabled = false;
    }

    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        staticCamera.enabled = false;
        flyByCamera.enabled = false;
    }

    public void ShowStaticView()
    {
        staticCamera.enabled = true;
        firstPersonCamera.enabled = false;
        flyByCamera.enabled = false;
    }

    public void ShowFlyByView()
    {
        flyByCamera.enabled = true;
        firstPersonCamera.enabled = false;
        staticCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ShowFirstPersonView();
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ShowStaticView();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ShowFlyByView();
        }
    }
}