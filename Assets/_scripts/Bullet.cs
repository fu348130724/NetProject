using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    void OnCollsionEnter(Collision col) {

        var hit = col.gameObject;
        var combat = hit.GetComponent<Combat>();
        //var hitPlayer = hit.GetComponent<PlayerMove>();
        if (combat != null)
        {
           
            combat.TakeDamage(10);
            Destroy(gameObject);
        }

    }
}
