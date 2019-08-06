using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Snow2 : MonoBehaviour
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
        if (other.layer == 8)
        {
            //add any other code here
            _snowValue += SnowAddAmount;
            _snowValue = Mathf.Clamp(_snowValue, minValue, maxValue);
            var normalisedVal = _snowValue / maxValue;
            normalisedVal *= multiplier;
            Materialtoadd.SetFloat("_SnowAmount", normalisedVal);
        }
    }
}
