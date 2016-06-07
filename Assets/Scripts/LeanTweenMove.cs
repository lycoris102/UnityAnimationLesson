using UnityEngine;
using System.Collections;

public class LeanTweenMove : MonoBehaviour {

    void Start()
    {
        LeanTween.moveX(this.gameObject, 2.0f, 1.0f)
            .setEase(LeanTweenType.easeOutSine)
            .setLoopPingPong()
            .setOnStart(MoveStart)
            .setOnComplete(MoveFinish);
    }

    void MoveStart()
    {
        Debug.Log("LeanTween Move Start");
    }

    void MoveFinish()
    {
        Debug.Log("LeanTween Move Finish");
    }
}
