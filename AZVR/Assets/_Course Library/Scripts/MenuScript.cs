using UnityEngine;

public class OvalOfficeVRMenu : MonoBehaviour
{
    [Header("Screens")]
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject infoPanel;

    [Header("Player Reset")]
    [SerializeField] private Transform xrOrigin;
    [SerializeField] private Transform resetPoint;

    [Header("Audio")]
    [SerializeField] private AudioSource uiAudio;
    [SerializeField] private AudioClip buttonClickSound;

    public void ShowMenu()
    {
        PlayClickSound();
        menuPanel.SetActive(true);
        infoPanel.SetActive(false);
    }

    public void ShowInfo()
    {
        PlayClickSound();
        menuPanel.SetActive(false);
        infoPanel.SetActive(true);
    }

    public void CloseMenu()
    {
        PlayClickSound();
        menuPanel.SetActive(false);
        infoPanel.SetActive(false);
    }

    public void ResetPlayerPosition()
    {
        PlayClickSound();

        if (xrOrigin != null && resetPoint != null)
        {
            xrOrigin.SetPositionAndRotation(resetPoint.position, resetPoint.rotation);
        }
    }

    public void PlayClickSound()
    {
        if (uiAudio != null && buttonClickSound != null)
        {
            uiAudio.PlayOneShot(buttonClickSound);
        }
    }
}