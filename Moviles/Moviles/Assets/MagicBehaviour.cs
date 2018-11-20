using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBehaviour : MonoBehaviour
{

    [SerializeField] private GameObject cam;
    [SerializeField] private GameObject pos;
    [SerializeField] private float speed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cam.transform.position = Vector3.Slerp(cam.transform.position, pos.transform.position, Time.deltaTime * speed);
            cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation, pos.transform.rotation, Time.deltaTime * speed);
        }
    }

}
