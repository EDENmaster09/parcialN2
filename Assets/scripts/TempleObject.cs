using UnityEngine;

public abstract class TempleObject : MonoBehaviour, IInteractable
{
    public string objectName;

    public abstract void Interact();

    protected virtual void OnInspect()
    {
        Debug.Log("Inspeccionando: " + objectName);
    }
}
