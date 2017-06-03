using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class Player : MonoBehaviour {

    public float speed;
    PlayerController controller;
    GunController gunController;

	// Use this for initialization
	void Start () {
        controller = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * speed;
        controller.Move(moveVelocity);

        //Weapon Input
        if (Input.GetMouseButton(0)) {
            gunController.Shoot();
        }
    }
}
