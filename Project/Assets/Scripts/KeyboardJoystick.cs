using UnityEngine;

namespace FATEC.Corredor {
    /// <summary>
    /// Configuration of joystick buttons.
    /// </summary>
    public class KeyboardJoystick {
        public float GetAxis(int index) {
            switch (index) {
                case 0: //Z
                    if (Input.GetKey(KeyCode.W)) {
                        return 1f;
                    }
                    else if (Input.GetKey(KeyCode.S)) {
                        return -1f;
                    }
                    else {
                        return 0f;
                    }
                case 1: //X
                    if (Input.GetKey(KeyCode.A)) {
                        return -1f;
                    }
                    else if (Input.GetKey(KeyCode.D)) {
                        return 1f;
                    }
                    else {
                        return 0f;
                    }
                default : return 0f;
            }
        }

        public bool GetButtonDown(int index) {
            if (index == 0) {
                return Input.GetKey(KeyCode.Space);
            }
            else {
                return false;
            }
        }
    }
}