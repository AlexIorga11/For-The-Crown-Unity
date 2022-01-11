using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Day_Night_Cycle : MonoBehaviour
{
    [SerializeField] private Gradient lightColor;
    [SerializeField] private GameObject light;

    private int days = 1;

    public int Days => days;

    private float time = 70;

    private bool canChangeDay = true;
    private bool canSpawn = true;

    public delegate void OnDayChanged();
    public OnDayChanged DayChanged;

    public EnemySpawner Spawner;

    public int getDays
    {
        get
        {
            return days;
        }
    }

    private void Update()
    {
        if (time > 500)
        {
            time = 0;
        }

        if ((int)time == 200 && canSpawn == true)
        {
            canSpawn = false;
            Spawner.SpawnEnemies(days);
        }

        if ((int)time == 250 && canChangeDay == true)
        {
            canChangeDay = false;
            days++;
            DayChanged();
        }        

        if ((int)time == 255)
        {
            canChangeDay = true;
            canSpawn = true;
        }         

        time += Time.deltaTime;

        light.GetComponent<Light2D>().color = lightColor.Evaluate(time * 0.002f);
    }

    

}