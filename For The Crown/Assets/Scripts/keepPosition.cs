using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepPosition : MonoBehaviour
{
    Vector2 position = new Vector2(4, -4);

    // Update is called once per frame
    void Update()
    {
        transform.position = position;
    }
}
