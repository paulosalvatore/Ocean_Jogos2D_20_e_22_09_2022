using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar : MonoBehaviour
{
    /*
    - Detectar qual objeto de jogo irá ativar o baú
    - No momento em que esse objeto de jogo específico estiver em contato
    com o meu Trigger, ativarei o baú
    - Preciso pegar o baú e abrí-lo
    - Depois que abrir o baú, podemos criar um item na frente do baú
    - Ao passar em cima desse item, ele é coletado
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        print(col.name);
    }
}
