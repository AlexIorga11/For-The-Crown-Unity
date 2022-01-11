using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int CurrentGold;

    private void Start()
    {
        CurrentGold = 0;
    }

    public bool checkIfCanTake(int gold)
    {
        if(CurrentGold - gold >= 0)
        {
            takeGold(gold);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void addGold(int gold)
    {
        CurrentGold += gold;
    }

    public void takeGold(int gold)
    {
        CurrentGold -= gold;
    }
}
