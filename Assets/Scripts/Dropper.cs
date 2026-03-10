using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3;
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            if(!rigidBody.useGravity && !meshRenderer.enabled)
            {
                meshRenderer.enabled = true;
                rigidBody.useGravity = true;
                Debug.Log("Block Dropped!");
            }
            
        }
    }
}
