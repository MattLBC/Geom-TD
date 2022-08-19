using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class LivesUI : MonoBehaviour
{
    public TMP_Text livesText;

    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.Lives == 1)
        {
            livesText.text = PlayerStats.Lives + " LIFE";
            return;
        }
        livesText.text = PlayerStats.Lives + " LIVES";
    }
}
