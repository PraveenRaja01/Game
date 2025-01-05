using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Awake() 
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition=player.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,playerPosition,Time.deltaTime*speed);
        //if(transform.position==playerPosition)
        //destroy();
    }
    // void destroy()
    // {
    //     Destroy(gameObject);
    // }
}
