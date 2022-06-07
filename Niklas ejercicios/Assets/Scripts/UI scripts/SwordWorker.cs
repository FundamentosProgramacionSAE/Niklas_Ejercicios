using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordWorker : MonoBehaviour
{
    public MoneyInGame canvas;

    public float timerUP2MaxValue = 3;
    public float timerUP2Value = 0;

    public float money2 = 100;

    public float upgraded2 = 1;

    public float costUpgrade2;

    public Text Money2Text;
    public Text Upgradecost;

    public Slider slider2;

    bool clicked2button;


    // Start is called before the first frame update
    void Start()
    {
        Money2Text.text = money2.ToString();
        canvas = canvas.gameObject.GetComponent<MoneyInGame>();
        costUpgrade2 = money2 * upgraded2;
        costUpgrade2 = Mathf.Round(costUpgrade2);
        Upgradecost.text = costUpgrade2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked2button == true)
        {
            Clicked2();
        }
    }

    public void Upgradebutton2  ()
    {
        if (canvas.moneyInGame < costUpgrade2)
        {
            return;
        }
        if (upgraded2 == 3)
        {
            money2 *= 1.2f;
        }

        if (upgraded2 == 6)
        {
            money2 *= 1.2f;
        }

        if (upgraded2 == 3)
        {
            money2 *= 1.2f;
        }

        if (canvas.moneyInGame >= costUpgrade2)
        {
            canvas.moneyInGame -= costUpgrade2;
            canvas.MoneyText.text = canvas.moneyInGame.ToString();
            timerUP2MaxValue = timerUP2MaxValue * 0.95f;
            money2 = money2 * 1.1f;
            money2 = Mathf.Round(money2);
            Money2Text.text = money2.ToString();
            Upgradecost.text = costUpgrade2.ToString();
            upgraded2++;
        }
        costUpgrade2 *= 1.1f;
        costUpgrade2 = Mathf.Round(costUpgrade2);
        Upgradecost.text = costUpgrade2.ToString();
    }

    public void Clicked2()
    {
        clicked2button = true;
        slider2.maxValue = timerUP2MaxValue;
        if (clicked2button == true)
        {
            timerUP2Value += Time.deltaTime;
            slider2.value = timerUP2Value;
            if (timerUP2Value >= timerUP2MaxValue)
            {
                timerUP2Value = 0;
                slider2.value = timerUP2Value;
                canvas.AddMoney(money2);
                clicked2button = false;
            }
        }
    }
}
