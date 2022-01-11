using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public int CurrentStone;

    private void Start()
    {
        CurrentStone = 0;
    }

    public bool checkIfCanTake(int stone)
    {
        if (CurrentStone - stone >= 0)
        {
            takeStone(stone);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void addStone(int gold)
    {
        CurrentStone += gold;
    }

    public void takeStone(int gold)
    {
        CurrentStone -= gold;
    }
}
