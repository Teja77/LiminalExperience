using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.layer == 10)
        {
            //Destroy(other.gameObject);
            GetComponent<AudioSource>().Play(); 

            
        }
    }
}
