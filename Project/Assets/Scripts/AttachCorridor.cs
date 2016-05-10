using UnityEngine;
using System.Collections;

namespace FATEC.Corredor {
    public class AttachCorridor : MonoBehaviour {

        public Corridor[][] corridorPiece;
        public Obstacle[][] obstaclePiece;

        public Corridor[] currentCorridorPiece;
        public Obstacle[] currentObstaclePieceL;
        public Obstacle[] currentObstaclePieceC;
        public Obstacle[] currentObstaclePieceR;

        public int AmountPiecesAttach;

        public float sizePiece;

        public Transform playerTransform;

        public string[] corridorTag;
        public string[] obstacleTag;


        public void Awake() {

            corridorTag = new string[] {"CorridorStandardPiece",
                                        "CorridorWindowPiece",
                                        "CorridorHolePiece"};
            obstacleTag = new string[] {"ObstacleWirePiece",
                                        "ObstaclePipePiece",
                                        "ObstacleBarrelPiece",
                                        "ObstacleLockerPiece",
                                        "ObstaclePipeColumnPiece",
                                        "ObstacleBarrelCenterPiece",
                                        "ObstacleLockerCenterPiece",};
            corridorPiece = new Corridor[corridorTag.Length][];
            for (var i = 0; i < corridorTag.Length; i++) {
                var GameObjecstPiece = GameObject.FindGameObjectsWithTag(corridorTag[i]);
                corridorPiece[i] = new Corridor[GameObjecstPiece.Length];
                for (var j = 0; j < corridorPiece[i].Length; j++) {
                    corridorPiece[i][j] = new Corridor(GameObjecstPiece[j].GetComponent<Transform>());
                    if (corridorPiece[i][j].transform != null) {
                        corridorPiece[i][j].transform.position = new Vector3(0, 0, 0);
                    }
                    corridorPiece[i][j].type = i;
                    corridorPiece[i][j].isUsing = false;
                    corridorPiece[i][j].index = j;
                    // Debug.Log(i + "-" + j + "-  " + corridorPiece[i][j].type);
                }
            }

            obstaclePiece = new Obstacle[obstacleTag.Length][];
            for (var i = 0; i < obstacleTag.Length; i++) {
                var GameObjecstPiece = GameObject.FindGameObjectsWithTag(obstacleTag[i]);
                obstaclePiece[i] = new Obstacle[GameObjecstPiece.Length];
                for (var j = 0; j < obstaclePiece[i].Length; j++) {
                    obstaclePiece[i][j] = new Obstacle(GameObjecstPiece[j].GetComponent<Transform>());
                    if (obstaclePiece[i][j].transform != null) {
                        obstaclePiece[i][j].transform.position = new Vector3(0, 0, 0);
                    }
                    obstaclePiece[i][j].type = i;
                    obstaclePiece[i][j].isUsing = false;
                    obstaclePiece[i][j].index = j;
                }
            }
            ///Randon first obstacles------------------------------------------------------------------
            currentCorridorPiece = new Corridor[AmountPiecesAttach];
            currentObstaclePieceL = new Obstacle[AmountPiecesAttach];
            currentObstaclePieceC = new Obstacle[AmountPiecesAttach];
            currentObstaclePieceR = new Obstacle[AmountPiecesAttach];

            var amount = 0;
            if (corridorPiece[0].Length >= AmountPiecesAttach) {
                amount = AmountPiecesAttach;
            }
            else {
                amount = corridorPiece[0].Length;
            }

            for (var i = 0; i < amount; i++) {

                int corridorType = -1;
                int corridorDirection = 0;
                int obstacleLeftType = -1;
                int obstacleCenterType = -1;
                int obstacleRightType = -1;
                RandomNextPiece(out corridorType, out corridorDirection, out obstacleLeftType, out obstacleCenterType, out obstacleRightType);
                if(i <= 3) {
                    corridorType = 0;
                    obstacleLeftType = -1;
                    obstacleCenterType = -1;
                    obstacleRightType = -1;
                }

                currentCorridorPiece[i] = GetCorridorFree(corridorType);
                currentObstaclePieceL[i] = GetObstacleFree(obstacleLeftType);
                currentObstaclePieceC[i] = GetObstacleFree(obstacleCenterType);
                currentObstaclePieceR[i] = GetObstacleFree(obstacleRightType);
                //Debug.Log(currentCorridorPiece[i].transform);
                //Debug.Log("corridorType" + corridorType);
                //Debug.Log("corridorDirection" + corridorDirection);
                //Debug.Log("obstacleLeftType" + obstacleLeftType);
                //Debug.Log("obstacleCenterType" + obstacleCenterType);
                //Debug.Log("obstacleRightType" + obstacleRightType);
                //Debug.Log("----------------------------------------------------");
                //corridor
                if (currentCorridorPiece[i] != null) {
                    currentCorridorPiece[i].transform.position = Vector3.zero;
                    currentCorridorPiece[i].transform.Translate(0, 0, i * sizePiece);
                    if (currentCorridorPiece[i].type == 1 && corridorDirection == 1) {
                        currentCorridorPiece[i].transform.localScale = new Vector3(-1, 1, 1);
                    }
                }
                //obstacle left
                if (currentObstaclePieceL[i] != null) {
                    currentObstaclePieceL[i].transform.position = Vector3.zero;
                    currentObstaclePieceL[i].transform.Translate(0, 0, i * sizePiece);
                    currentObstaclePieceL[i].transform.localScale = new Vector3(-1, 1, 1);
                }
                //obstacle center
                if (currentObstaclePieceC[i] != null) {
                    currentObstaclePieceC[i].transform.position = Vector3.zero;
                    currentObstaclePieceC[i].transform.Translate(0, 0, i * sizePiece);
                }
                //obstacle right
                if (currentObstaclePieceR[i] != null) {
                    currentObstaclePieceR[i].transform.position = Vector3.zero;
                    currentObstaclePieceR[i].transform.Translate(0, 0, i * sizePiece);
                }

            }
            ///------------------------------------------------------------------
            StartCoroutine(Attach());
        }
        /// <summary>Organization of pieces </summary>
        public IEnumerator Attach() {
            while (true) {
                if (playerTransform.position.z >= currentCorridorPiece[1].transform.position.z) {

                    int corridorType = -1;
                    int corridorDirection = 0;
                    int obstacleLeftType = -1;
                    int obstacleCenterType = -1;
                    int obstacleRightType = -1;
                    RandomNextPiece(out corridorType, out corridorDirection, out obstacleLeftType, out obstacleCenterType, out obstacleRightType);

                    //Corridor--------------------------------------------------------------------------------
                    Corridor auxCorridor = GetCorridorFree(corridorType);
                    if (auxCorridor == null) {
                        auxCorridor = currentCorridorPiece[0];
                    }
                    else {
                        auxCorridor.transform.position = currentCorridorPiece[0].transform.position;
                        FreePieceCorridor(currentCorridorPiece[0]);
                    }
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        currentCorridorPiece[i] = currentCorridorPiece[i + 1];
                    }
                    currentCorridorPiece[AmountPiecesAttach - 1] = auxCorridor;

                    //Obstacle left--------------------------------------------------------------------------------
                    Obstacle auxObstacle = GetObstacleFree(obstacleLeftType);

                    if (auxObstacle != null) {
                        auxObstacle.transform.position = auxCorridor.transform.position;
                    }
                    FreePieceObstacle(currentObstaclePieceL[0]);
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        currentObstaclePieceL[i] = currentObstaclePieceL[i + 1];
                    }
                    currentObstaclePieceL[AmountPiecesAttach - 1] = auxObstacle;

                    //Obstacle center--------------------------------------------------------------------------------
                    auxObstacle = GetObstacleFree(obstacleCenterType);

                    if (auxObstacle != null) {
                        auxObstacle.transform.position = auxCorridor.transform.position;
                    }
                    FreePieceObstacle(currentObstaclePieceC[0]);
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        currentObstaclePieceC[i] = currentObstaclePieceC[i + 1];
                    }
                    currentObstaclePieceC[AmountPiecesAttach - 1] = auxObstacle;

                    //Obstacle right--------------------------------------------------------------------------------
                    auxObstacle = GetObstacleFree(obstacleRightType);

                    if (auxObstacle != null) {
                        auxObstacle.transform.position = auxCorridor.transform.position;
                    }
                    FreePieceObstacle(currentObstaclePieceR[0]);
                    for (int i = 0; i < AmountPiecesAttach - 1; i++) {
                        currentObstaclePieceR[i] = currentObstaclePieceR[i + 1];
                    }
                    currentObstaclePieceR[AmountPiecesAttach - 1] = auxObstacle;


                    //corridor
                    if (currentCorridorPiece[AmountPiecesAttach - 1] != null) {
                        currentCorridorPiece[AmountPiecesAttach - 1].transform.Translate(0, 0, AmountPiecesAttach * sizePiece);
                        if (corridorDirection == 1) {
                            currentCorridorPiece[AmountPiecesAttach - 1].transform.localScale = new Vector3(-1, 1, 1);
                        }
                    }
                    //obstacle left
                    if (currentObstaclePieceL[AmountPiecesAttach - 1] != null) {
                        currentObstaclePieceL[AmountPiecesAttach - 1].transform.Translate(0, 0, AmountPiecesAttach * sizePiece);
                        currentObstaclePieceL[AmountPiecesAttach - 1].transform.localScale = new Vector3(-1, 1, 1);
                    }
                    //obstacle Center
                    if (currentObstaclePieceC[AmountPiecesAttach - 1] != null) {
                        currentObstaclePieceC[AmountPiecesAttach - 1].transform.Translate(0, 0, AmountPiecesAttach * sizePiece);
                    }
                    //obstacle Right
                    if (currentObstaclePieceR[AmountPiecesAttach - 1] != null) {
                        currentObstaclePieceR[AmountPiecesAttach - 1].transform.Translate(0, 0, AmountPiecesAttach * sizePiece);
                    }
                }
                yield return new WaitForEndOfFrame();
            }
        }

        public void FreePieceCorridor(Corridor corridor) {
            if (corridor != null) {
                Corridor cor = corridorPiece[corridor.type][corridor.index];
                cor.transform.position = new Vector3(0, 0, 0);
                cor.transform.localScale = new Vector3(1, 1, 1);
                cor.isUsing = false;
            }
        }

        public void FreePieceObstacle(Obstacle obstacle) {
            if (obstacle != null) {
                Obstacle obs = obstaclePiece[obstacle.type][obstacle.index];
                obs.transform.position = new Vector3(0, 0, 0);
                obs.transform.localScale = new Vector3(1, 1, 1);
                obs.isUsing = false;
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
            //0-    ---
            //1-    --c 
            ///piper, wire, barriel, etc..
            int obstacleTypeLeft = Random.Range(0, 5);
            int obstacleTypeCenter = Random.Range(5, 7);
            int obstacleTypeRight = Random.Range(0, 5);
            ///obstacles
            while (obstacleTypeLeft == obstacleTypeRight) {
                obstacleTypeLeft = Random.Range(0, 5);
            }



            ///if corridor window
            if (corridorType == 1) {
                ///left free window, on left
                if (obstacleSide == 1 ||
                    obstacleSide == 4 ||
                    obstacleSide == 8) {
                    corridorDirection = 1;
                }
                ///right free window, on right
                if (obstacleSide == 3 ||
                    obstacleSide == 6 ||
                    obstacleSide == 9) {
                    corridorDirection = 0;
                }
            }
            if (obstacleSide == 7 ||
                obstacleSide == 8 ||
                obstacleSide == 9) {
                corridorType = 2;
            }
            ///no window
            if (obstacleSide == 5) {
                corridorType = 0;
            }

            if (obstacleSide == 1 ||
                obstacleSide == 4 ||
                obstacleSide == 5 ||
                obstacleSide == 8) {
                obstacleRightType = obstacleTypeRight;
            }
            if (obstacleSide == 2 ||
                obstacleSide == 4 ||
                obstacleSide == 6) {
                obstacleCenterType = obstacleTypeCenter;
            }
            if (obstacleSide == 3 ||
                obstacleSide == 5 ||
                obstacleSide == 6 ||
                obstacleSide == 9) {
                obstacleLeftType = obstacleTypeLeft;
            }
        }

        public Corridor GetCorridorFree(int type) {
            if (type != -1) {
                for (var i = 0; i < corridorPiece[type].Length; i++) {
                    if (corridorPiece[type][i].isUsing == false && corridorPiece[type][i].transform != null) {
                        corridorPiece[type][i].isUsing = true;
                        return corridorPiece[type][i];
                    }
                }
                if (type != 0) {
                    for (var i = 0; i < corridorPiece[0].Length; i++) {
                        if (corridorPiece[0][i].isUsing == false && corridorPiece[0][i].transform != null) {
                            corridorPiece[0][i].isUsing = true;
                            return corridorPiece[0][i];
                        }
                    }
                }
            }
            return null;
        }

        public Obstacle GetObstacleFree(int type) {
            if (type != -1) {
                for (var i = 0; i < obstaclePiece[type].Length; i++) {
                    if (obstaclePiece[type][i].isUsing == false && obstaclePiece[type][i].transform != null) {
                        obstaclePiece[type][i].isUsing = true;
                        return obstaclePiece[type][i];
                    }
                }
            }
            return null;
        }
    }
}
