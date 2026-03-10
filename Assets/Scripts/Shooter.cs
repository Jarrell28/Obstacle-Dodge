using UnityEngine;

public class Shooter : MonoBehaviour
{
    Vector3 playerPosition;
    [SerializeField] Transform player;
    [SerializeField] float shootSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MoveToPlayer();
        DestroyWhenReached();
        
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, shootSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
        Destroy(gameObject);
        }
    }
}
