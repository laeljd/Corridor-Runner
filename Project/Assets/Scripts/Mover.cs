using UnityEngine;

namespace FATEC.Corredor{
    public class Mover : BaseBehaviour {
        public void Move(float x, float y, float z) {
            this.transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
        }
    }
}
