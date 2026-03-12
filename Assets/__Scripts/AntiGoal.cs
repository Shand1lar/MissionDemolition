using UnityEngine;
using System.Collections;

public class AntiGoal : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Projectile") {
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 1;
            mat.color = c;
            MissionDemolition.AntiGoalHit();
        }
    }
}
