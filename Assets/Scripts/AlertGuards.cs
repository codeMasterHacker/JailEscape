using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertGuards : MonoBehaviour
{
    public GameObject guard1;
    public GameObject guard2;

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
            guard1.GetComponent<Guard>().alerted = true;
            guard2.GetComponent<Guard>().alerted = true;
        }
    }
}
