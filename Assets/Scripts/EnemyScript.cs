using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int Health;
    public int MaxHealth;

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        Health--;
        if (Health <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }




}
