using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        PrintInstructions();
    }
    void PrintInstructions()
    {
        Debug.Log("Object Hit!");
    }
}
