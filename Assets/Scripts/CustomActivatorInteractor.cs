using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CustomActivatorInteractor: XRRayInteractor
{
    private List<UnityEngine.XR.InputDevice> _leftHandDevices = new ();
    private List<UnityEngine.XR.InputDevice> _rightHandDevices = new ();

    private bool _leftTrigger;
    private bool _rightTrigger;

    private GameObject _activatedObject;
    
    /* protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);
        
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.LeftHand, _leftHandDevices);
        UnityEngine.XR.InputDevices.GetDevicesAtXRNode(UnityEngine.XR.XRNode.RightHand, _rightHandDevices);

        UnityEngine.XR.InputDevice rightHand = _rightHandDevices.First();
        UnityEngine.XR.InputDevice leftHand = _leftHandDevices.First();

        if ((leftHand.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out _leftTrigger) && _leftTrigger)
            || (rightHand.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out _rightTrigger) && _rightTrigger))
        {
            Debug.Log("Receive Trigger !");
            _activatedObject = args.interactableObject.transform.gameObject;
            _activatedObject.SendMessage("OnActivated");
        }
    } */
}
