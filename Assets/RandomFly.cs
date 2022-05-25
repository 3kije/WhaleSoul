using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFly : StateMachineBehaviour
{
    readonly float flyMinTime = 2;
    readonly float flyMaxTime = 5;

    float flyTimer = 0;

    string[] flyTriggers = { "Fly2" };

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (flyTimer <= 0)
        {
            IdleRandom(animator);
            flyTimer = Random.Range(flyMinTime, flyMaxTime);
        }
        else
        {
            flyTimer -= Time.deltaTime;
        }
    }

    void IdleRandom(Animator animator)
    {
        System.Random rnd = new System.Random();
        int idlePosition = rnd.Next(flyTriggers.Length);
        string idleTrigger = flyTriggers[idlePosition];
        animator.SetTrigger(idleTrigger);
    }

}
