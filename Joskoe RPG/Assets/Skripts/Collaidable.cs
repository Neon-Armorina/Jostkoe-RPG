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
}
