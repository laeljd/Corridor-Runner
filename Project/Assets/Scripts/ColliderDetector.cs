using UnityEngine;
using System.Collections;

namespace FATEC.Corredor {
    public class ColliderDetector : BaseBehaviour {
        [Multiline]
        public string info;
        public string detectTag = "Untagged";
        public bool inCollision;
		public bool triggerStay;
		public bool triggerExit;

        protected void OnTriggerStay(Collider other) {
			if (triggerStay) {
				if (other.CompareTag(detectTag)) {
					inCollision = true;
				}
				else {
					inCollision = false;
				}
			}
        }

        protected void OnTriggerEnter(Collider other) {
                if (other.CompareTag(detectTag)) {
                inCollision = true;
            }
        }

        protected void OnTriggerExit(Collider other) {
			if (triggerExit) {
				if (other.CompareTag(detectTag)) {
					inCollision = false;
				}
			}
		}
	}
}