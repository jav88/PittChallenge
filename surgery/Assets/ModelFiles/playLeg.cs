using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playLeg : MonoBehaviour {

    private Animator anim;
    private Collider[] c;
    private BoxCollider scapel;
    private BoxCollider clamp1;
    private BoxCollider clamp2;
    private BoxCollider leg;
    private int count;
    private bool isCut;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        scapel = GameObject.Find("scapel_default").GetComponent<BoxCollider>();
        leg = GameObject.Find("legColliderYO").GetComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update () {
        if (scapel.bounds.Intersects(leg.bounds))
        {
            Debug.Log("Cutting yo");
            anim.SetBool("isOpening", true);
        }
    }
}
