using UnityEngine;
using tv.ouya.console.api;

namespace FATEC.Corredor {
    /// <summary>
    /// Configuration of joystick buttons.
    /// </summary>
    public class OUYAJoystick {
        public float GetAxis(int index) {
            float axis = 0;
            if(index == 0) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.IsControllerConnected(0)) {
				        axis = OuyaSDK.OuyaInput.GetAxis(0, OuyaController.AXIS_LS_X);
                    }
                #endif
            }
            else if(index == 1) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.IsControllerConnected(0)) {
				        axis = OuyaSDK.OuyaInput.GetAxis(0, OuyaController.AXIS_LS_Y);
                    }
                #endif
            }

            if (Mathf.Abs(axis) >= 0.5f) {
                return axis;
            }
            else {
                return 0;
            }

        }

        public bool GetButtonDown(int index) {
		 bool button = false;
            if (index == 0) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.GetButton(0, OuyaController.BUTTON_Y)) {
					        button = true;
			        } 
                #endif
                return button;
            }
			else if (index == 1) {
                #if UNITY_ANDROID && !UNITY_EDITOR
                    if (OuyaSDK.OuyaInput.GetButton(0, OuyaController.BUTTON_O)) {
					        button = true;
			        }
                #endif
                return button;
            }
            else {
                return false;
            }
        }
    }
}