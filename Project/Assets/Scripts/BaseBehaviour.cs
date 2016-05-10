using UnityEngine;

namespace FATEC.Corredor {
    public abstract class BaseBehaviour : MonoBehaviour {
        protected new Transform transform { get; set; }
        protected new Rigidbody rigidbody{ get; set; }

        protected virtual void Awake() {
            this.transform = this.gameObject.GetComponent<Transform>();
            this.rigidbody = this.gameObject.GetComponent<Rigidbody>();
        }
    }
}
