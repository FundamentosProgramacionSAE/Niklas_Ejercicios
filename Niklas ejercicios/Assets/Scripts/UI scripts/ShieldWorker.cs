using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldWorker : MonoBehaviour
{
    public MoneyInGame canvas;

    public float timerUP3MaxValue = 5;
    public float timerUP3Value = 0;

    public float money3 = 500;

    public float upgraded3 = 1;

    public float costUpgrade3;

    public Text Money3Text;
    public Text Upgradecost;

    public Slider slider3;

    bool clicked3button;


    // Start is called before the first frame update
    void Start()
    {
        Money3Text.text = money3.ToString();
        canvas = canvas.gameObject.GetComponent<MoneyInGame>();
        costUpgrade3 = money3 * upgraded3;
        costUpgrade3 = Mathf.Round(costUpgrade3);
        Upgradecost.text = costUpgrade3.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked3button == true)
        {
            Clicked3();
        }
    }

    public void Upgradebutton3()
    {

        if (canvas.moneyInGame < costUpgrade3)
        {
            return;
        }
        if (upgraded3 == 3)
        {
            money3 *= 1.2f;
        }

        if (upgraded3 == 6)
        {
            money3 *= 1.2f;
        }

        if (upgraded3 == 3)
        {
            money3 *= 1.2f;
        }

        if (canvas.moneyInGame >= costUpgrade3)
        {
            canvas.moneyInGame -= costUpgrade3;
            canvas.MoneyText.text = canvas.moneyInGame.ToString();
            timerUP3MaxValue = timerUP3MaxValue * 0.95f;
            money3 = money3 * 1.1f;
            money3 = Mathf.Round(money3);
            Money3Text.text = money3.ToString();
            Upgradecost.text = costUpgrade3.ToString();
            upgraded3++;
        }

        costUpgrade3 *= 1.1f;
        costUpgrade3 = Mathf.Round(costUpgrade3);
        Money3Text.text = money3.ToString();

    }

    public void Clicked3()
    {
        clicked3button = true;
        slider3.maxValue = timerUP3MaxValue;
        if (clicked3button == true)
        {
            timerUP3Value += Time.deltaTime;
            slider3.value = timerUP3Value;
            if (timerUP3Value >= timerUP3MaxValue)
            {
                timerUP3Value = 0;
                slider3.value = timerUP3Value;
                canvas.AddMoney(money3);
                clicked3button = false;
            }
        }
    }
}
