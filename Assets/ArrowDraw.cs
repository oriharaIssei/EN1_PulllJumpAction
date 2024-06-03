using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowDraw : MonoBehaviour {

    [SerializeField]
    private Image arrowImage;
    private Vector3 clickPos;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            arrowImage.gameObject.SetActive(true);
            clickPos = Input.mousePosition;
        } else if (Input.GetMouseButtonUp(0)) {
            arrowImage.gameObject.SetActive(false);
        }
        if (Input.GetMouseButton(0)) {
            Vector3 dist = clickPos - Input.mousePosition;

            float size = dist.magnitude;
            float angleRad = Mathf.Atan2(dist.y, dist.x);

            arrowImage.rectTransform.position = clickPos;
            arrowImage.rectTransform.rotation =
                Quaternion.Euler(0, 0, angleRad * Mathf.Rad2Deg);
            arrowImage.rectTransform.sizeDelta = new Vector2(size, size);
        }
    }
}