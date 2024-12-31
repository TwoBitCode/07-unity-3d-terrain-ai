using NUnit.Framework;
using TMPro;
using UnityEngine;

public class popMessageAction : MonoBehaviour, IAction
{

    [SerializeField] TextMeshProUGUI text = null;
    [SerializeField] string textContent = "Hi";
    [SerializeField] private RectTransform textBackground = null;  // Assign in Inspector

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (text != null)
        {
            text.enabled = false;
        }
        if (textBackground != null)
        {
            textBackground.gameObject.SetActive(false); // Hide by default
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableDisableActionFunc(bool isActionEnabled)
    {
        text.enabled = isActionEnabled;
        textBackground.gameObject.SetActive(isActionEnabled); // Hide by default
        text.text = textContent;
    }
}
