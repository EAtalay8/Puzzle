using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.obj1 == "01" && GameManager.instance.obj2 == "02" && GameManager.instance.obj3 == "03" && GameManager.instance.obj4 == "04" && GameManager.instance.obj5 == "05" && GameManager.instance.obj6 == "06" && GameManager.instance.obj7 == "07")
        {
            GameManager.instance.winGame = true;
            Debug.Log("win aq");
            GameManager.instance.Win();
        }
    }
}
