using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpearWorker : MonoBehaviour
{

    public GameObject canvas;

    public float timerUP1MaxValue = 1;
    public float timerUP1Value = 0;

    public float money1 = 10;

    public float upgraded1 = 1;

    public float costUpgrade1;

    public Text Money1Text;

    public Slider slider1;

    bool clicked1button;

    
    //// Start is called before the first frame update
    //void Start()
    //{
    //    Money1Text.text = money1.ToString();
    //    canvas = canvas.gameObject.GetComponent<MoneyInGame>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (clicked1button == true)
    //    {
    //        Clicked1();
    //    }
    //}

    //public void Upgradebutton1()
    //{
    //    costUpgrade1 = money1 * upgraded1;
    //    costUpgrade1 = Mathf.Round(costUpgrade1);

    //    if (MoneyInGame < upgraded1)
    //    {
    //        costUpgrade1 = money1 * upgraded1;
    //    }

    //    if (moneyInGame >= costUpgrade1)
    //    {
    //        moneyInGame -= costUpgrade1;
    //        MoneyText.text = moneyInGame.ToString();
    //        timerUP1MaxValue = timerUP1MaxValue * 0.95f;
    //        money1 = money1 * 1.1f;
    //        money1 = Mathf.Round(money1);
    //        Money1Text.text = money1.ToString();
    //        upgraded1++;
    //        costUpgrade1 = 0;
    //    }

    // }

    //public void Clicked1()
    //{
    //    clicked1button = true;
    //    slider1.maxValue = timerUP1MaxValue;
    //    if (clicked1button == true)
    //    {
    //        timerUP1Value += Time.deltaTime;
    //        slider1.value = timerUP1Value;
    //        if (timerUP1Value >= timerUP1MaxValue)
    //        {
    //            timerUP1Value = 0;
    //            slider1.value = timerUP1Value;
    //            AddMoney(money1);
    //            clicked1button = false;
    //        }
    //    }
    //}

}
