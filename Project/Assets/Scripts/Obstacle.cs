using UnityEngine;
using System.Collections;
namespace FATEC.Corredor {
    public class Obstacle {
        public Transform transform;
        public int type = 0;
        public bool isUsing = false;
        public int index;

        public Obstacle(Transform transform) {
            this.transform = transform;
            this.type = 0;
            this.isUsing = false;
            this.index = 0;
        }
    }
}