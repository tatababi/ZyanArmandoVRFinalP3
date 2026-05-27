using UnityEngine;

public class PhoneRingInteraction : MonoBehaviour
{
    [SerializeField] private AudioSource ringAudio;

    public void RingPhone()
    {
        if (ringAudio == null)
        {
            return;
        }

        if (ringAudio.isPlaying)
        {
            ringAudio.Stop();
        }

        ringAudio.Play();
    }
}