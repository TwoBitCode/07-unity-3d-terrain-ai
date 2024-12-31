using System;
using TMPro;
using Unity.Burst;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionOnKeyPress : MonoBehaviour
{
    [SerializeField] GameObject OtherObject;
    [SerializeField] InputAction ActionOnPress;
    private IAction action;
    [SerializeField] private MonoBehaviour ActionScript;

    private bool isActionEnabled = false;

    [SerializeField] float radiusToWatch = 5f;

    private void OnEnable()
    {
        ActionOnPress.Enable();
    }
    private void OnDisable()
    {
        ActionOnPress.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Use `action` as an IAction.
        action = ActionScript as IAction;

    }

    // Update is called once per frame
    void Update()
    {
        if (ActionOnPress.WasPressedThisFrame() && DistanceToTarget() < radiusToWatch)
        {
            isActionEnabled = !isActionEnabled;
            action.EnableDisableActionFunc(isActionEnabled);
        }
        else if(DistanceToTarget() > radiusToWatch)
        {
            action.EnableDisableActionFunc(false);
        }
    }

    private float DistanceToTarget()
    {
        return Vector3.Distance(transform.position, OtherObject.transform.position);
    }
}
