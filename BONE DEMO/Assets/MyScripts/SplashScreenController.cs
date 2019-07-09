﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour {

 
	// Use this for initialization
	void Start () {
        StartCoroutine(SplashScreen());
	}
	
    IEnumerator SplashScreen()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("BoneDemo");
    }

}
