using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float x,y,z;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}
