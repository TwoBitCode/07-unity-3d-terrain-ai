using NUnit.Framework;
using UnityEngine;

public class LightAction : MonoBehaviour, IAction
{

    [SerializeField] Light lightSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightSource.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableDisableActionFunc(bool isActionEnabled)
    {
        lightSource.enabled = isActionEnabled;
        Debug.Log("is light: " + lightSource.enabled.ToString());
    }
}
