using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepPossitionLeft : MonoBehaviour
{   
    Vector2 position = new Vector2(20, -5);

    void Update()
    {
        transform.position = position;
    }
}
