using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("Properties")]
    public float cameraSpeed = 2.5f;
    [Header("State")]
    [SerializeField]
    private Transform mainCameraTransform;

    void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (GetKeyDown())
        {
            float newPosition = -cameraSpeed * Time.deltaTime;
            mainCameraTransform.Translate(new Vector3(0.0f, newPosition, 0.0f));
        }
        else if (GetKeyUp())
        {
            float newPositon = cameraSpeed * Time.deltaTime;
            mainCameraTransform.Translate(new Vector3(0.0f, newPositon, 0.0f));
        }
    }

    private bool GetKeyDown()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            return true;
        }

        return false;
    }

    private bool GetKeyUp()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            return true;
        }

        return false;
    }
}
