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
        if (GameManager.instance.obj1 == "yellow" && GameManager.instance.obj2 == "green" && GameManager.instance.obj3 == "blue" && GameManager.instance.obj4 == "blue" && GameManager.instance.obj5 == "yellow" && GameManager.instance.obj6 == "purple" && GameManager.instance.obj7 == "red") //&& GameManager.instance.obj8 == "purple")
        {
            GameManager.instance.winGame = true;
            Debug.Log("win aq");
            GameManager.instance.Win();
        }
    }
}
