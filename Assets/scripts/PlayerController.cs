using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.Core;
using Liminal.SDK.Input;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;
using Liminal.Core.Fader;

public class PlayerController : MonoBehaviour
{
    public IVRInputDevice Device;
    public LayerMask LayerToHit;
    public float FadeTime;

    private Coroutine _teleportRoutine;

    // Start is called before the first frame update
    void Start()
    {
        Device = VRDevice.Device.PrimaryInputDevice;

    }

    // Update is called once per frame
    void Update()
    {
        if (Device.GetButtonDown(VRButton.One))
         {
            MoveRaycast();
           
            
        }
    }

    private void MoveRaycast()
    {
        var pointer = Device.Pointer;

        if (Physics.Raycast(pointer.Transform.position, pointer.Transform.forward, out RaycastHit hit, 100f, LayerToHit))
        {
           
            if (_teleportRoutine != null)
                return;

            _teleportRoutine = StartCoroutine(TeleportCoro(hit.point));
        }
    }
    


    private IEnumerator TeleportCoro(Vector3 teleportPoint)
    {
        ScreenFader.Instance.FadeToBlack(FadeTime);

        yield return ScreenFader.Instance.WaitUntilFadeComplete();

        transform.position = teleportPoint;
        ScreenFader.Instance.FadeToClear(FadeTime);

        _teleportRoutine = null;
    }
}
