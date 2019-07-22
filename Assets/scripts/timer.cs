using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float delayTime = 3.0f;
    private bool timerAlreadyRunning = false;
    Vector3 oldPos;

    private Color oldColour;


    // Use this for initialization
    void Start()
    {
        oldPos = transform.position;
        Color oldColour = this.GetComponent<MeshRenderer>().materials[0].color;

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator runTimer(float delayTime)
    {
        timerAlreadyRunning = true;
        yield return new WaitForSeconds(delayTime);
        //Vector3 currentPos =this.GetComponent<Transform> ().position;
        this.GetComponent<Transform>().position = new Vector3(0, 0, 5);
    }
    // response to collision event
    public void OnCollisionDetected()
    {
        if (!timerAlreadyRunning)
        {
            StartCoroutine(runTimer(delayTime));
            print("timer starteed");
        }
    }
    public void OnCollision2Detected()
    {
        this.GetComponent<Transform>().position = oldPos;
        this.GetComponent<MeshRenderer>().materials[0].color = oldColour;
        //this.GetComponent<MeshRenderer> ().material.color = oldColour;
    }
}

