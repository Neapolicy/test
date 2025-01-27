using UnityEngine;

public class propagator : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float countdown;
    public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    public void Update()
    {
        if (countdown < spawnRate){
            countdown += Time.deltaTime;
        }
        else{
            countdown = 0;
            spawnpipe();
        }
    }

    public void spawnpipe(){
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), transform.position.z), transform.rotation);
    }
}
