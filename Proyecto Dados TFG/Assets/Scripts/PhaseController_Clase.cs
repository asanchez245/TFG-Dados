using UnityEngine;

public class PhaseController_Clase : MonoBehaviour
{
    int _fasesTurno;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (_fasesTurno)
        {
            case 0:


                break;

            case 1:

                break;
        }
    }

    public void SwitchPhase() //cambia de fase
    {
        if (_fasesTurno < 1) //si la fase actual no es la ultima
        {
            _fasesTurno++; //pasa a la siguiente fase
        }
        else
        {
            _fasesTurno = 0; // resetea las fases de turno
            ChangeTurn(); //cambia de turno al del otro jugador
        }
    }

    public void ChangeTurn()
    {
        Debug.Log("Cambio de turno");
    }
}
