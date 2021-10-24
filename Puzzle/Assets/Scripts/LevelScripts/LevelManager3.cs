using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.obj1 == "orange" && GameManager.instance.obj2 == "blue" && GameManager.instance.obj3 == "green" && GameManager.instance.obj4 == "green" && GameManager.instance.obj5 == "orange" && GameManager.instance.obj6 == "red" && GameManager.instance.obj7 == "blue") //&& GameManager.instance.obj8 == "purple")
        {
            GameManager.instance.winGame = true;
            Debug.Log("win aq");
            GameManager.instance.Win();
        }
    }
}
