using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlyCam : MonoBehaviour
{
    float verticalAngle = 0;

    [SerializeField] float speed;
    [SerializeField] GameObject cameraAxis;
    [SerializeField] float verticalRange = 90;

    void Update()
    {

        float horRot = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float verRot = -Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        verticalAngle += verRot;
        
        verticalAngle = Mathf.Clamp(verticalAngle, -verticalRange, verticalRange);

        cameraAxis.transform.localEulerAngles = new Vector3(verticalAngle, 0, 0);

        transform.Rotate(0, horRot, 0);
}
}

