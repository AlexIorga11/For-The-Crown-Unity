using UnityEngine;
using UnityEngine.UI;

public class displayGold : MonoBehaviour
{
    public Text goldText;
    public Gold gold;
    public Image image;

    private void Update()
    {
        goldText.text = gold.CurrentGold.ToString();
        
        if(goldText.text == "0")
        {
            goldText.enabled = false;
            image.enabled = false;
        }

        else
        {
            goldText.enabled = true;
            image.enabled = true;
        }        
    }
}
