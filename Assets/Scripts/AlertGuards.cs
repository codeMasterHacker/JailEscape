using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertGuards : MonoBehaviour
{
    public GameObject[] guards;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < guards.Length; i++)
            {
                guards[i].GetComponent<Guard>().alerted = true;
            }
        }
    }
}
