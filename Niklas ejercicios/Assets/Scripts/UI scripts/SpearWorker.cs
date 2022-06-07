using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpearWorker : MonoBehaviour
{

    public MoneyInGame canvas;

    public float timerUP1MaxValue = 1;
    public float timerUP1Value = 0;

    public float money1 = 10;

    public float upgraded1 = 1;

    public float costUpgrade1;

    public Text Money1Text;

    public Slider slider1;

    bool clicked1button;

    public Text Upgradecost;


    // Start is called before the first frame update
    void Start()
    {
        Money1Text.text = money1.ToString();
        canvas = canvas.gameObject.GetComponent<MoneyInGame>();
        costUpgrade1 = money1 * upgraded1;
        costUpgrade1 = Mathf.Round(costUpgrade1);
        Upgradecost.text = costUpgrade1.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked1button == true)
        {
            Clicked1();
        }
        XUpgrades();
    }

    public void Upgradebutton1()
    {
        if(canvas.moneyInGame < costUpgrade1)
        {
            return;
        }

        if (upgraded1 == 3)
        {
            money1 *= 1.2f;
        }

        if (upgraded1 == 6)
        {
            money1 *= 1.2f;
        }

        if (upgraded1 == 10)
        {
            money1 *= 1.2f;
        }

        if (canvas.moneyInGame >= costUpgrade1)
        {
            canvas.moneyInGame -= costUpgrade1;
            canvas.MoneyText.text = canvas.moneyInGame.ToString();
            timerUP1MaxValue = timerUP1MaxValue * 0.95f;
            money1 = money1 * 1.1f;
            money1 = Mathf.Round(money1);
            Money1Text.text = money1.ToString();
            Upgradecost.text = costUpgrade1.ToString();
            upgraded1++;
        }

        costUpgrade1 *= 1.1f;
        costUpgrade1 = Mathf.Round(costUpgrade1);
        Upgradecost.text = costUpgrade1.ToString();
    }

    void XUpgrades()
    {
           
    }
    public void Clicked1()
    {
        clicked1button = true;
        slider1.maxValue = timerUP1MaxValue;
        if (clicked1button == true)
        {
            timerUP1Value += Time.deltaTime;
            slider1.value = timerUP1Value;
            if (timerUP1Value >= timerUP1MaxValue)
            {
                timerUP1Value = 0;
                slider1.value = timerUP1Value;
                canvas.AddMoney(money1);
                clicked1button = false;
            }
        }
    }

}
