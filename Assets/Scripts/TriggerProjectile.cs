using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;
    [SerializeField] GameObject[] projectiles1;

    void Awake()
    {
        SetProjectilesInactive(projectiles);
        SetProjectilesInactive(projectiles1);
    }
    void Start()
    {
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player") && gameObject.CompareTag("Trigger"))
        {
            SetProjectilesActive(projectiles);
            
        }

        if (collider.gameObject.CompareTag("Player") && gameObject.CompareTag("Trigger2"))
        {
            Debug.Log("Entered trigger 2");
            SetProjectilesActive(projectiles1);
            Debug.Log("Entered 2 after call");
        }
    }

    void SetProjectilesActive(GameObject[] projectileArg)
    {
        Debug.Log("Call the 2nd function???");
        foreach (GameObject projectile in projectileArg)
        {
            Debug.Log("Triggered Loop?");
            if (projectile)
            {
                Debug.Log("Projectile??");
                projectile.SetActive(true);
                
            }
        }
    }

    void SetProjectilesInactive(GameObject[] projectileArg)
    {
        foreach (GameObject projectile in projectileArg)
        {
            projectile.SetActive(false);
        }
    }
}
