using Liminal.SDK.VR.Avatars;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handRotation : MonoBehaviour
{
    public VRAvatarHand Hand;
    // Update is called once per frame
   
    
    public GameObject ObjectToRotate;

    void Update()
    {
        var handRotation = Hand.Anchor.rotation;

        /*
        var primaryHand = VRAvatar.Active.PrimaryHand;
        primaryHand.Anchor.Rotation
        */
        ObjectToRotate.transform.rotation = handRotation;
    }
}
