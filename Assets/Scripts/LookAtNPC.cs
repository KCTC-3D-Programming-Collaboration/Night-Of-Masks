using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtNPC : MonoBehaviour
{
    public Transform target;
    float oof=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorToTarget = target.position - transform.position;
        oof = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
        Quaternion desiredRotaion = Quaternion.LookRotation(vectorToTarget);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotaion, 500 * Time.deltaTime);
    }
    private void OnTriggerStay(Collider other)
    {
        Vector3 vectorToTarget = target.position - transform.position;
        oof = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
        Quaternion desiredRotaion = Quaternion.LookRotation(vectorToTarget);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotaion, 500 * Time.deltaTime);
    }


}
