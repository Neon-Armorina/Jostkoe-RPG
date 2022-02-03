using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collaidable : MonoBehaviour
{

    public ContactFilter2D filter2D;
    private BoxCollider2D _boxCollider2D;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        // Collision Work
        _boxCollider2D.OverlapCollider(filter2D, hits);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            OnCollide(hits[i]);

            // Cleaning i in array
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }
}
