using UnityEngine;

public class pip_pip_hooray : MonoBehaviour
{
    public float ms = 7.5f;
    public float deadzone = -55;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadzone){
            Destroy(gameObject);
        }
        transform.position += Vector3.left * ms * Time.deltaTime;
    }
}
