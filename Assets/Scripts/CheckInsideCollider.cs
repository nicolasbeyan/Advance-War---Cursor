using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckInsideCollider : MonoBehaviour
{
    private void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0f);

        foreach (Collider hitCollider in hitColliders)
        {
            Debug.Log(hitCollider.gameObject.name);
        }
    }
}
