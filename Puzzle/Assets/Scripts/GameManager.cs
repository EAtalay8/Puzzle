using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public int lastLevel;

    public int isFirstLevelFirstlyCompleted;

    //public GameObject[] emptyPlaneArrays = new GameObject[2];

    private IEnumerator ai;

    public bool winGame = false;

    public GameObject rivalManager;
    public GameObject swp;

    [Header("Materials")]

    public GameObject platObject;
    public Material[] materials = new Material[3]; //for 3 materials
    public int matIndex = 0;


    [Header("Panels")]

    public GameObject winPanel;
    public GameObject losePanel;

    [Header("Cubes")]

    public List<GameObject> cubeList = new List<GameObject>();

    public List<GameObject> possiblePlayersListR = new List<GameObject>();
    public List<GameObject> possiblePlayersListD = new List<GameObject>();
    public List<GameObject> possiblePlayersListL = new List<GameObject>();
    public List<GameObject> possiblePlayersListU = new List<GameObject>();

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

    //GameObject[] emptyObjs;
    public GameObject[,] adjObjs = new GameObject[7, 4];

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
        Debug.Log(matIndex);
        Debug.Log(materials.Length);

        if(Input.GetKeyDown(KeyCode.C))
        {
            if (matIndex >= materials.Length)
                matIndex -= 3;
            else
                matIndex++;
            
            platObject.GetComponent<MeshRenderer>().material = materials[matIndex];

            
        }

        for (int i = 0; i < 7; i++)
        {
            if (cubeList[i].GetComponent<Cubes>().planeList[0].GetComponent<Plane>().adjList[0].CompareTag("Empty"))
            {
                cubeList[i].GetComponent<Cubes>().rightEmpty = true;
                //SwipeTest.instance.playerR = cubeList[i].transform;
            }

            else
            {
                cubeList[i].GetComponent<Cubes>().rightEmpty = false;
            }

            if (cubeList[i].GetComponent<Cubes>().planeList[0].GetComponent<Plane>().adjList[1].CompareTag("Empty"))
            {
                cubeList[i].GetComponent<Cubes>().downEmpty = true;
                //SwipeTest.instance.playerD = cubeList[i].transform;
            }

            else
            {
                cubeList[i].GetComponent<Cubes>().downEmpty = false;
            }

            if (cubeList[i].GetComponent<Cubes>().planeList[0].GetComponent<Plane>().adjList[2].CompareTag("Empty"))
            {
                cubeList[i].GetComponent<Cubes>().leftEmpty = true;
                //SwipeTest.instance.playerL = cubeList[i].transform;
            }

            else
            {
                cubeList[i].GetComponent<Cubes>().leftEmpty = false;
            }

            if (cubeList[i].GetComponent<Cubes>().planeList[0].GetComponent<Plane>().adjList[3].CompareTag("Empty"))
            {
                cubeList[i].GetComponent<Cubes>().upEmpty = true;
                //SwipeTest.instance.playerU = cubeList[i].transform;
            }

            else
            {
                cubeList[i].GetComponent<Cubes>().upEmpty = false;
            }



           

            if (cubeList[i].GetComponent<Cubes>().rightEmpty)
            {
                if (possiblePlayersListR.Count == 0)
                    possiblePlayersListR.Add(cubeList[i]);

                else if (possiblePlayersListR.Count == 1 && possiblePlayersListR[0] != cubeList[i])
                    possiblePlayersListR.Add(cubeList[i]);
            }

            else
                possiblePlayersListR.Remove(cubeList[i]);


            if (cubeList[i].GetComponent<Cubes>().downEmpty)
            {
                if (possiblePlayersListD.Count == 0)
                    possiblePlayersListD.Add(cubeList[i]);

                else if (possiblePlayersListD.Count == 1 && possiblePlayersListD[0] != cubeList[i])
                    possiblePlayersListD.Add(cubeList[i]);
            }

            else
                possiblePlayersListD.Remove(cubeList[i]);

            if (cubeList[i].GetComponent<Cubes>().leftEmpty)
            {
                if (possiblePlayersListL.Count == 0)
                    possiblePlayersListL.Add(cubeList[i]);

                else if (possiblePlayersListL.Count == 1 && possiblePlayersListL[0] != cubeList[i])
                    possiblePlayersListL.Add(cubeList[i]);
            }

            else
                possiblePlayersListL.Remove(cubeList[i]);

            if (cubeList[i].GetComponent<Cubes>().upEmpty)
            {
                if (possiblePlayersListU.Count == 0)
                    possiblePlayersListU.Add(cubeList[i]);

                else if (possiblePlayersListU.Count == 1 && possiblePlayersListU[0] != cubeList[i])
                    possiblePlayersListU.Add(cubeList[i]);
            }

            else
                possiblePlayersListU.Remove(cubeList[i]);

            


        }

        if (possiblePlayersListR.Count == 1)
        {
            SwipeTest.instance.playerR = possiblePlayersListR[0].transform;
        }

        else if (possiblePlayersListR.Count == 2)
        {
            if (possiblePlayersListR[0].transform.position.z > possiblePlayersListR[1].transform.position.z)
            {
                if (Input.mousePosition.y > 960)
                {
                    SwipeTest.instance.playerR = possiblePlayersListR[0].transform;
                }

                else
                    SwipeTest.instance.playerR = possiblePlayersListR[1].transform;
            }
            else
            {
                if (Input.mousePosition.y < 960)
                {
                    SwipeTest.instance.playerR = possiblePlayersListR[0].transform;
                }

                else
                    SwipeTest.instance.playerR = possiblePlayersListR[1].transform;
            }
        }


        if (possiblePlayersListD.Count == 1)
        {
            SwipeTest.instance.playerD = possiblePlayersListD[0].transform;
        }

        else if (possiblePlayersListD.Count == 2)
        {
            if (possiblePlayersListD[0].transform.position.x > possiblePlayersListD[1].transform.position.x)
            {
                if (Input.mousePosition.x > 540)
                {
                    SwipeTest.instance.playerD = possiblePlayersListD[0].transform;
                }

                else
                    SwipeTest.instance.playerD = possiblePlayersListD[1].transform;
            }
            else
            {
                if (Input.mousePosition.x < 540)
                {
                    SwipeTest.instance.playerD = possiblePlayersListD[0].transform;
                }

                else
                    SwipeTest.instance.playerD = possiblePlayersListD[1].transform;
            }
        }


        if (possiblePlayersListL.Count == 1)
        {
            SwipeTest.instance.playerL = possiblePlayersListL[0].transform;
        }

        else if (possiblePlayersListL.Count == 2)
        {
            if (possiblePlayersListL[0].transform.position.z > possiblePlayersListL[1].transform.position.z)
            {
                if (Input.mousePosition.y > 960)
                {
                    SwipeTest.instance.playerL = possiblePlayersListL[0].transform;
                }

                else
                    SwipeTest.instance.playerL = possiblePlayersListL[1].transform;
            }
            else
            {
                if (Input.mousePosition.y < 960)
                {
                    SwipeTest.instance.playerL = possiblePlayersListL[0].transform;
                }

                else
                    SwipeTest.instance.playerL = possiblePlayersListL[1].transform;
            }
        }


        if (possiblePlayersListU.Count == 1)
        {
            SwipeTest.instance.playerU = possiblePlayersListU[0].transform;
        }

        else if (possiblePlayersListU.Count == 2)
        {
            if (possiblePlayersListU[0].transform.position.x > possiblePlayersListU[1].transform.position.x)
            {
                if (Input.mousePosition.x > 540)
                {
                    SwipeTest.instance.playerU = possiblePlayersListU[0].transform;
                }

                else
                    SwipeTest.instance.playerU = possiblePlayersListU[1].transform;
            }
            else
            {
                if (Input.mousePosition.x < 540)
                {
                    SwipeTest.instance.playerU = possiblePlayersListU[0].transform;
                }

                else
                    SwipeTest.instance.playerU = possiblePlayersListU[1].transform;
            }
        }


        //Debug.Log(Input.mousePosition);

        if (!SwipeTest.instance.playerR.GetComponent<Cubes>().rightEmpty)
        {
            SwipeTest.instance.playerR = null;
        }

        if (!SwipeTest.instance.playerD.GetComponent<Cubes>().downEmpty)
        {
            SwipeTest.instance.playerD = null;
        }

        if (!SwipeTest.instance.playerL.GetComponent<Cubes>().leftEmpty)
        {
            SwipeTest.instance.playerL = null;
        }

        if (!SwipeTest.instance.playerU.GetComponent<Cubes>().upEmpty)
        {
            SwipeTest.instance.playerU = null;
        }

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
