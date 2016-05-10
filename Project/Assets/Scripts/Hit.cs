using UnityEngine;
using System.Collections;

namespace FATEC.Corredor {
    public class Hit : MonoBehaviour {

        public ColliderDetector detector;

        public void Awake() {
            StartCoroutine(TestHit());
        }

        public IEnumerator TestHit() {
            while (true) {
                if (detector.inCollision) {
                    Debug.Log("GAME OVER");
                    //Application.LoadLevel("GameOver");
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}