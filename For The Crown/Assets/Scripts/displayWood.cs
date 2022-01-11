using UnityEngine;
using UnityEngine.UI;

public class displayWood : MonoBehaviour
{
    public Text woodText;
    public Wood wood;
    public Image image;

    private void Update()
    {
        woodText.text = wood.CurrentWood.ToString();

        if (woodText.text == "0")
        {
            woodText.enabled = false;
            image.enabled = false;
        }

        else
        {
            woodText.enabled = true;
            image.enabled = true;
        }
    }
}
