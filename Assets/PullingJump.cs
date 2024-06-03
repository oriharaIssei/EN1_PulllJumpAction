using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour {

    private Rigidbody rb;

    private Vector3 clickPos;
    private float jumpPower = 18;

    // Start is called before the first frame update
    void Start() {
        /* gameObject = êeÇÃGameObject (è»ó™â¬ */
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            clickPos = Input.mousePosition;
        } else if (Input.GetMouseButtonUp(0)) {
            Vector3 dist = clickPos - Input.mousePosition;

            if (dist.sqrMagnitude <= 1) {
                return;
            }
            rb.velocity = dist.normalized * jumpPower;
        }
    }
}
