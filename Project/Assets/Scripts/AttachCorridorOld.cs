using UnityEngine;
using System.Collections;

namespace FATEC.Corredor {
    public class AttachCorridorOld : MonoBehaviour {

        public Transform[] corridorStandardPiece;
        public bool[] corridorStandardPieceFree;

        public Transform[] corridorWindowPiece;
        public bool[] corridorWindowPieceFree;

        public Transform[] corridorHolePiece;
        public bool[] corridorHolePieceFree;

        public Transform[] obstacleWirePiece;
        public bool[] obstacleWirePieceFree;

        public Transform[] obstaclePipePiece;
        public bool[] obstaclePipePieceFree;

        public Transform[] obstacleBarrelPiece;
        public bool[] obstacleBarrelPieceFree;

        public Transform[] obstacleLockerPiece;
        public bool[] obstacleLockerPieceFree;

        public Transform[] obstaclePipeColumnPiece;
        public bool[] obstaclePipeColumnPieceFree;

        public Transform[] obstacleBarrelCenterPiece;
        public bool[] obstacleBarrelCenterPieceFree;

        public Transform[] obstacleLockerCenterPiece;
        public bool[] obstacleLockerCenterPieceFree;

        public Transform[] transformCurrentCorridor;
        public int[] typeCurrentCorridor;
        public int[] indexCurrentCorridor;
        public Transform[] transformCurrentOL;
        public int[] typeCurrentOL;
        public int[] indexCurrentOL;
        public Transform[] transformCurrentOC;
        public int[] typeCurrentOC;
        public int[] indexCurrentOC;
        public Transform[] transformCurrentOR;
        public int[] typeCurrentOR;
        public int[] indexCurrentOR;



        public int AmountPiecesAttach;

        public float sizePiece;

        public Transform playerTransform;

        public void Awake() {

            var GameObjecstPiece = GameObject.FindGameObjectsWithTag("CorridorStandardPiece");
            Debug.Log("CorridorStandardPiece" + "  " + GameObjecstPiece.Length);
            corridorStandardPiece = new Transform[GameObjecstPiece.Length];
            corridorStandardPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                corridorStandardPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                corridorStandardPieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("CorridorWindowPiece");
            Debug.Log("CorridorWindowPiece" + "  " + GameObjecstPiece.Length);
            corridorWindowPiece = new Transform[GameObjecstPiece.Length];
            corridorWindowPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                corridorWindowPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                corridorWindowPieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("CorridorHolePiece");
            Debug.Log("CorridorHolePiece" + "  " + GameObjecstPiece.Length);
            corridorHolePiece = new Transform[GameObjecstPiece.Length];
            corridorHolePieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                corridorHolePiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                corridorHolePieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstacleWirePiece");
            Debug.Log("ObstacleWirePiece" + "  " + GameObjecstPiece.Length);
            obstacleWirePiece = new Transform[GameObjecstPiece.Length];
            obstacleWirePieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstacleWirePiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstacleWirePieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstaclePipePiece");
            Debug.Log("ObstaclePipePiece" + "  " + GameObjecstPiece.Length);
            obstaclePipePiece = new Transform[GameObjecstPiece.Length];
            obstaclePipePieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstaclePipePiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstaclePipePieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstacleBarrelPiece");
            Debug.Log("ObstacleBarrelPiece" + "  " + GameObjecstPiece.Length);
            obstacleBarrelPiece = new Transform[GameObjecstPiece.Length];
            obstacleBarrelPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstacleBarrelPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstacleBarrelPieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstacleLockerPiece");
            Debug.Log("ObstacleLockerPiece" + "  " + GameObjecstPiece.Length);
            obstacleLockerPiece = new Transform[GameObjecstPiece.Length];
            obstacleLockerPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstacleLockerPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstacleLockerPieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstaclePipeColumnPiece");
            Debug.Log("ObstaclePipeColumnPiece" + "  " + GameObjecstPiece.Length);
            obstaclePipeColumnPiece = new Transform[GameObjecstPiece.Length];
            obstaclePipeColumnPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstaclePipeColumnPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstaclePipeColumnPieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstacleBarrelCenterPiece");
            Debug.Log("ObstacleBarrelCenterPiece" + "  " + GameObjecstPiece.Length);
            obstacleBarrelCenterPiece = new Transform[GameObjecstPiece.Length];
            obstacleBarrelCenterPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstacleBarrelCenterPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstacleBarrelCenterPieceFree[i] = true;
            }
            GameObjecstPiece = GameObject.FindGameObjectsWithTag("ObstacleLockerCenterPiece");
            Debug.Log("ObstacleLockerCenterPiece" + "  " + GameObjecstPiece.Length);
            obstacleLockerCenterPiece = new Transform[GameObjecstPiece.Length];
            obstacleLockerCenterPieceFree = new bool[GameObjecstPiece.Length];
            for (var i = 0; i < GameObjecstPiece.Length; i++) {
                obstacleLockerCenterPiece[i] = GameObjecstPiece[i].GetComponent<Transform>();
                obstacleLockerCenterPieceFree[i] = true;
            }

            ///------------------------------------------------------------------
            ///Randon first obstacles

            typeCurrentCorridor = new int[AmountPiecesAttach];
            indexCurrentCorridor = new int[AmountPiecesAttach];
            transformCurrentCorridor = new Transform[AmountPiecesAttach];

            typeCurrentOL = new int[AmountPiecesAttach];
            indexCurrentOL = new int[AmountPiecesAttach];
            transformCurrentOL = new Transform[AmountPiecesAttach];

            typeCurrentOC = new int[AmountPiecesAttach];
            indexCurrentOC = new int[AmountPiecesAttach];
            transformCurrentOC = new Transform[AmountPiecesAttach];

            typeCurrentOR = new int[AmountPiecesAttach];
            indexCurrentOR = new int[AmountPiecesAttach];
            transformCurrentOR = new Transform[AmountPiecesAttach];

            var amount = 0;
            if (corridorStandardPiece.Length >= AmountPiecesAttach) {
                amount = AmountPiecesAttach;
            }
            else {
                amount = corridorStandardPiece.Length;
            }

            for (var i = 0; i < amount; i++) {
                int corridorType = -1;
                int corridorDirection = 0;
                int obstacleLeftType = -1;
                int obstacleCenterType = -1;
                int obstacleRightType = -1;
                RandomNextPiece(out corridorType, out corridorDirection, out obstacleLeftType, out obstacleCenterType, out obstacleRightType);
                GetCorridorFree(corridorType, out transformCurrentCorridor[i], out typeCurrentCorridor[i], out indexCurrentCorridor[i]);
                GetObstacleSideFree(obstacleLeftType, out transformCurrentOL[i], out typeCurrentOL[i], out indexCurrentOL[i]);
                GetObstacleSideFree(obstacleCenterType, out transformCurrentOC[i], out typeCurrentOC[i], out indexCurrentOC[i]);
                GetObstacleSideFree(obstacleRightType, out transformCurrentOR[i], out typeCurrentOR[i], out indexCurrentOR[i]);

                //window
                if (typeCurrentCorridor[i] == 1 && corridorDirection == 1) {
                    transformCurrentCorridor[i].localRotation = new Quaternion(0, 0, 180, 0);
                }
                //obstacle left
                if (transformCurrentOL[i] != null) {
                    transformCurrentOL[i].localRotation = new Quaternion(0, 0, 180, 0);
                }

                transformCurrentCorridor[i].position = Vector3.zero;
                transformCurrentCorridor[i].Translate(0, 0, i * sizePiece);
            }
            ///------------------------------------------------------------------
            StartCoroutine(Attach());
        }
        /// <summary>Organization of pieces </summary>
        public IEnumerator Attach() {
            while (true) {
                if (playerTransform.position.z >= transformCurrentCorridor[1].position.z) {

                    Transform auxTransform = null;
                    int auxType = -1;
                    var auxIndex = -1;

                    int corridorType = -1;
                    int corridorDirection = 0;
                    int obstacleLeftType = -1;
                    int obstacleCenterType = -1;
                    int obstacleRightType = -1;
                    RandomNextPiece(out corridorType, out corridorDirection, out obstacleLeftType, out obstacleCenterType, out obstacleRightType);
                    GetCorridorFree(corridorType, out auxTransform, out auxType, out auxIndex);
                    if (auxTransform == null) {
                        auxTransform = transformCurrentCorridor[0];
                        auxType = typeCurrentCorridor[0];
                        auxIndex = indexCurrentCorridor[0];
                    }
                    else {
                        auxTransform.localPosition = transformCurrentCorridor[0].position;
                        FreePieceCorridor(transformCurrentCorridor[0], typeCurrentCorridor[0], indexCurrentCorridor[0]);
                    }
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        transformCurrentCorridor[i] = transformCurrentCorridor[i + 1];
                        typeCurrentCorridor[i] = typeCurrentCorridor[i + 1];
                        indexCurrentCorridor[i] = indexCurrentCorridor[i + 1];
                    }
                    transformCurrentCorridor[AmountPiecesAttach - 1] = auxTransform;
                    indexCurrentCorridor[AmountPiecesAttach - 1] = auxType;
                    indexCurrentCorridor[AmountPiecesAttach - 1] = auxIndex;

                    GetObstacleSideFree(obstacleLeftType, out auxTransform, out auxType, out auxIndex);
                    if (auxTransform == null) {
                        auxTransform = transformCurrentOL[0];
                        auxType = typeCurrentOL[0];
                        auxIndex = indexCurrentOL[0];
                    }
                    else {
                        auxTransform.localPosition = transformCurrentCorridor[0].position;
                        FreePieceCorridor(transformCurrentOL[0], typeCurrentOL[0], indexCurrentOL[0]);
                    }
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        transformCurrentOL[i] = transformCurrentOL[i + 1];
                        typeCurrentOL[i] = typeCurrentOL[i + 1];
                        indexCurrentOL[i] = indexCurrentOL[i + 1];
                    }
                    transformCurrentOL[AmountPiecesAttach - 1] = auxTransform;
                    typeCurrentOL[AmountPiecesAttach - 1] = auxType;
                    indexCurrentOL[AmountPiecesAttach - 1] = auxIndex;

                    GetObstacleSideFree(obstacleCenterType, out transformCurrentOC[0], out typeCurrentOC[0], out indexCurrentOC[0]);
                    if (auxTransform == null) {
                        auxTransform = transformCurrentOC[0];
                        auxType = typeCurrentOC[0];
                        auxIndex = indexCurrentOC[0];
                    }
                    else {
                        auxTransform.localPosition = transformCurrentCorridor[0].position;
                        FreePieceCorridor(transformCurrentOC[0], typeCurrentOC[0], indexCurrentOC[0]);
                    }
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        transformCurrentOC[i] = transformCurrentOC[i + 1];
                        typeCurrentOC[i] = typeCurrentOC[i + 1];
                        indexCurrentOC[i] = indexCurrentOC[i + 1];
                    }
                    transformCurrentOC[AmountPiecesAttach - 1] = auxTransform;
                    typeCurrentOC[AmountPiecesAttach - 1] = auxType;
                    indexCurrentOC[AmountPiecesAttach - 1] = auxIndex;

                    GetObstacleSideFree(obstacleRightType, out transformCurrentOR[0], out typeCurrentOR[0], out indexCurrentOR[0]);
                    if (auxTransform == null) {
                        auxTransform = transformCurrentOR[0];
                        auxType = typeCurrentOR[0];
                        auxIndex = indexCurrentOR[0];
                    }
                    else {
                        auxTransform.localPosition = transformCurrentCorridor[0].position;
                        FreePieceCorridor(transformCurrentOR[0], typeCurrentOR[0], indexCurrentOR[0]);
                    }
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        transformCurrentOR[i] = transformCurrentOR[i + 1];
                        typeCurrentOR[i] = typeCurrentOR[i + 1];
                        indexCurrentOR[i] = indexCurrentOR[i + 1];
                    }
                    transformCurrentOR[AmountPiecesAttach - 1] = auxTransform;
                    typeCurrentOR[AmountPiecesAttach - 1] = auxType;
                    indexCurrentOR[AmountPiecesAttach - 1] = auxIndex;

                    //corridor
                    if (typeCurrentCorridor[AmountPiecesAttach - 1] != -1) {
                        transformCurrentCorridor[AmountPiecesAttach - 1].Translate(0, 0, AmountPiecesAttach * sizePiece);
                        if (typeCurrentCorridor[AmountPiecesAttach - 1] == 1 && corridorDirection == 1) {
                            transformCurrentCorridor[AmountPiecesAttach - 1].localRotation = new Quaternion(0, 180 ,0, 0);
                        }
                    }
                    //obstacle left
                    if (transformCurrentOL[AmountPiecesAttach - 1] != null) {
                        transformCurrentOL[AmountPiecesAttach - 1].localRotation = new Quaternion(0, 180, 0, 0);
                        transformCurrentOL[AmountPiecesAttach - 1].Translate(0, 0, AmountPiecesAttach * sizePiece);
                    }
                    //obstacle Center
                    if (transformCurrentOC[AmountPiecesAttach - 1] != null) {
                        transformCurrentOC[AmountPiecesAttach - 1].Translate(0, 0, AmountPiecesAttach * sizePiece);
                    }
                    //obstacle Right
                    if (transformCurrentOR[AmountPiecesAttach - 1] != null) {
                        transformCurrentOR[AmountPiecesAttach - 1].Translate(0, 0, AmountPiecesAttach * sizePiece);
                    }
                }

                if (playerTransform.position.z < transformCurrentCorridor[0].position.z) {
                    transformCurrentCorridor[AmountPiecesAttach - 1].Translate(0, 0, -(AmountPiecesAttach * sizePiece));
                    var auxTransform = transformCurrentCorridor[AmountPiecesAttach - 1];
                    var auxType = typeCurrentCorridor[AmountPiecesAttach - 1];
                    var auxIndex = indexCurrentCorridor[AmountPiecesAttach - 1];

                    for (int i = AmountPiecesAttach - 1; i > 0; i--) {
                        transformCurrentCorridor[i] = transformCurrentCorridor[i - 1];
                        typeCurrentCorridor[i] = typeCurrentCorridor[i - 1];
                        indexCurrentCorridor[i] = indexCurrentCorridor[i - 1];
                    }
                    transformCurrentCorridor[0] = auxTransform;
                    indexCurrentCorridor[0] = auxType;
                    indexCurrentCorridor[0] = auxIndex;
                }
                yield return new WaitForEndOfFrame();
            }
        }

        public void FreePieceCorridor(Transform transform, int type, int index) {
            transform.position = new Vector3(0, 0, 0);
            if (index != -1) {
                if (type == 0) {
                    corridorStandardPieceFree[index] = true;
                }
                if (type == 1) {
                    Debug.Log(transform +" ----"+type + " ----" + index);
                    corridorWindowPieceFree[index] = true;
                }
                if (type == 2) {
                    corridorHolePieceFree[index] = true;
                }
            }
        }

        public void FreePieceObstacle(Transform transform, int type, int index) {
            transform.position = new Vector3(0, 0, 0);
            if (index != -1) {

                if (type == 0) {
                    if (obstacleWirePieceFree.Length > 0) {
                        obstacleWirePieceFree[index] = true;
                    }
                }
                if (type == 1) {
                    if (obstacleWirePieceFree.Length > 0) {
                        obstaclePipePieceFree[index] = true;
                    }
                }
                if (type == 2) {
                    if (obstacleBarrelPieceFree.Length > 0) {
                        obstacleBarrelPieceFree[index] = true;
                    }
                }
                if (type == 3) {
                    if (obstacleLockerPieceFree.Length > 0) {
                        obstacleLockerPieceFree[index] = true;
                    }
                }
                if (type == 4) {
                    if (obstaclePipeColumnPieceFree.Length > 0) {
                        obstaclePipeColumnPieceFree[index] = true;
                    }
                }
                if (type == 5) {
                    if (obstacleBarrelCenterPieceFree.Length > 0) {
                        obstacleBarrelCenterPieceFree[index] = true;
                    }
                }
                if (type == 6) {
                    if (obstacleLockerCenterPieceFree.Length > 0) {
                        obstacleLockerCenterPieceFree[index] = true;
                    }
                }
            }
        }

        public void RandomNextPiece(out int corridorType, out int corridorDirection, out int obstacleLeftType, out int obstacleCenterType, out int obstacleRightType) {
            obstacleLeftType = -1;
            obstacleCenterType = -1;
            obstacleRightType = -1;

            corridorDirection = Random.Range(0, 2);
            //0-    -->
            //1-    <-- 

            var obstacleSide = Random.Range(0, 10);
            //0-    ---
            //1-    --x 
            //2-    -x-
            //3-    x--
            //4-    -xx
            //5-    x-x
            //6-    xx-
            //7-    -v-
            //8-    -vx
            //9-    xv-
            corridorType = Random.Range(0, 2);
            Debug.Log(corridorType);

            //0-    ---
            //1-    --c 
            ///piper, wire, barriel, etc..
            int obstacleTypeLeft = Random.Range(0, 5);
            int obstacleTypeRight = Random.Range(0, 5);
            int obstacleTypeCenter = Random.Range(5, 7);

            ///if corridor wondow
            if (corridorType == 1) {
                ///left free window on left
                if (obstacleSide == 0 ||
                    obstacleSide == 1 ||
                    obstacleSide == 2 ||
                    obstacleSide == 4 ||
                    obstacleSide == 8) {

                    corridorDirection = 1;
                }
                ///right free window on right
                if (obstacleSide == 0 ||
                    obstacleSide == 2 ||
                    obstacleSide == 3 ||
                    obstacleSide == 6 ||
                    obstacleSide == 9) {

                    corridorDirection = 0;
                }
                ///left and right dont free without window
                if (obstacleSide == 5) {
                    corridorType = 0;
                }
            }

            ///obstacles
            while (obstacleTypeLeft == obstacleTypeRight) {
                obstacleTypeRight = Random.Range(0, 5);
            }

            ///definition of side of the obstacle
            if (obstacleSide == 3 ||
                obstacleSide == 5 ||
                obstacleSide == 6 ||
                obstacleSide == 9) {
                obstacleLeftType = obstacleTypeLeft;
            }

            if (obstacleSide == 2 ||
                obstacleSide == 4 ||
                obstacleSide == 6) {
                obstacleCenterType = obstacleTypeCenter;
            }
            if (obstacleSide == 1 ||
                obstacleSide == 4 ||
                obstacleSide == 5 ||
                obstacleSide == 8) {
                obstacleRightType = obstacleTypeRight;
            }
            ///hole
            if (obstacleSide >= 7 && obstacleSide <= 9) {
                corridorType = 2;
                obstacleCenterType = -1;
            }
        }

        public void GetCorridorFree(int type, out Transform transformCorridor, out int typeCorridor, out int indexCorridor) {
            transformCorridor = null;
            typeCorridor = -1;
            indexCorridor = -1;

            switch (type) {
                case 0:
                    for (var i = 0; i < corridorStandardPieceFree.Length; i++) {
                        if (corridorStandardPieceFree[i] && corridorStandardPiece[i] != null) {
                            corridorStandardPieceFree[i] = false;
                            transformCorridor = corridorStandardPiece[i];
                            indexCorridor = i;
                            break;
                        }
                    }
                    break;
                case 1:
                    for (var i = 0; i < corridorWindowPieceFree.Length; i++) {
                        if (corridorWindowPieceFree[i] && corridorWindowPiece[i] != null) {
                            corridorWindowPieceFree[i] = false;
                            transformCorridor = corridorWindowPiece[i];
                            indexCorridor = i;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < corridorHolePieceFree.Length; i++) {
                        if (corridorHolePieceFree[i] && corridorHolePiece[i] != null) {
                            corridorHolePieceFree[i] = false;
                            transformCorridor = corridorHolePiece[i];
                            indexCorridor = i;
                            break;
                        }
                    }
                    break;
                default:
                    for (var i = 0; i < corridorStandardPieceFree.Length; i++) {
                        if (corridorStandardPieceFree[i] && corridorStandardPiece[i] != null) {
                            corridorStandardPieceFree[i] = false;
                            transformCorridor = corridorStandardPiece[i];
                            indexCorridor = i;
                            break;
                        }
                    }
                    typeCorridor = 0;
                    break;
            }
            if (transformCorridor == null && type != 0) {
                for (var i = 0; i < corridorStandardPieceFree.Length; i++) {
                    if (corridorStandardPieceFree[i] && corridorStandardPiece[i] != null) {
                        corridorStandardPieceFree[i] = false;
                        transformCorridor = corridorStandardPiece[i];
                        indexCorridor = i;
                        break;
                    }
                }
                type = 0;
            }
            if (transformCorridor == null) {
                typeCorridor = -1;
            }
            else {
                typeCorridor = type;
            }
        }

        public void GetObstacleSideFree(int type, out Transform transformObstacle, out int typeObstacle, out int indexObstacle) {
            transformObstacle = null;
            typeObstacle = -1;
            indexObstacle = -1;
            switch (type) {
                case 0:
                    for (var i = 0; i < obstacleWirePieceFree.Length; i++) {
                        if (obstacleWirePieceFree[i] && obstacleWirePiece[i] != null) {
                            obstacleWirePieceFree[i] = false;
                            transformObstacle = obstacleWirePiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                case 1:
                    for (var i = 0; i < obstaclePipePieceFree.Length; i++) {
                        if (obstaclePipePieceFree[i] && obstaclePipePiece[i] != null) {
                            obstaclePipePieceFree[i] = false;
                            transformObstacle = obstaclePipePiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                case 2:
                    for (var i = 0; i < obstacleBarrelPieceFree.Length; i++) {
                        if (obstacleBarrelPieceFree[i] && obstacleBarrelPiece[i] != null) {
                            obstacleBarrelPieceFree[i] = false;
                            transformObstacle = obstacleBarrelPiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                case 3:
                    for (var i = 0; i < obstacleLockerPieceFree.Length; i++) {
                        if (obstacleLockerPieceFree[i] && obstacleLockerPiece[i] != null) {
                            obstacleLockerPieceFree[i] = false;
                            transformObstacle = obstacleLockerPiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                case 4:
                    for (var i = 0; i < obstaclePipeColumnPieceFree.Length; i++) {
                        if (obstaclePipeColumnPieceFree[i] && obstaclePipeColumnPiece[i] != null) {
                            obstaclePipeColumnPieceFree[i] = false;
                            transformObstacle = obstaclePipeColumnPiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                case 5:
                    for (var i = 0; i < obstacleLockerCenterPieceFree.Length; i++) {
                        if (obstacleLockerCenterPieceFree[i] && obstacleLockerCenterPiece[i] != null) {
                            obstacleLockerCenterPieceFree[i] = false;
                            transformObstacle = obstacleLockerCenterPiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                case 6:
                    for (var i = 0; i < obstacleBarrelCenterPieceFree.Length; i++) {
                        if (obstacleBarrelCenterPieceFree[i] && obstacleBarrelCenterPiece[i] != null) {
                            obstacleBarrelCenterPieceFree[i] = false;
                            transformObstacle = obstacleBarrelCenterPiece[i];
                            indexObstacle = i;
                            break;
                        }
                    }
                    break;
                default:
                    typeObstacle = -1;
                    break;
            }
            if (transformObstacle == null) {
                typeObstacle = -1;
            }
            else {
                typeObstacle = type;
            }
        }

        //public Transform GetCorridorFree(int typeCorridor, out int typeFree) {
        //    Transform piece = null;
        //    int typeCorridorInitial = typeCorridor;
        //    int typeCorridorSubstitute = -1;
        //    bool pieceOk = false;
        //    typeFree = -1;
        //    do {
        //        switch (typeCorridor) {
        //            case 0:
        //                for (var i = 0; i < corridorStandardPieceFree.Length; i++) {
        //                    if (corridorStandardPieceFree[i]) {
        //                        corridorStandardPieceFree[i] = false;
        //                        piece = corridorStandardPiece[i];
        //                        break;
        //                    }
        //                }
        //                break;
        //            case 1:
        //                for (var i = 0; i < corridorWindowPieceFree.Length; i++) {
        //                    if (corridorWindowPieceFree[i]) {
        //                        corridorWindowPieceFree[i] = false;
        //                        piece = corridorWindowPiece[i];
        //                        break;
        //                    }
        //                }
        //                break;
        //            case 2:
        //                for (var i = 0; i < corridorHolePieceFree.Length; i++) {
        //                    if (corridorHolePieceFree[i]) {
        //                        corridorHolePieceFree[i] = false;
        //                        piece = corridorHolePiece[i];
        //                        break;
        //                    }
        //                }
        //                break;
        //            default:
        //                typeFree = -1;
        //                pieceOk = true;
        //                break;
        //        }
        //        if (piece == null && !pieceOk) {
        //            typeCorridorSubstitute++;
        //            typeCorridor = typeCorridorSubstitute;
        //            if (typeCorridor == typeCorridorInitial) {
        //                typeCorridor++;
        //                typeCorridorSubstitute++;
        //            }
        //        }
        //        else {
        //            typeFree = typeCorridor;
        //            pieceOk = true;
        //        }
        //    } while (!pieceOk);
        //    return piece;
        //}
    }
}
