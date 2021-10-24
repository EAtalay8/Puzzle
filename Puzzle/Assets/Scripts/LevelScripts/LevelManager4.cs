using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.obj1 == "blue" && GameManager.instance.obj2 == "green" && GameManager.instance.obj3 == "orange" && GameManager.instance.obj4 == "green" && GameManager.instance.obj5 == "blue" && GameManager.instance.obj6 == "red" && GameManager.instance.obj7 == "purple") //GameManager.instance.obj8 == "orange")
        {
            GameManager.instance.winGame = true;
            Debug.Log("win aq");
            GameManager.instance.Win();
        }
    }
}
