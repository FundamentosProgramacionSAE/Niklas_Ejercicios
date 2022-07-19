using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartaContorller : MonoBehaviour
{

    public Carta CartaV2;
    public Image Rareza;
    public Image Arte;
    public Text ATK;
    public Text HP;
    public Text DEF;

    // Start is called before the first frame update
    void Start()
    {
        Rareza.color = CartaV2.Rareza;
        Arte.sprite = CartaV2.Arte;
        ATK.text = CartaV2.ATK;
        HP.text = CartaV2.HP;
        DEF.text = CartaV2.DEF;
    }

    public void ModificarCarta()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
