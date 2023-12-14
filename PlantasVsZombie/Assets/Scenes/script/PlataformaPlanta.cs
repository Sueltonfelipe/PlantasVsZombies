using UnityEngine;

public class PlataformaPlanta : MonoBehaviour
{
    public GameObject objetoACriar;  // Objeto que será criado

    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            // Cria o objeto na posição do objeto de referência
            Instantiate(objetoACriar, transform.position, Quaternion.identity);
        }
    }
}