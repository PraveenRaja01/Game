using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits=0;
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag !="Hit")
        {
        hits+=1;
        Debug.Log("You've bump into something this many times: "+hits);
        }
    }
}
