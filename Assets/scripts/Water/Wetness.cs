using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wetness : MonoBehaviour
{
    public Material Material;
    public float SnowDelta;
    public float multiplier = 1f;
    public float MaxRainAmount;
    private float _curRainVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        _curRainVal = Material.GetFloat("Vector1_2E42AE60");
        _curRainVal = Mathf.Clamp(_curRainVal + (SnowDelta * multiplier), 0f, MaxRainAmount);
        Material.SetFloat("Vector1_2E42AE60", _curRainVal);
    }
}
