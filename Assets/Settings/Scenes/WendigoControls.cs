using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class WendigoControls : MonoBehaviour
{
    public Transform human;

    public AudioSource northSound;
    public AudioSource eastSound;
    public AudioSource southSound;
    public AudioSource westSound;

    public TMP_Text selectedText;

    private int selected = 0;

    void Update()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            selected = 0;
            selectedText.text = "NORTH";
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            selected = 1;
            selectedText.text = "EAST";
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            selected = 2;
            selectedText.text = "SOUTH";
        }

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            selected = 3;
            selectedText.text = "WEST";
        }

        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            PlaySound();
        }
    }

    void PlaySound()
    {
        AudioSource sound = northSound;

        if (selected == 1)
            sound = eastSound;

        if (selected == 2)
            sound = southSound;

        if (selected == 3)
            sound = westSound;

        float distance = Vector2.Distance(
            human.position,
            sound.transform.position
        );

        // Far away sounds louder like the legends
        sound.volume = Mathf.Clamp01(distance / 15f);

        sound.Play();
    }
}
