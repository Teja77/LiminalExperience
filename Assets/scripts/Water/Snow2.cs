using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Snow2 : MonoBehaviour
{
    public Material Material;
    public float SnowDelta;
    public float multiplier = 1f;

    private void OnParticleCollision(GameObject other)
    {
        var curSnowVal = Material.GetFloat("Vector1_D5319A04");
        curSnowVal = Mathf.Clamp(curSnowVal + (SnowDelta* multiplier), 0f, 0.2f);
        Material.SetFloat("Vector1_D5319A04", curSnowVal);
    }
}
