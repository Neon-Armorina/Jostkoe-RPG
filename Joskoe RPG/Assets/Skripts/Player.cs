using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Some variables
    private BoxCollider2D _boxCollider;
    private Vector3 _moveDelta;
    private RaycastHit2D hit;

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

        // Check we can move in this direction, by casting a box there first, if the box returns null, we're free to move
        hit = Physics2D.BoxCast(transform.position, _boxCollider.size, 0, new Vector2(0, _moveDelta.y), Mathf.Abs(_moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking")); 
        if (hit.collider == null){
            // Player movement
            transform.Translate(0, _moveDelta.y * Time.deltaTime, 0);
        }

        hit = Physics2D.BoxCast(transform.position, _boxCollider.size, 0, new Vector2(_moveDelta.x, 0), Mathf.Abs(_moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            // Player movement
            transform.Translate(_moveDelta.x * Time.deltaTime, 0, 0);
        }
    }
}
