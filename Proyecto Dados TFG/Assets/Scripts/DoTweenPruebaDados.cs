using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class DoTweenPruebaDados : MonoBehaviour
{
    public GameObject flecha, flecha2, flecha3, flecha4, flecha5, flecha6;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
 
    public void EnterButton()
    {     
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha.transform.DOMoveX(flecha.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce))
           /* .Join(dotweentestObject.transform.DOMoveX(dotweentestObject.transform.position.x - 6, 1.5f))*/;
            //.Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha.transform.DOMoveX(flecha.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce));
    }
    public void EnterButton2()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha2.transform.DOMoveX(flecha2.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce))
           /* .Join(dotweentestObject.transform.DOMoveX(dotweentestObject.transform.position.x - 6, 1.5f))*/;
        //.Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton2()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha2.transform.DOMoveX(flecha2.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce));
    }
    public void EnterButton3()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha3.transform.DOMoveX(flecha3.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce))
           /* .Join(dotweentestObject.transform.DOMoveX(dotweentestObject.transform.position.x - 6, 1.5f))*/;
        //.Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton3()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha3.transform.DOMoveX(flecha3.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce));
    }
    public void EnterButton4()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha4.transform.DOMoveX(flecha4.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce))
           /* .Join(dotweentestObject.transform.DOMoveX(dotweentestObject.transform.position.x - 6, 1.5f))*/;
        //.Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton4()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha4.transform.DOMoveX(flecha4.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce));
    }
    public void EnterButton5()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha5.transform.DOMoveX(flecha5.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce))
           /* .Join(dotweentestObject.transform.DOMoveX(dotweentestObject.transform.position.x - 6, 1.5f))*/;
        //.Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton5()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha5.transform.DOMoveX(flecha5.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce));
    }
    public void EnterButton6()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha6.transform.DOMoveX(flecha6.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce))
           /* .Join(dotweentestObject.transform.DOMoveX(dotweentestObject.transform.position.x - 6, 1.5f))*/;
        //.Join(dotweentestObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 2));


        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton6()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha6.transform.DOMoveX(flecha6.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce));
    }
}
