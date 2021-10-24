using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwipeTest : MonoBehaviour
{
    public bool swpL;
    public bool swpR;
    public bool swpU;
    public bool swpD;

    public Swipe swipeControls;
    public Transform player;


    public static SwipeTest instance;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {

        //Debug.Log(Input.mousePosition);
        if (swipeControls.SwipeLeft)
        {
            swpL = true;
            //player.transform.Translate(Vector3.left * 2);
            StartCoroutine(SwpL());
        }
        if (swipeControls.SwipeRight)
        {
            swpR = true;
            //player.transform.Translate(Vector3.right * 2);
            StartCoroutine(SwpR());
        }
        if (swipeControls.SwipeUp)
        {
            swpU = true;
            //player.transform.Translate(Vector3.forward * 2);
            StartCoroutine(SwpU());
        }
        if (swipeControls.SwipeDown)
        {
            swpD = true;
            //player.transform.Translate(Vector3.back * 2);
            StartCoroutine(SwpD());
        }
    }

    public IEnumerator SwpL()
    {
        yield return new WaitForSeconds(0.1f);

        player.transform.Translate(Vector3.left * 3.2f);
        swpL = false;
    }

    public IEnumerator SwpR()
    {
        yield return new WaitForSeconds(0.1f);

        player.transform.Translate(Vector3.right * 3.2f);
        swpR = false;
    }

    public IEnumerator SwpU()
    {
        yield return new WaitForSeconds(0.1f);

        player.transform.Translate(Vector3.down * 3.2f);
        swpU = false;
    }

    public IEnumerator SwpD()
    {
        yield return new WaitForSeconds(0.1f);

        player.transform.Translate(Vector3.up * 3.2f);
        swpD = false;
    }
}
