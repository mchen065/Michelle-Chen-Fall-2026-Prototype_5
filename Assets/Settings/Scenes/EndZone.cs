using UnityEngine;

public class EndZone : MonoBehaviour
{
    public Manager gameManager;

    public bool isHome;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isHome)
            {
                gameManager.HumanWins();
            }
            else
            {
                gameManager.WendigoWins();
            }
        }
    }
}

