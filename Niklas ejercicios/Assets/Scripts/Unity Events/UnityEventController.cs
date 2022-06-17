using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventClass : UnityEvent<float, float>
{

}
public class UnityEventController : MonoBehaviour
{

    //public UnityEvent Test1;

    public UnityEventClass ClassEventTest;
    // Start is called before the first frame update
    void Start()
    {
        //Test1.AddListener(Hola);
        ClassEventTest.AddListener(holabuenosdias);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            //Test1.Invoke();
            ClassEventTest.Invoke(100, 50);
        }    
    }

    //public void Hola()
    //{
    //    print("hola buenos dias");
    //}

    public void holabuenosdias(float vida, float escudo)
    {
        print("tengo " + vida + " de vida");
        print("tengo" + escudo + " de escudo");
    }
}
