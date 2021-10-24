using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public int lastLevel;

    public int isFirstLevelFirstlyCompleted;

    public bool deneme = true;

    public GameObject[] emptyPlaneArrays = new GameObject[2];

    private IEnumerator ai;

    public bool winGame = false;

    public GameObject rivalManager;
    public GameObject swp;

    [Header("Panels")]

    public GameObject winPanel;
    public GameObject losePanel;

    [Header("Planes")]

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;
    public GameObject p9;

    public string obj1;
    public string obj2;
    public string obj3;
    public string obj4;
    public string obj5;
    public string obj6;
    public string obj7;

    [Space(50)]

    GameObject[] emptyObjs;
    public GameObject[,] adjObjs = new GameObject[2, 4];

    public static GameManager instance;


    private void Awake()
    {
        instance = this;

        lastLevel = PlayerPrefs.GetInt("lastLevel", 1);
        isFirstLevelFirstlyCompleted = PlayerPrefs.GetInt("firstlevelCompleted", 0);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);

        if (p1.GetComponent<Plane>().playerList.Count != 0)
            obj1 = p1.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj1 = null;
        }

        if (p2.GetComponent<Plane>().playerList.Count != 0)
            obj2 = p2.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj2 = null;
        }

        if (p3.GetComponent<Plane>().playerList.Count != 0)
            obj3 = p3.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj3 = null;
        }

        if (p4.GetComponent<Plane>().playerList.Count != 0)
            obj4 = p4.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj4 = null;
        }

        if (p5.GetComponent<Plane>().playerList.Count != 0)
            obj5 = p5.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj5 = null;
        }

        if (p6.GetComponent<Plane>().playerList.Count != 0)
            obj6 = p6.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj6 = null;
        }

        if (p7.GetComponent<Plane>().playerList.Count != 0)
            obj7 = p7.GetComponent<Plane>().playerList[0].name;

        else
        {
            obj7 = null;
        }





        emptyObjs = GameObject.FindGameObjectsWithTag("Empty");

        for (int i = 0; i < 2; i++)
        {
            //lightuser.GetComponent<light>().enabled = false;

            //Debug.Log(emptyPlane.transform.name);

            emptyPlaneArrays[i] = emptyObjs[i];
        }

        for (int i = 0; i < 2; i++)
        {
            //Debug.Log(emptyPlaneArrays[i].name + " boþlar");
            for (int j = 0; j < 4; j++)
            {
                
                //Debug.Log(emptyPlaneArrays[i].GetComponent<Plane>().adjList[j] + " komþusudur " + emptyPlaneArrays[i].name);

                adjObjs[i, j] = GameObject.Find(emptyPlaneArrays[i].GetComponent<Plane>().adjList[j].ToString());

                Debug.Log(i+1 + " . " + (j+1) +" elemaný "+ adjObjs[i, j].name);

                //Debug.Log(adjObjs[j].name);

                if (SwipeTest.instance.swpR && adjObjs[i, 2].CompareTag("Occupied") && adjObjs[i, 2].name != "0")
                {
                    if (Input.mousePosition.y > 540 && adjObjs[0, 2].name != "0")
                        adjObjs[0, 2].GetComponent<Plane>().swtchPlayer = true;
                    else if (adjObjs[1, 2].name != "0")
                        adjObjs[1, 2].GetComponent<Plane>().swtchPlayer = true;
                    //adjObjs[j + 1].GetComponent<Plane>().swtchPlayer = true;

                    //Debug.Log(Input.mousePosition);

                    //Debug.Log(emptyAdj[j].name);
                    //int changed = Int32.Parse(emptyPlaneArrays[j].name) - 1;
                    /*if (adjObjs[j].name == changed.ToString())
                        GameObject.Find(changed.ToString()).GetComponent<Plane>().swtchPlayer = true;*/
                    //emptyPlaneArrays[i].GetComponent<Plane>().swtchPlayer = true;
                }

                if (SwipeTest.instance.swpL && adjObjs[i, 0].CompareTag("Occupied") && adjObjs[i, 0].name != "0")
                {
                    if (Input.mousePosition.x > 540 && adjObjs[0, 0].name != "0")
                        adjObjs[0, 0].GetComponent<Plane>().swtchPlayer = true;
                    else if (adjObjs[1, 0].name != "0")
                        adjObjs[1, 0].GetComponent<Plane>().swtchPlayer = true;

                    //adjObjs[i, 0].GetComponent<Plane>().swtchPlayer = true;
                    //Debug.Log(emptyAdj[j].name);
                    /*int changed = Int32.Parse(emptyPlaneArrays[j].name) - 1;
                    if (emptyAdj[j].name == changed.ToString())
                        GameObject.Find(changed.ToString()).GetComponent<Plane>().swtchPlayer = true;*/
                    //emptyPlaneArrays[i].GetComponent<Plane>().swtchPlayer = true;
                }

                if (SwipeTest.instance.swpU && adjObjs[i, 1].CompareTag("Occupied") && adjObjs[i, 1].name != "0")
                {
                    if (Input.mousePosition.x > 540 && adjObjs[0, 1].name != "0")
                        adjObjs[0, 1].GetComponent<Plane>().swtchPlayer = true;
                    else if (adjObjs[1, 1].name != "0")
                        adjObjs[1, 1].GetComponent<Plane>().swtchPlayer = true;

                    //adjObjs[i, 1].GetComponent<Plane>().swtchPlayer = true;
                    //Debug.Log(emptyAdj[j].name);
                    /*int changed = Int32.Parse(emptyPlaneArrays[j].name) - 1;
                    if (emptyAdj[j].name == changed.ToString())
                        GameObject.Find(changed.ToString()).GetComponent<Plane>().swtchPlayer = true;*/
                    //emptyPlaneArrays[i].GetComponent<Plane>().swtchPlayer = true;
                }

                if (SwipeTest.instance.swpD && adjObjs[i, 3].CompareTag("Occupied") && adjObjs[i, 3].name != "0")
                {
                    if (Input.mousePosition.x > 540 && adjObjs[0, 3].name != "0")
                        adjObjs[0, 3].GetComponent<Plane>().swtchPlayer = true;
                    else if (adjObjs[1, 3].name != "0")
                        adjObjs[1, 3].GetComponent<Plane>().swtchPlayer = true;
                    

                    //adjObjs[i, 3].GetComponent<Plane>().swtchPlayer = true;

                    //Debug.Log(emptyAdj[j].name);
                    /*int changed = Int32.Parse(emptyPlaneArrays[j].name) - 1;
                    if (emptyAdj[j].name == changed.ToString())
                        GameObject.Find(changed.ToString()).GetComponent<Plane>().swtchPlayer = true;*/
                    //emptyPlaneArrays[i].GetComponent<Plane>().swtchPlayer = true;
                }

                /*else
                {
                    SwipeTest.instance.swpR = false;
                    SwipeTest.instance.swpL = false;
                    SwipeTest.instance.swpU = false;
                    SwipeTest.instance.swpD = false;
                }*/

                /*else
                {
                    Debug.Log("elif");
                }*/
            }

        }

        // komþularý döndürüp 1 eklediðimizde plane ediyor ise sola swipe yapmalý
        // komþularýmýz zaten listede emptyAdj[]

        /*else
        {
            SwipeTest.instance.swpR = false;
            SwipeTest.instance.swpL = false;
            SwipeTest.instance.swpU = false;
            SwipeTest.instance.swpD = false;
        }*/



        /*if(obj1 == "blue" && obj2 == "orange" && obj3 == "purple" && obj4 == "green" && obj5 == "orange" && obj6 == "blue" && obj7 == "red" && obj8 == "green")
        {
            winGame = true;
            Debug.Log("win aq");
            Win();
        }*/
    }

    public void Win()
    {
        Destroy(rivalManager.GetComponent<Rival>());

        winPanel.SetActive(true);
    }

    public void Lose()
    {
        losePanel.SetActive(true);
        swp.GetComponent<SwipeTest>().enabled = false;
    }

    public void NextLevel()
    {
        StartCoroutine(AsyncSceneLoader((lastLevel % 4) + 1));
        lastLevel++;
        PlayerPrefs.SetInt("lastLevel", lastLevel);
    }
    public void Restart()
    {
        StartCoroutine(AsyncSceneLoader(SceneManager.GetActiveScene().buildIndex));
    }
    IEnumerator AsyncSceneLoader(int BuildIndex)
    {
        SceneController.instance.levelIndex = BuildIndex;

        AsyncOperation asyncLoadScene = SceneManager.LoadSceneAsync("SceneLoader", LoadSceneMode.Single);
        while (!asyncLoadScene.isDone)
        {
            yield return null;
        }
    }
}
