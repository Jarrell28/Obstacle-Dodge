using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField]float xValue = 0;
    [SerializeField]float yValue = 1f;
    [SerializeField]float zValue = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
