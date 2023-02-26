using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteControler : MonoBehaviour
{
    private Vector3 minhaposicao;
    public float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;
    public bool player1;
    public bool automatico;

    // Pegando a posi��o da Bolaw
    public Transform transformBola;

    void Start()
    {
        
    }

    void Update()
    {
        minhaposicao = transform.position;
        minhaposicao.y = meuY;
              
        transform.position = minhaposicao;
       
        //Se o 'automatico' n�o � TRUE (ou seja, FALSE)
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            automatico = false;
        }       
        if (!automatico)
        {
            if (player1)
            {               
                if (Input.GetKey(KeyCode.W))
                {
                    meuY = meuY + velocidade * Time.deltaTime;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    meuY = meuY - velocidade * Time.deltaTime;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Return))
                {
                    automatico = true;
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    meuY = meuY + velocidade * Time.deltaTime;
                    automatico = false;
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    meuY = meuY - velocidade * Time.deltaTime;
                    automatico = false;
                }
            }
        }
        else
        {
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.18f);            
        }
        if (meuY > meuLimite)
        {
            meuY = meuLimite;
        }
        if (meuY < -meuLimite)
        {
            meuY = -meuLimite;
        }       
    }
}
