using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSet : MonoBehaviour
{
    public delegate void firstMove();
    public static firstMove Move1;

    public delegate void secondMove();
    public static secondMove Move2;

    public delegate void thirdMove();
    public static thirdMove Move3;

    public delegate void forthMove();
    public static forthMove Move4;




    public void _Firstmove()
    {
        print("Dash hacia delante");
    }

    public void _SecondMove()
    {
        print("Dash hacia atras");
    }

    public void _Thirdmove()
    {
        print("shooting with AR");
    }

    public void _Forthmove()
    {
        print("You Scope with sniper");
    }

    public void _FirstmoveV2()
    {
        print("apuñalas");
    }

    public void _SecondMoveV2()
    {
        print("saltas");
    }

    public void _ThirdmoveV2()
    {
        print("te agachas");
    }

    public void _ForthmoveV2()
    {
        print("tiras granada");
    }

    
    public void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Move1 = _FirstmoveV2;
            Move2 = _SecondMoveV2;
            Move3 = _ThirdmoveV2;
            Move4 = _ForthmoveV2;
        }
        else
        {
            Move1 = _Firstmove;
            Move2 = _SecondMove;
            Move3 = _Thirdmove;
            Move4 = _Forthmove;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Move1();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Move2();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Move3();
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Move4();
        }
    }
}
