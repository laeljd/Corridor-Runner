using UnityEngine;
using System.Collections;

namespace FATEC.Corredor {
    public class PlayerController : MonoBehaviour {
        //public KeyboardJoystick joystick;
        public OUYAJoystick joystick;
        public Mover move;
        public Jumper jumper;
        public Transform playerTransform;
        public float speedX;
        public float speedZ;
        public float forceJump;

        public float right;
        public float center;
        public float left;

        public float currentPosition;
        public float newPosition;

        public ColliderDetector colliderDetector;

        public void Awake() {
            //joystick = new KeyboardJoystick();
            joystick = new OUYAJoystick();
            StartCoroutine(Moviment());
        }

        public IEnumerator Moviment() {
            while (true) {
                var z = joystick.GetAxis(0);
                var x = joystick.GetAxis(1);

                if (x != 0 && currentPosition == newPosition) {
                    if (x > 0 && currentPosition == left) {
                        newPosition = center;
                    }
                    if (x > 0 && currentPosition == center) {
                        newPosition = right;
                    }
                    if (x < 0 && currentPosition == right) {
                        newPosition = center;
                    }
                    if (x < 0 && currentPosition == center) {
                        newPosition = left;
                    }
                }
                if (currentPosition != newPosition) {
                    var direction = Mathf.Sign(newPosition - currentPosition);
                    move.Move(speedX * direction, 0, 0);
                    if (currentPosition == left && playerTransform.position.x > center) {
                        playerTransform.Translate(-(playerTransform.position.x - center), 0, 0);
                        currentPosition = newPosition;
                    }
                    if (currentPosition == center && playerTransform.position.x < left) {
                        playerTransform.Translate(-(playerTransform.position.x - left), 0, 0);
                        currentPosition = newPosition;
                    }
                    if (currentPosition == right && playerTransform.position.x < center) {
                        playerTransform.Translate(-(playerTransform.position.x - center), 0, 0);
                        currentPosition = newPosition;
                    }
                    if (currentPosition == center && playerTransform.position.x > right) {
                        playerTransform.Translate(-(playerTransform.position.x - right), 0, 0);
                        currentPosition = newPosition;
                    }
                }

                //if(z != 0) {
                    //move.Move(0, 0, z * speedZ);
                //}
                move.Move(0, 0, speedZ);


                if (joystick.GetButtonDown(0)) {
                    if (colliderDetector.inCollision) {
                        jumper.Jump(forceJump);
                    }
                }
                yield return new WaitForEndOfFrame();
            }
        }
    }
}

