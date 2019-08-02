using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Snow : MonoBehaviour
{
    public Material Materialtoadd;
    public float minValue;
    public float maxValue;
    public float SnowAddAmount;
    public float multiplier = 1f;

    private float _snowValue;

    private void Start()
    {
        Materialtoadd.SetFloat("_SnowAmount", _snowValue / maxValue);
    }

    void OnParticleCollision(GameObject other)
    {
        //add any other code here
        _snowValue += SnowAddAmount;
        _snowValue = Mathf.Clamp(_snowValue, minValue, maxValue);
        var normalisedVal = _snowValue / maxValue;
        normalisedVal *= multiplier;
        Materialtoadd.SetFloat("_SnowAmount", normalisedVal);
        Debug.Log("My Player’s been hit by particles.");
    }
}
