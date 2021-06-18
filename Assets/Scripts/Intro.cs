using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
	public GameObject IntroPanel;
	public float seconds = 180f;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
    }

	IEnumerator CountDown()
	{
		yield return new WaitForSeconds(seconds);
		IntroPanel.SetActive(false);
	}
}
