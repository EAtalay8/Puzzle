using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public List<GameObject> planeList = new List<GameObject>();

    public bool rightEmpty;
    public bool downEmpty;
    public bool leftEmpty;
    public bool upEmpty;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Empty"))
        {
            other.gameObject.tag = "Occupied";
            planeList.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Occupied"))
        {
            other.gameObject.tag = "Empty";
            planeList.Remove(other.gameObject);
            //swtchPlayer = false;
            //SwipeTest.instance.player = null;
        }
    }
}
