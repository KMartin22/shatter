using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryBreached : MonoBehaviour
{
    public GameObject shard;
    public Animation Animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("floor contact");
        if (other.CompareTag("GameController") == true)
        {
            Debug.Log("gather playing");
            Animation.Play("gather");
        }
    }
}