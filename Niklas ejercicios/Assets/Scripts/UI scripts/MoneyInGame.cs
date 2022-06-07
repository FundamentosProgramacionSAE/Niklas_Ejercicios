using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyInGame : MonoBehaviour
{

    public float moneyInGame = 0;
   
    public Text MoneyText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void checkMoney()
    {
        print(moneyInGame);
    }
    public void AddMoney(float money)
    {
        moneyInGame += money;
        MoneyText.text = moneyInGame.ToString();
        money = 0;
    }
}
