using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShiedAndSwordWorker : MonoBehaviour
{
    public MoneyInGame canvas;

    public float timerUP4MaxValue = 10;
    public float timerUP4Value = 0;

    public float money4 = 1000;

    public float upgraded4 = 1;

    public float costUpgrade4;

    public Text Money4Text;
    public Text Upgradecost;

    public Slider slider4;

    bool clicked4button;

    public float TimerUpgrade;

    bool CostNotCalculated;
    // Start is called before the first frame update
    void Start()
    {
        Money4Text.text = money4.ToString();
        canvas = canvas.gameObject.GetComponent<MoneyInGame>();
        costUpgrade4 = money4 * upgraded4;
        costUpgrade4 = Mathf.Round(costUpgrade4);
        Upgradecost.text = costUpgrade4.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked4button == true)
        {
            Clicked4();
        }
    }

    //void upgradecostintime()
    //{
    //    TimerUpgrade = 3;
    //    TimerUpgrade -= Time.deltaTime;
    //    if(TimerUpgrade <= 0 && CostNotCalculated == true)
    //    {
    //        costUpgrade4 = money4 * upgraded4;
    //        costUpgrade4 = Mathf.Round(costUpgrade4);
    //        Upgradecost.text = costUpgrade4.ToString();
    //        TimerUpgrade = 3;
    //        CostNotCalculated = false;
    //    }
        
    //}
    public void Upgradebutton4()
    {

        if (canvas.moneyInGame < costUpgrade4)
        {
            return;
        }
        if (upgraded4 == 3)
        {
            money4 *= 1.2f;
        }

        if (upgraded4 == 6)
        {
            money4 *= 1.2f;
        }

        if (upgraded4 == 3)
        {
            money4 *= 1.2f;
        }

        if (canvas.moneyInGame >= costUpgrade4)
        {
            canvas.moneyInGame -= costUpgrade4;
            canvas.MoneyText.text = canvas.moneyInGame.ToString();
            timerUP4MaxValue = timerUP4MaxValue * 0.95f;
            money4 = money4 * 1.1f;
            money4 = Mathf.Round(money4);
            Money4Text.text = money4.ToString();
            Upgradecost.text = costUpgrade4.ToString();
            upgraded4++;
        }

        costUpgrade4 *= 1.1f;
        costUpgrade4 = Mathf.Round(costUpgrade4);
        Upgradecost.text = costUpgrade4.ToString();

    }

    public void Clicked4()
    {
        clicked4button = true;
        slider4.maxValue = timerUP4MaxValue;
        if (clicked4button == true)
        {
            timerUP4Value += Time.deltaTime;
            slider4.value = timerUP4Value;
            if (timerUP4Value >= timerUP4MaxValue)
            {
                timerUP4Value = 0;
                slider4.value = timerUP4Value;
                canvas.AddMoney(money4);
                clicked4button = false;
            }
        }
    }
}

