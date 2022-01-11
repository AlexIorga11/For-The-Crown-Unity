using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Hp_Indicator_script : MonoBehaviour
{
    private float health = 100;
    public PostProcessVolume volume;
    private Vignette vignette;

    private void Awake()
    {
        volume.profile.TryGetSettings(out vignette);
    }

    public void SetHealth(float health)
    {
        this.health = health;
    }

    void Update()
    {
        if (health >= 0)
        {
            float i = health / 100f;
            vignette.intensity.value = 1f - i;
            //Debug.Log(i);
        }
    }
}
