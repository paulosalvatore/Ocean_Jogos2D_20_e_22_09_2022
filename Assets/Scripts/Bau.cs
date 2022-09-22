using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bau : MonoBehaviour
{
    /*
    - Abrir o baú significa trocar a imagem dele
    - Depois que abrir o baú, podemos criar um item na frente do baú
    - Ao passar em cima desse item, ele é coletado
    */

    // Componente SpriteRenderer
    public SpriteRenderer spriteRend;

    // Imagem do Baú Aberto
    public Sprite imagemBauAberto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Abrir()
    {
        // print("Abrir Baú!");

        spriteRend.sprite = imagemBauAberto;
    }
}
