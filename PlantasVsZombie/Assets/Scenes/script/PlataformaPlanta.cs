using UnityEngine;

public class PlataformaPlanta : MonoBehaviour
{
    public GameObject objetoACriarBotaoEsquerdo; 
    public GameObject objetoACriarBotaoDireito;  
    public GameObject objetoDeReferencia;
    public int Moeda;
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
           
            if (CliqueNoObjeto(objetoDeReferencia))
            {
                Instantiate(objetoACriarBotaoEsquerdo, transform.position, Quaternion.identity);
            }
        }

       
        if (Input.GetMouseButtonDown(1))
        {
           
            if (CliqueNoObjeto(objetoDeReferencia))
            {
                Instantiate(objetoACriarBotaoDireito, transform.position, Quaternion.identity);
            }
        }
    }


    bool CliqueNoObjeto(GameObject objeto)
    {
        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

      
        return Physics.Raycast(raio, out hit) && hit.collider.gameObject == objeto;
    }
}