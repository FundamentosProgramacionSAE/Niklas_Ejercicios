using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyInGame : MonoBehaviour
{

    public float moneyInGame = 0;
    public float timerUP2MaxValue = 3;
    public float timerUP2Value = 0;
    public float timerUP3MaxValue = 5;
    public float timerUP3Value = 0;
    public float timerUP4MaxValue = 10;
    public float timerUP4Value = 0;


    public float money2 = 100;
    public float money3 = 500;
    public float money4 = 1000;

    
    public float upgraded2 = 1;
    public float upgraded3 = 1;
    public float upgraded4 = 1;


    
    public float costUpgrade2;
    public float costUpgrade3;
    public float costUpgrade4;

    public Text MoneyText;
    
    public Text Money2Text;
    public Text Money3Text;
    public Text Money4Text;

    
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Button Butotn;

    
    bool clicked2button;
    bool clicked3button;
    bool clicked4button;

    // Start is called before the first frame update
    void Start()
    {
        MoneyText.text = moneyInGame.ToString();
        Money2Text.text = 100.ToString();
        Money3Text.text = 500.ToString();
        Money4Text.text = 1000.ToString();
        //Butotn.onClick.AddListener(Upgradebutton1);
    }

    // Update is called once per frame
    void Update()
    {
        if (clicked2button == true)
        {
            Clicked2();
        }
        if (clicked3button == true)
        {
            Clicked3();
        }
        if (clicked4button == true)
        {
            Clicked4();
        }
    }

    public void Upgradebutton2()
    {
        costUpgrade2 = money2 * upgraded2;
        costUpgrade2 = Mathf.Round(costUpgrade2);

        if (moneyInGame < upgraded2)
        {
            costUpgrade2 = 0;
        }

        if (moneyInGame >= costUpgrade2)
        {
            moneyInGame -= costUpgrade2;
            MoneyText.text = moneyInGame.ToString();
            timerUP2MaxValue = timerUP2MaxValue * 0.95f;
            money2 = money2 * 1.1f;
            money2 = Mathf.Round(money2);
            Money2Text.text = money2.ToString();
            upgraded2++;
            costUpgrade2 = 0;
        }
            
    }
    public void Upgradebutton3()
    {
        costUpgrade3 += money3 * upgraded3;
        costUpgrade3 = Mathf.Round(costUpgrade3);

        if (moneyInGame < upgraded3)
        {
            costUpgrade3 = 0;
        }

        if (moneyInGame >= costUpgrade3)
        {
            moneyInGame -= costUpgrade3;
            MoneyText.text = moneyInGame.ToString();
            timerUP3MaxValue = timerUP3MaxValue * 0.95f;
            money3 = money3 * 1.1f;
            money3 = Mathf.Round(money3);
            Money3Text.text = money3.ToString();
            upgraded3++;
            costUpgrade3 = 0;
        }
        
    }
    public void Upgradebutton4()
    {
        costUpgrade4 += money4 * upgraded4;
        costUpgrade4 = Mathf.Round(costUpgrade4);

        if (moneyInGame < upgraded4)
        {
            costUpgrade4 = 0;
        }

        if (moneyInGame >= costUpgrade3)
        {
            moneyInGame -= costUpgrade4;
            MoneyText.text = moneyInGame.ToString();
            timerUP4MaxValue = timerUP4MaxValue * 0.95f;
            money4 = money4 * 1.1f;
            money4 = Mathf.Round(money4);
            Money4Text.text = money4.ToString();
            upgraded4++;
            costUpgrade4 = 0;
        }
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
                AddMoney(money2);
                clicked2button = false;
            }
        }
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
                AddMoney(money3);
                clicked3button = false;
                
            }
        }
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
                AddMoney(money4);
                clicked4button = false;
                
            }
        }
    }
}
