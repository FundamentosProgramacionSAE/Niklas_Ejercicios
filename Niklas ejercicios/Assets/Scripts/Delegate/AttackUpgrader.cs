using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUpgrader : MonoBehaviour
{
    
  
    public void upgradeAttack()
    {
        DelegateController.Mydelegate += BasicAttackUpgraded;
    }

    public void BasicAttackUpgraded()
    {
        print("And You Reflect Enemy Attack");
    }

    public void UltimateAttackUpgrade()
    { 
        DelegateController.Mydelegate += UltimateAttack;
    }

    public void UltimateAttack()
    {
        print("And Finally You Lower Their Defense");
    }

}
