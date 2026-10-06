using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class WendigoControls : MonoBehaviour
{
    public LureManager lureManager;

    public Button northButton;
    public Button eastButton;
    public Button southButton;
    public Button westButton;

    private int selectedSound = 0;

    void Start()
    {
        northButton.Select();
    }

    void Update()
    {

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            selectedSound = 0;
            northButton.Select();
        }


        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            selectedSound = 1;
            eastButton.Select();
        }


        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            selectedSound = 2;
            southButton.Select();
        }


        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            selectedSound = 3;
            westButton.Select();
        }


        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            lureManager.PlayLure(selectedSound);
        }
    }
}




