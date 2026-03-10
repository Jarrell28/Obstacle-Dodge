using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {
            hits++;
            Debug.Log("You've bumped into a wall this many times: " + hits);
            Debug.Log("Collision Block: " + collision.gameObject);
            
        }
    }

}
