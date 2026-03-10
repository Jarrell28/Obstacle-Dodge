using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // [SerializeField] GameObject projectile;
    [SerializeField] GameObject[] projectiles;

    void Start()
    {
        // projectiles = GameObject.FindGameObjectsWithTag("Projectile");
        // SetProjectilesInactive();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            SetProjectilesActive();
            
        }
    }

    void SetProjectilesActive()
    {
        foreach (GameObject projectile in projectiles)
        {
            if (projectile)
            {
                projectile.SetActive(true);
                
            }
        }
    }

    void SetProjectilesInactive()
    {
        foreach (GameObject projectile in projectiles)
        {
            projectile.SetActive(false);
        }
    }
}
