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

    // Como declarar propriedades?
    // public -> Faz com que a Unity veja essa informação
    //   OBS: Poderia ser private, public ou não ter nada
    // GameObject -> Tipo da informação
    //   OBS: tipo deve ser algo válido para o C# (string, int,
    //        ou algum tipo da Unity como o GameObject, Transform, etc)
    // ativador -> nome da nossa informação (para usarmos depois)
    //   OBS: nome pode ser qualquer coisa
    public GameObject ativador;

    // Bau com letra maiúscula = tipo da informação
    // bau com letra minúscula = nome da propriedade/variável
    public Bau bau;

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
        // Se o col.gameObject for igual ao objeto do ativador
        if (col.gameObject == ativador)
        {
            // Exibe o nome do objeto em questão
            // print(col.name);

            // Executamos o método Abrir() do script Bau
            bau.Abrir();
        }
    }
}
