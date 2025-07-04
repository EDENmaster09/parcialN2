using UnityEngine;

public class Enemy : TempleObject
{
    public int health = 100;

    public override void Interact()
    {
        Debug.Log("¡El enemigo te ataca! cuidado es peronista");
    }
}
