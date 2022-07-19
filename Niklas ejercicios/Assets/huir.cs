using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class huir : StateMachineBehaviour
{

    Transform _Player;
    Transform _IA;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _IA = animator.transform;

        _Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //_IA.position = Vector3.MoveTowards(_Player.position, _IA.position, 2 * Time.deltaTime);

        Vector3 Huir = _IA.position - _Player.position; 

        _IA.Translate(Huir.normalized * Time.deltaTime * 2, Space.World);

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
