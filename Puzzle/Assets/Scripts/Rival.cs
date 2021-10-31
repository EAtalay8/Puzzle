using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rival : MonoBehaviour
{
    public float aiThink = 1;

    public GameObject hand;

    [Header("Rival Cube Pos")]

    public GameObject c1p;
    public GameObject c2p;
    public GameObject c3p;
    public GameObject c4p;
    public GameObject c5p;
    public GameObject c6p;
    public GameObject c7p;


    [Header("Rival Cubes")]

    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public GameObject c5;
    public GameObject c6;
    public GameObject c7;

    public static Rival instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        // 3.2f mesafe

        StartCoroutine(AI());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator AI()
    {
        hand.transform.DOMove(c7p.transform.position, 1f).SetEase(Ease.Linear);
        yield return new WaitForSeconds(0.8f);
        hand.GetComponent<Animator>().SetBool("finger", true);
        yield return new WaitForSeconds(0.2f);
        //hand.transform.DOMove(new Vector3(0, 1.5f, 15), 0.5f);

        c7.transform.Translate(Vector3.right * 3.2f);

        hand.transform.DOMove(c4p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c4.transform.Translate(Vector3.up * 3.2f); //rotationlarý ters

        hand.transform.DOMove(c1p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c1.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c2p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c2.transform.Translate(Vector3.left * 3.2f);

        hand.transform.DOMove(c5p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c5.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c6p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c6.transform.Translate(Vector3.left * 3.2f);

        hand.transform.DOMove(c3p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c3.transform.Translate(Vector3.up * 3.2f);

        hand.transform.DOMove(c5p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c5.transform.Translate(Vector3.right * 3.2f);

        hand.transform.DOMove(c6p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c6.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c7p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c7.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c4p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c4.transform.Translate(Vector3.right * 3.2f);

        hand.transform.DOMove(c1p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c1.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c2p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c2.transform.Translate(Vector3.up * 3.2f);

        hand.transform.DOMove(c6p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c6.transform.Translate(Vector3.left * 3.2f);

        hand.transform.DOMove(c7p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c7.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c2p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c2.transform.Translate(Vector3.right * 3.2f);

        hand.transform.DOMove(c6p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c6.transform.Translate(Vector3.up * 3.2f);

        hand.transform.DOMove(c7p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c7.transform.Translate(Vector3.left * 3.2f);

        hand.transform.DOMove(c5p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c5.transform.Translate(Vector3.left * 3.2f);

        hand.transform.DOMove(c3p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c3.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c4p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c4.transform.Translate(Vector3.right * 3.2f);

        hand.transform.DOMove(c2p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c2.transform.Translate(Vector3.up * 3.2f);

        hand.transform.DOMove(c3p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c3.transform.Translate(Vector3.up * 3.2f);

        hand.transform.DOMove(c5p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c5.transform.Translate(Vector3.right * 3.2f);

        hand.transform.DOMove(c2p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c2.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c4p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c4.transform.Translate(Vector3.left * 3.2f);

        hand.transform.DOMove(c2p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c2.transform.Translate(Vector3.down * 3.2f);

        hand.transform.DOMove(c4p.transform.position, 1).SetEase(Ease.Linear);
        yield return new WaitForSeconds(aiThink);

        c4.transform.Translate(Vector3.down * 3.2f);


        hand.transform.DOMove(new Vector3(0, 1.5f, 15), 1);
        hand.GetComponent<Animator>().SetBool("finger", false);
        yield return new WaitForSeconds(aiThink);
        
        GameManager.instance.Lose();
    } //don't open

}
