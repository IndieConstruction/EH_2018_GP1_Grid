using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour {

    public GridController gridController;
    public int XPos;
    public int YPos;

    int XPos_old;
    int YPos_old;

    // Use this for initialization
    void Start () {
        transform.position = gridController.GetWorldPosition(XPos, YPos);
    }
	
	// Update is called once per frame
	void Update () {
        XPos_old = XPos;
        YPos_old = YPos;

        if (Input.GetKeyDown(KeyCode.A)) {
            // sx
            XPos--;
            move();
        } else if (Input.GetKeyDown(KeyCode.D)) {
            XPos++;
            move();
            // dx
        } else if (Input.GetKeyDown(KeyCode.W)) {
            // up
            YPos++;
            move();
        } else if (Input.GetKeyDown(KeyCode.S)) {
            // down
            YPos--;
            move();
        }
    }

    void move() {
        if (gridController.IsValidPosition(XPos, YPos)) {
            transform.DOMove(gridController.GetWorldPosition(XPos, YPos), 0.6f).SetEase(Ease.Linear);
        } else {
            XPos = XPos_old;
            YPos = YPos_old;
        }
            
    }
}
