using UnityEngine;

public class PlataformaPlanta : MonoBehaviour
{
    public GameObject objetoACriarBotaoEsquerdo;  // Objeto a ser criado ao clicar com o botão esquerdo
    public GameObject objetoACriarBotaoDireito;   // Objeto a ser criado ao clicar com o botão direito
    public GameObject objetoDeReferencia;         // Objeto de referência para verificar o clique

    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi clicado
        if (Input.GetMouseButtonDown(0))
        {
            // Cria o objeto correspondente ao botão esquerdo apenas se o clique for no objeto de referência
            if (CliqueNoObjeto(objetoDeReferencia))
            {
                Instantiate(objetoACriarBotaoEsquerdo, transform.position, Quaternion.identity);
            }
        }

        // Verifica se o botão direito do mouse foi clicado
        if (Input.GetMouseButtonDown(1))
        {
            // Cria o objeto correspondente ao botão direito apenas se o clique for no objeto de referência
            if (CliqueNoObjeto(objetoDeReferencia))
            {
                Instantiate(objetoACriarBotaoDireito, transform.position, Quaternion.identity);
            }
        }
    }

    // Função para verificar se o clique foi no objeto de referência
    bool CliqueNoObjeto(GameObject objeto)
    {
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Verifica se o raio atinge o objeto de referência
        return Physics.Raycast(raio, out hit) && hit.collider.gameObject == objeto;
    }
}