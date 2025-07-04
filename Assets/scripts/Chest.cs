using UnityEngine;

public class Chest : TempleObject
{
    public bool isOpen = false;

    public override void Interact()
    {
        if (!isOpen)
        {
            Debug.Log("Cofre abierto, contiene: manifiesto comunista.");
            isOpen = true;
        }
        else
        {
            Debug.Log("El cofre ya está vacío.");
        }
    }
}
