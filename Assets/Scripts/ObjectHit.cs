using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
            PrintInstructions();
            
        }
    }
    void PrintInstructions()
    {
        Debug.Log("Object Hit!");
    }
}
