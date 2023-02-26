using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BolaControler : MonoBehaviour
{
    //Criando a vari�vel para saber quem � meu RigidBody
    public Rigidbody2D meuRB;
    private Vector2 minhavelocidade;
    public float velocidade = 5f;
    public float meuLimiteHorizontal = 12f;
    public AudioClip boing;
    public Text score;
    public int points;
   

    // Start is called before the first frame update
    void Start()
    {
        int direcao = Random.Range(0,4);
        if (direcao == 0)
        {
            minhavelocidade.x = velocidade;
            minhavelocidade.y = velocidade;
        }
        else if (direcao == 1)
        {
            minhavelocidade.x = -velocidade;
            minhavelocidade.y = velocidade;
        }
        else if (direcao == 2)
        {
            minhavelocidade.x = -velocidade;
            minhavelocidade.y = -velocidade;
        }
        else
        {
            minhavelocidade.x = velocidade;
            minhavelocidade.y = -velocidade;
        }

        meuRB.velocity = minhavelocidade;
    }  

    // Update is called once per frame
    void Update()
    {
        score.text = points.ToString();

        if(transform.position.x > meuLimiteHorizontal || transform.position.x < - meuLimiteHorizontal)
        {   points += 1;
            SceneManager.LoadScene("Jogo");
        }
    }   
}
