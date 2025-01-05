using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject plane;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            projectile.SetActive(true);
            projectile2.SetActive(false);
            plane.SetActive(false);
        }
    }
    private void Start() {
    projectile.SetActive(false);
    }
}
