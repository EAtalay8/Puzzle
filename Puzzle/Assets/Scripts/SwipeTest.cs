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
    
    public Transform playerL;
    public Transform playerR;
    public Transform playerU;
    public Transform playerD;


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

        playerL.transform.Translate(Vector3.left * 3.2f);
        swpL = false;

        yield return new WaitForSeconds(0.1f);
        playerL = null;
    }

    public IEnumerator SwpR()
    {
        yield return new WaitForSeconds(0.1f);

        playerR.transform.Translate(Vector3.right * 3.2f);
        swpR = false;

        yield return new WaitForSeconds(0.1f);
        playerR = null;
    }

    public IEnumerator SwpU()
    {
        yield return new WaitForSeconds(0.1f);

        playerU.transform.Translate(Vector3.down * 3.2f);
        swpU = false;

        yield return new WaitForSeconds(0.1f);
        playerU = null;
    }

    public IEnumerator SwpD()
    {
        yield return new WaitForSeconds(0.1f);

        playerD.transform.Translate(Vector3.up * 3.2f);
        swpD = false;

        yield return new WaitForSeconds(0.1f);
        playerD = null;
    }
}
