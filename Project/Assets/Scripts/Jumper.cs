using UnityEngine;
using System.Collections;

namespace FATEC.Corredor {
    public class Jumper: BaseBehaviour {

        public void Jump(float JumpForce) {
            this.rigidbody.velocity = new Vector3(0, JumpForce, 0);
        }
    }
}
