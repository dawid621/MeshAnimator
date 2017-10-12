using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinnedEthanRun : MonoBehaviour {

  private Animator anim;


	// Use this for initialization
	void Start ()
  {
    anim = GetComponent<Animator>();
    anim.applyRootMotion = false;
	}
	
	// Update is called once per frame
	void Update ()
  {
    anim.SetFloat("Forward", 1);
	}
}
