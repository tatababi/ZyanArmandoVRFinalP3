using UnityEngine;

public class OvalOfficeVRMenu : MonoBehaviour
{
    [Header("Menu Panels")]
    [SerializeField] private GameObject menuRoot;
    [SerializeField] private GameObject infoPanel;
    [SerializeField] private GameObject labelsRoot;

    [Header("Player Reset")]
    [SerializeField] private Transform xrOrigin;
    [SerializeField] private Transform resetPoint;

    [Header("Lighting")]
    [SerializeField] private Light[] roomLights;

    public void OpenMenu()
    {
        SetActive(menuRoot, true);
    }

    public void CloseMenu()
    {
        SetActive(menuRoot, false);
    }

    public void ToggleMenu()
    {
        if (menuRoot == null)
        {
            return;
        }

        menuRoot.SetActive(!menuRoot.activeSelf);
    }

    public void ToggleInfoPanel()
    {
        ToggleObject(infoPanel);
    }

    public void ToggleLabels()
    {
        ToggleObject(labelsRoot);
    }

    public void ToggleLights()
    {
        if (roomLights == null || roomLights.Length == 0)
        {
            return;
        }

        bool shouldTurnOn = false;
        foreach (Light roomLight in roomLights)
        {
            if (roomLight != null && !roomLight.enabled)
            {
                shouldTurnOn = true;
                break;
            }
        }

        foreach (Light roomLight in roomLights)
        {
            if (roomLight != null)
            {
                roomLight.enabled = shouldTurnOn;
            }
        }
    }

    public void ResetPlayerPosition()
    {
        if (xrOrigin == null || resetPoint == null)
        {
            return;
        }

        xrOrigin.SetPositionAndRotation(resetPoint.position, resetPoint.rotation);
    }

    private static void ToggleObject(GameObject target)
    {
        if (target != null)
        {
            target.SetActive(!target.activeSelf);
        }
    }

    private static void SetActive(GameObject target, bool isActive)
    {
        if (target != null)
        {
            target.SetActive(isActive);
        }
    }
}
