using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingLevels : MonoBehaviour
{
    public GameObject[] levels;
    int currentLevel = 0;
    public Gold gold;

    public void Upgrade()
    {
        if (gold.checkIfCanTake(50) == true)
        {
            if (currentLevel < levels.Length - 1)
            {
                currentLevel++;
                SwitchObject(currentLevel);
            }
        }
    }
    public void Downgrade()
    {
        if (currentLevel > 0)
        {
            currentLevel--;
            SwitchObject(currentLevel);
            gold.addGold(25);
        }
    }

    void SwitchObject(int lvl)
    {
        for(int i = 0; i < levels.Length; i++)
        {
            if(i == lvl)            
                levels[i].SetActive(true);            
            else            
                levels[i].SetActive(false);
            
        }
    }
}
