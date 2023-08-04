using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckStateManager : MonoBehaviour
{
    DeckBaseState currentState;
    DeckGenerateState generateState = new DeckGenerateState();
    DeckDealState dealState = new DeckDealState();
    DeckRecallState recallState = new DeckRecallState();

    private void Start()
    {
        currentState = generateState;
        currentState.EnterState(this);
    }

    private void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(DeckBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
