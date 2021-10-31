using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public List<GameObject> playerList = new List<GameObject>();

    public List<GameObject> adjList = new List<GameObject>();

    //public GameObject[] emptyAdj = new GameObject[4];

    public bool swtchPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerList[0]);
        /*if (swtchPlayer)
        {
            SwipeTest.instance.player = playerList[0].transform;
            //GameManager.instance.swp.GetComponent<SwipeTest>().player = playerList[0].transform;


            //playerList.Add(other.gameObject);
        }

        else
        {
            //SwipeTest.instance.player = null;
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            playerList.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            playerList.Remove(other.gameObject);
        }
    }
}
