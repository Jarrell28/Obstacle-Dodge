using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();    
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        transform.Translate(xValue, yValue, zValue);
    }
}
