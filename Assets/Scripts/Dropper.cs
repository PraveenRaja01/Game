using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float wait=3f;
    MeshRenderer myMesh;
    Rigidbody myRigidBody;
    void Start()
    {
        myMesh=GetComponent<MeshRenderer>();
        myMesh.enabled = false;
        myRigidBody=GetComponent<Rigidbody>();
        myRigidBody.useGravity= false;
    }
    void Update()
    {
        if(Time.time > wait)
        {
            myMesh.enabled = true;
            myRigidBody.useGravity= true;
            
        }
    }
}
