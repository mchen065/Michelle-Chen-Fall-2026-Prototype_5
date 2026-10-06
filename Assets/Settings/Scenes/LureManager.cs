using UnityEngine;

public class LureManager : MonoBehaviour
{
    public Transform human;

    public AudioSource[] lureSounds;

    public float maxDistance = 20f;

    public void PlayLure(int number)
    {
        AudioSource sound = lureSounds[number];

        float distance = Vector2.Distance(
            human.position,
            sound.transform.position
        );

        // Far away = louder
        // Close = quieter
        sound.volume = Mathf.Clamp01(
            distance / maxDistance
        );

        sound.Play();
    }
}

