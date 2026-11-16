using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class ProximityAudio : MonoBehaviour
{
    public Transform playerCamera;
    public float activationDistance = 6f;

    private AudioSource audioSource;
    private bool playerNearby;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerCamera == null)
            return;

        //calcular a dist do player pro objeto
        float distance = Vector3.Distance(
            playerCamera.position,
            transform.position
        );

        bool isNearby = distance <= activationDistance;

        //só alterar o som quando o estado muda
        if (isNearby == playerNearby)
            return;

        playerNearby = isNearby;

        if (playerNearby)
            audioSource.Play();
        else
            audioSource.Stop();
    }
}
