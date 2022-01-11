using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessingscript : MonoBehaviour
{
    public PostProcessVolume volume;
    private Vignette vignette;
    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out vignette);
        vignette.smoothness.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        vignette.smoothness.value = 1f;
    }
}
