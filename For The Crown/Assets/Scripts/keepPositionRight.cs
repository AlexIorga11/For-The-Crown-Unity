using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepPositionRight : MonoBehaviour
{
    Vector2 position = new Vector2(110, -5);   

    void Update()
    {
        transform.position = position;
    }
}
