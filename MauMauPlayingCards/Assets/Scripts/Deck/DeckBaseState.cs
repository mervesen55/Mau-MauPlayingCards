using UnityEngine;

public abstract class DeckBaseState
{
    public abstract void EnterState(DeckStateManager deck);
    public abstract void UpdateState(DeckStateManager deck);
    public abstract void OnCollisionEnter(DeckStateManager deck, Collision collision);
}
