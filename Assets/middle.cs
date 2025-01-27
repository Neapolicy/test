using Unity.VisualScripting;
using UnityEngine;


public class middle : MonoBehaviour
{
    [SerializeField]
    private ui_manager manager;
    public void Start(){
        manager = GameObject.FindGameObjectWithTag("Logic").GetComponent<ui_manager>(); //finds the first instance of an object with the tag logic handler and sets it
    }
    private void OnTriggerEnter2D(Collider2D collision){
        manager.addScore();
    }
}
