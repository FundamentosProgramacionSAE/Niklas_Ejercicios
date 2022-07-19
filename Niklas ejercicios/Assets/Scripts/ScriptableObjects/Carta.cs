using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "OPM", menuName = "OPMChar", order = 0)]
public class Carta : ScriptableObject
{
    public string Name = "Name Of char";
    public Color Rareza = Color.blue;
    public Sprite Arte;
    public string ATK;
    public string HP;
    public string DEF;

}
