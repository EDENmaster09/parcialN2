using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int health = 100;

    public int Health
    {
        get => health;
        set
        {
            if (value <= 0)
            {
                Debug.Log("Jugador muerto.");
                health = 0;
            }
            else
            {
                health = value;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log("Daño recibido: " + damage + " Vida restante: " + Health);
    }
}
