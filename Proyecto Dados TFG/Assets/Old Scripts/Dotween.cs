using UnityEngine;
using DG.Tweening;

public class Dotween : MonoBehaviour
{
    public GameObject dotweentestObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DoTweenTestFunction();
        }
    }

    void DoTweenTestFunction()
    {
        //dotweentestObject.transform.DOScaleX(dotweentestObject.transform.localScale.x + 4, 1.25f).SetEase(Ease.OutBounce).OnComplete(() => 
        //{
        //    dotweentestObject.transform.DOMoveY(dotweentestObject.transform.position.y + 2, 1.5f);
        //});

        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(dotweentestObject.transform.DOScaleX(dotweentestObject.transform.localScale.x + 4, 1.25f).SetEase(Ease.OutBounce))
            .Join(dotweentestObject.transform.DOMoveY(dotweentestObject.transform.position.y + 2, 1.5f))
            .Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        secuenciaTest.Append(dotweentestObject.transform.DOLocalRotate(new Vector3 (100,100,100), 3).OnComplete(() =>
        {
            Destroy(dotweentestObject);
        }));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
}
