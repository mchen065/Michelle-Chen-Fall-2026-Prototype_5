using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] dangerZones;

    public GameObject humanWinScreen;
    public GameObject wendigoWinScreen;

    void Start()
    {
        Time.timeScale = 1;

        humanWinScreen.SetActive(false);
        wendigoWinScreen.SetActive(false);

        // Turn every danger zone off
        for (int i = 0; i < dangerZones.Length; i++)
        {
            dangerZones[i].SetActive(false);
        }

        // Pick one random danger zone
        int randomZone = Random.Range(0, dangerZones.Length);

        dangerZones[randomZone].SetActive(true);
    }

    public void HumanWins()
    {
        humanWinScreen.SetActive(true);

        Time.timeScale = 0;
    }

    public void WendigoWins()
    {
        wendigoWinScreen.SetActive(true);

        Time.timeScale = 0;
    }
}



