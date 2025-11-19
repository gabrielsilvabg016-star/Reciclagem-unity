using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class tabelaAuxiliar : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject imagemTabela;
    void Start() // cria a imagem e esconde ela
    {
        if (imagemTabela != null)
        {
            imagemTabela.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData eventData) //mostra a imagem se passar o mouse
    {
        if(imagemTabela != null)
        {
            imagemTabela.SetActive(true);
        }
    }

    public void OnPointerExit(PointerEventData eventData) //esconde a imagem quando tira o mouse
    {
        if(imagemTabela != null)
        {
            imagemTabela.SetActive(false);
        }
    }
}