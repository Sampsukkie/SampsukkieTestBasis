using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //TESTI
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PerformAnimation();
        }
    }

    void PerformAnimation()
    {
        transform.DOMove(new Vector3(0, 7.5f, -8.5f), 0.4f);
        transform.DORotate(new Vector3(360, 360, 0), 8.25f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart)
            .SetDelay(1.25f);

        transform.DOScale(new Vector3(2, 2, 2), 0.6f)
            .SetDelay(0.5f)
            .SetEase(Ease.InOutElastic);
    }
}
