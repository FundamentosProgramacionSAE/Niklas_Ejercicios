using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : StateMachineBehaviour
{

    Transform _Player;
    Transform _IA;

    float Range = 0.5f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _IA = animator.transform;

        _Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _IA.position = Vector3.MoveTowards(_IA.position, _Player.position, 2 * Time.deltaTime);

        float distancia = Vector3.Distance(_IA.position, _Player.position);

        if(distancia <= 3)
        {
            animator.SetTrigger("ItsDead");
        }
    }
    
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
