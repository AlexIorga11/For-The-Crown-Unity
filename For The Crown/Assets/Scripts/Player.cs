using UnityEngine;


public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public Hp_Indicator_script indicator;

    private void Awake()
    {
        indicator = GameObject.Find("HP").GetComponent<Hp_Indicator_script>();
    }
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            TakeDamage(5);
        }


    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        indicator.SetHealth(currentHealth);
    }
}
