using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class DoTweenPruebaDados : MonoBehaviour
{
    public GameObject flecha, flecha2, flecha3, flecha4, flecha5, flecha6;
    public Vector3[] posicionGuardada;
    // La posición guardada previamente

    void Start()
    {
        // Guardamos la posición original de la flecha (como ejemplo)
        posicionGuardada[0] = flecha.transform.position;
        posicionGuardada[1] = flecha2.transform.position;
        posicionGuardada[2] = flecha3.transform.position;
        posicionGuardada[3] = flecha4.transform.position;
        posicionGuardada[4] = flecha5.transform.position;
        posicionGuardada[5] = flecha6.transform.position;
  
        // Cambiamos la posición de la flecha solo en el eje X
       
    }

  public  void MoverFlecha()
    {
        // Mover la flecha en el eje X con el valor de 'posicionGuardada.x', pero con Y = 1.25f
        Vector3 nuevaPosicion = new Vector3(posicionGuardada[0].x, 1.25f, posicionGuardada[0].z);

        // Usamos DOTween para mover solo en el eje X
        flecha.transform.DOMoveX(nuevaPosicion.x, 1f)  
            .SetEase(Ease.OutBounce);

       
        Vector3 nuevaPosicion1 = new Vector3(posicionGuardada[1].x, 1.25f, posicionGuardada[1].z);
   
        flecha2.transform.DOMoveX(nuevaPosicion1.x, 1f)  
            .SetEase(Ease.OutBounce);

     
        Vector3 nuevaPosicion2 = new Vector3(posicionGuardada[2].x, 1.25f, posicionGuardada[2].z);

        flecha3.transform.DOMoveX(nuevaPosicion2.x, 1f) 
            .SetEase(Ease.OutBounce);  

      
        Vector3 nuevaPosicion3 = new Vector3(posicionGuardada[3].x, 1.25f, posicionGuardada[3].z);

        flecha4.transform.DOMoveX(nuevaPosicion3.x, 1f) 
            .SetEase(Ease.OutBounce); 

        Vector3 nuevaPosicion4 = new Vector3(posicionGuardada[4].x, 1.25f, posicionGuardada[4].z);

        flecha5.transform.DOMoveX(nuevaPosicion4.x, 1f)  
            .SetEase(Ease.OutBounce);  

   
        Vector3 nuevaPosicion5 = new Vector3(posicionGuardada[5].x, 1.25f, posicionGuardada[5].z);

        flecha6.transform.DOMoveX(nuevaPosicion5.x, 1f)  
            .SetEase(Ease.OutBounce);  
    }
 

    public void EnterButton()
    {     

        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha.transform.DOMoveX(flecha.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce));

        //append -> hace los tween en orden
        //join -> hace los tween al mismo tiempo

    }
    public void ExitButton()
    {
        MoverFlecha();
    }

    public void EnterButton2()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha2.transform.DOMoveX(flecha2.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce));

    }
       
    public void EnterButton3()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha3.transform.DOMoveX(flecha3.transform.position.x + 0.4f, 1.25f).SetEase(Ease.OutBounce));
     
    }
   
    public void EnterButton4()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha4.transform.DOMoveX(flecha4.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce));

    }
   
    public void EnterButton5()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha5.transform.DOMoveX(flecha5.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce));

    }
   
    public void EnterButton6()
    {
        Sequence secuenciaTest = DOTween.Sequence();

        secuenciaTest.Append(flecha6.transform.DOMoveX(flecha6.transform.position.x - 0.4f, 1.25f).SetEase(Ease.OutBounce));

    }
  
}
