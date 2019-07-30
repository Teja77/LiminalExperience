using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityModifier : MonoBehaviour
{
    private ParticleSystem ps;
    public float gravityValue = 0.0f;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var main = ps.main;
        main.simulationSpeed = gravityValue;
    }
}