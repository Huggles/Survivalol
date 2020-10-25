using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    Camera cameraComponent;
    // Start is called before the first frame update
    void Start()
    {
        cameraComponent = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraComponent.orthographicSize += (0.5f * Time.deltaTime);
        Console.WriteLine(cameraComponent.orthographicSize);
    }
}
