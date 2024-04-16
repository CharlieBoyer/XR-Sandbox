using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Button: MonoBehaviour
{
    public GameObject BallPrefab;
    public Transform BallOrigin;
    public Material DisableMaterial;
    public Material ActivableMaterial;

    public GameObject BallReference { get; private set; }
    
    private MeshRenderer _renderer;
    private XRSimpleInteractable _xrInteractable;
    private bool Active { get; set; }

    private void Awake()
    {
        _xrInteractable = GetComponent<XRSimpleInteractable>();
        _renderer = GetComponent<MeshRenderer>();
        _renderer.material = ActivableMaterial;
        Active = true;
    }

    public void OnSelect()
    {
        Debug.Log($"{gameObject.name} selected !");

        if (Active)
        {
            _renderer.material = DisableMaterial;
            _xrInteractable.enabled = false;
            BallReference = Instantiate(BallPrefab, BallOrigin);
            Active = false;
        }
    }

    public void ReEnable()
    {
        _renderer.material = ActivableMaterial;
        _xrInteractable.enabled = true;
        Active = true;
    }
}
