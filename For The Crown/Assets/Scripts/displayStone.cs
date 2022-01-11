using UnityEngine;
using UnityEngine.UI;

public class displayStone : MonoBehaviour
{
    public Text stoneText;
    public Stone stone;
    public Image image;

    private void Update()
    {
        stoneText.text = stone.CurrentStone.ToString();

        if (stoneText.text == "0")
        {
            stoneText.enabled = false;
            image.enabled = false;
        }

        else
        {
            stoneText.enabled = true;
            image.enabled = true;
        }
    }
}
