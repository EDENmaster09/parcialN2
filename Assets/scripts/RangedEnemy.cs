using UnityEngine;

public class RangedEnemy : Enemy
{
    public int damage = 20;

    public override void Interact()
    {
        Debug.Log("¡Enemigo a distancia lanza un proyectil! tranquilo es otro manifiesto comunista");
    }
}
