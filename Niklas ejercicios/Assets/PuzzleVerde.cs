using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleVerde : MonoBehaviour
{

    public RectTransform Puzzle;
    public RectTransform ZonaVerde;
    public RectTransform Flecha;

    public float NewX;
    private float Limites;
    public float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float LimitesVerdes = ZonaVerde.sizeDelta.x / 2;

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (-LimitesVerdes < NewX && NewX < LimitesVerdes)
            {
                Randomizar();
            }
            else
            {
                print("Q malo eres");
            }
        }
       
       
        MoverFlecha();
    }

    private void MoverFlecha()
    {
        Limites = Puzzle.sizeDelta.x / 2;

        NewX = Limites * Mathf.Sin(Time.time * Speed);

        Flecha.localPosition = new Vector3(NewX, Flecha.localPosition.y, Flecha.localPosition.z);
    }

    private void Randomizar()
    {
        Speed += 0.5f;

        float NuevaX = Random.Range(10f, 300f);

        ZonaVerde.sizeDelta = new Vector2(NuevaX, ZonaVerde.sizeDelta.y);
    }
}
