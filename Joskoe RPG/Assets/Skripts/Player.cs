using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Some variables
    private BoxCollider2D _boxCollider;
    private Vector3 _moveDelta;

    // Start is called before the first frame update
    private void Start(){
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate(){

        // Get movement coordinates
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // Refresh _moveDelta
        _moveDelta = new Vector3(x, y, 0);

        // Swap sprite direction, weither you going right or left
        if (_moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (_moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        // Player movement
        transform.Translate(_moveDelta * Time.deltaTime);
    }
}
