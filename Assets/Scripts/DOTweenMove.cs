using UnityEngine;
using System.Collections;
using DG.Tweening; // usingが必要

public class DOTweenMove : MonoBehaviour {

    private float _positionX;
    public float positionX {
        set
        {
            _positionX = value;
            transform.localPosition = new Vector3(
                _positionX,
                transform.localPosition.y,
                transform.localPosition.z
            );
        }
        get
        {
            return _positionX;
        }
    }

    void Start()
    {
        // Initializeが必要
        DOTween.Init();

        // カスタムプロパティ
        //DOTween.To(() => positionX, (x) => positionX = x, 2.0f, 1.0f)
        //  .SetEase(Ease.OutSine)
        //  .SetLoops(-1, LoopType.Yoyo)
        //  .OnStart(MoveStart)
        //  .OnComplete(MoveFinish);

        // shortcut
        // 拡張メソッド呼び出しが可能
        this.transform.DOMove(new Vector3(2, -1, 0), 1.0f)
          .SetEase(Ease.OutSine)
          .SetLoops(-1, LoopType.Yoyo)
          .OnStart(MoveStart)
          .OnComplete(MoveFinish);
    }

    void MoveStart()
    {
        Debug.Log("DOTween Move Start");
    }

    void MoveFinish()
    {
        Debug.Log("DOTween Move Finish");
    }
}
