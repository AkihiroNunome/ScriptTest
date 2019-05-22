using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i <= array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int j = array.Length; j >= 0; j -= 1)
        {
            Debug.Log(array[j]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
