using UnityEngine;
using System.Collections;
namespace FATEC.Corredor {
    public class Corridor {
        public Transform transform;
        public int type;
        public bool isUsing;
        public int index;

        public Corridor(Transform transform) {
            this.transform = transform;
            this.type = 0;
            this.isUsing = false;
            this.index = 0;
        }
    }
}