using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class snow1 : MonoBehaviour
{
    public Material Materialtoadd;
    public float minValue;
    public float maxValue;
    public float SnowAddamount;
    public float multiplier = 1f;

    private float snowValue;
    

    private void Start()
    {
        Materialtoadd.SetFloat("Vector1_D5319A04", snowValue/maxValue);
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.layer == 10)
        {

            //add any other code here
            //_snowValue += 1;
            //_snowValue = Mathf.Clamp(_snowValue, minValue, maxValue);
            //minValue = Mathf.Clamp(minValue, 0, 1);
            snowValue += SnowAddamount;
            snowValue = Mathf.Clamp(snowValue, minValue, maxValue);
            var normalisedVal = snowValue / maxValue;
            normalisedVal *= multiplier;
            Materialtoadd.SetFloat("Vector1_D5319A04", normalisedVal);
            Debug.Log("My Player’s been hit by particles.");
        }
    }
}
