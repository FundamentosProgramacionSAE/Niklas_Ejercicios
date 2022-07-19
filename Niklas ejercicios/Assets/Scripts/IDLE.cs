using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDLE : StateMachineBehaviour
{

    Transform _Player;
    Transform _IA;

    private float TimerUntilFollow = 3;

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _IA = animator.transform;
        
        _Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        TimerUntilFollow -= Time.deltaTime;
        if (TimerUntilFollow <= 0)
        {
            animator.SetTrigger("InRange");
        }

        float distancia = Vector3.Distance(_IA.position, _Player.position);

        if (distancia <= 3)
        {
            animator.SetTrigger("ItsDead");
        }

    }


    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        TimerUntilFollow = 3;
    }


}
