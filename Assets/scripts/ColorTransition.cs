using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTransition : MonoBehaviour
{
    public Color Color1;
    public Color Color2;
    public float TransitionValue;
    private Material Mat;

    private void Start()
    {
        Mat = GetComponent<MeshRenderer>().sharedMaterials[0];
    }
    // Update is called once per frame
    void Update()
    {
        Mat.SetColor("_Color", Color.Lerp (Color1,Color2,TransitionValue));
        
    }
}
