using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDisappearer : MonoBehaviour
{
    public GameObject[] tiles;
    public int maxTime = 1;
    private bool paused = false;
    private bool on = true;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            StartCoroutine(AppearDisappear());
        }
    }

    IEnumerator AppearDisappear()
    {
        paused = true;

        on = !on;

        // for (int i = 0; i < tiles.Length; i++)
        // {
        //     if ((i+1) % selector == 0)
        //     {
        //         if (on)
        //         {
        //             tiles[i].SetActive(true);
        //         }
        //         else
        //         {
        //             tiles[i].SetActive(false);
        //         }
        //     }
        // }

        if (on)
        {
            tiles[i].SetActive(true);
            i++;
        }
        else
        {
            tiles[i].SetActive(false);
        }

        if (i >= tiles.Length)
        {
            i = 0;
        }

        yield return new WaitForSeconds(maxTime);

        paused = false;
    }
}
