using UnityEngine;

public class PlayAudioOnClick : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        Debug.Log("click em: " + gameObject.name);

        audioSource.Play();
    }
}
