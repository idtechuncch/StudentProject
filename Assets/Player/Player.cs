using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
 * Here's a quick reference for the inputs:
 *
 * These return bools:
 *
 * * Pad click: OVRInput.Get(OVRInput.Button.PrimaryTouchpad) or OVRInput.Get(OVRInput.Button.One)
 * * Back button: OVRInput.GetDown(OVRInput.Button.Back) or OVRInput.Get(OVRInput.Button.Two)
 * * Trigger button: OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger)
 *
 * This returns a Vector2:
 *
 * * Pad touching: OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad)
 *
 * These return a Quaternion:
 *
 * * Controller orientation: OVRInput.GetLocalControllerRotation(OVRInput.Controller.All)
 * * Headset orientation: UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.CenterEye)
 * * or you can shorten this to InputTracking.GetLocalRotation(XRNode.CenterEye) if you add "using UnityEngine.XR;" at the top of the file.0
 */
