using UnityEngine;

public class Trap : TempleObject
{
    public override void Interact()
    {
        Debug.Log("¡Has activado una trampa! perdiste los terrenos de la abuela.");
    }
}
