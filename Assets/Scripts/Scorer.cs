using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {   
        hits++;
        Debug.Log("You've bumped into a wall this many times: " + hits);
        Debug.Log("Collision Block: " + collision.gameObject);
    }

}
