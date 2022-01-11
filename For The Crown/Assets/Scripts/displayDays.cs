using UnityEngine;
using UnityEngine.UI;

public class displayDays : MonoBehaviour
{
    public Text daysText;
    public Day_Night_Cycle Days;

    void Update()
    {
        daysText.text = Days.getDays.ToString();
    }
}
