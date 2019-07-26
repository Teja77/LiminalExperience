﻿using System.Collections;
using UnityEngine;


public class TeleportaManager : MonoBehaviour
{
    public Vector2 joystick;
    public float speed;
    public GameObject centerEye;
    public GameObject pObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        joystick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

        transform.eulerAngles = new Vector3(0, centerEye.transform.localEulerAngles.y, 0);
        transform.Translate(Vector3.forward * speed * joystick.y * Time.deltaTime);
        transform.Translate(Vector3.right * speed * joystick.x * Time.deltaTime);

        pObject.transform.position = Vector3.Lerp(pObject.transform.position, transform.position, 10f * Time.deltaTime);
    }
}
