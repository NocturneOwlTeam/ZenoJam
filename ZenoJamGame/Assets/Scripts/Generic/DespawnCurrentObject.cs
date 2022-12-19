using Lean.Pool;
using UnityEngine;

public class DespawnCurrentObject : MonoBehaviour
{
    public void Despawn()
    {
        LeanPool.Despawn(this);
    }
}