using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorePoint : MonoBehaviour {
    public GameObject point;
    public int scorepoint;
    private int a;
    // Use this for initialization
    void Start() {
        this.point = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag == "SmallStarTag") {
            scorepoint += 10;
        } else if (other.gameObject.tag == "LargeStarTag") {
            scorepoint += 20;
        } else if (other.gameObject.tag == "SmallCloudTag") {
            scorepoint += 30;
        }
        this.point.GetComponent<Text>().text = "SCORE：" + this.scorepoint;
    }
}




