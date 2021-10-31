using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.obj1 == "blue" && GameManager.instance.obj2 == "orange" && GameManager.instance.obj3 == "purple" && GameManager.instance.obj4 == "green" && GameManager.instance.obj5 == "green" && GameManager.instance.obj6 == "blue" && GameManager.instance.obj7 == "red") //&& GameManager.instance.obj8 == "green")
        {
            GameManager.instance.winGame = true;
            Debug.Log("win aq");
            GameManager.instance.Win();
        }
    }
}
