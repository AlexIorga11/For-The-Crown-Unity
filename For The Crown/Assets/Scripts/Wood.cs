using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public int CurrentWood;

    private void Start()
    {
        CurrentWood = 0;
    }

    public bool checkIfCanTake(int gold)
    {
        if (CurrentWood - gold >= 0)
        {
            takeWood(gold);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void addWood(int gold)
    {
        CurrentWood += gold;
    }

    public void takeWood(int gold)
    {
        CurrentWood -= gold;
    }
}
