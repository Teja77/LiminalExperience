using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class snow1 : MonoBehaviour
{
    public Material Materialtoadd;
    public float minValue;
    public float maxValue;
    public float _snowValue = 1f;
  

    private void Start()
    {
        Materialtoadd.SetFloat("Vector1_D5319A04", minValue / maxValue);
    }

    void OnParticleCollision(GameObject other)
    {
        //add any other code here
        _snowValue += 1;
        _snowValue = Mathf.Clamp(_snowValue, minValue, maxValue);
        
        Materialtoadd.SetFloat("Vector1_D5319A04", _snowValue / maxValue);
        Debug.Log("My Player’s been hit by particles.");
    }
}
