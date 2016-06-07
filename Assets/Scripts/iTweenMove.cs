using UnityEngine;
using System.Collections;

public class iTweenMove : MonoBehaviour {

    void Start()
    {
        iTween.MoveBy(this.gameObject, iTween.Hash(
        	"x", 4.0f,
            "easeType", iTween.EaseType.easeOutSine,
            "time", 1.0f,
            "loopType", "pingPong",
            "onstart", "MoveStart",
            "oncomplete", "MoveFinish"
        ));
    }

    void MoveStart()
    {
        Debug.Log("iTween Move Start");
    }

    void MoveFinish()
    {
        Debug.Log("iTween Move Finish");
    }
}
