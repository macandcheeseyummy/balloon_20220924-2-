using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public static gameManager I;
    public float limit;
    public Text timeTxt;
    public GameObject over;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        limit += Time.deltaTime;
        timeTxt.text = limit.ToString("N2");

    }

    void makeSquare()
    {
        Instantiate(square);
    }

    public void gameOver()
    {
        over.SetActive(true);
        Invoke("gameStop", 0.5f);
    }

    void gameStop()
    {
        Time.timeScale = 0.0f;
    }
}
