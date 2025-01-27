using System;
using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine;

public class birb_script : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody2D;
    [SerializeField]
    private ui_manager ui_Manager;
    private bool isAlive = true;
    public float flapStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ui_Manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ui_manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive){
            rigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
         //.direction is shorthand for coords, ex up would be (0, 1), right is (1, 0), etc...
    }

    public void OnCollisionEnter2D(Collision2D coll){
        Debug.Log("collided");
        isAlive = false;
        ui_Manager.gameOver();
    }
}
