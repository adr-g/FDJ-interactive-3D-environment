using UnityEngine;

public class FeedbackProximidade : MonoBehaviour
{
    [Header("Referências")]
    [SerializeField] private Transform jogador;
    [SerializeField] private Renderer objetoRenderer;
    [SerializeField] private ParticleSystem particulas;

    [Header("Proximidade")]
    [SerializeField] private float distanciaAtivacao = 6f;

    [Header("Materiais")]
    [SerializeField] private Material materialInativo;
    [SerializeField] private Material materialProximo;

    private bool estavaProximo = false;

    void Start()
    {
        if (jogador == null && Camera.main != null)
            jogador = Camera.main.transform;

        if (objetoRenderer == null)
            objetoRenderer = GetComponent<Renderer>();

        if (particulas != null)
            particulas.Stop(true,
                ParticleSystemStopBehavior.StopEmittingAndClear);

        AtualizarEstadoVisual(false);
    }

    void Update()
    {
        if (jogador == null)
            return;

        float distancia = Vector3.Distance(
            jogador.position,
            transform.position
        );

        bool estaProximo = distancia <= distanciaAtivacao;

        if (estaProximo != estavaProximo)
        {
            AtualizarEstadoVisual(estaProximo);
            estavaProximo = estaProximo;
        }
    }

    void AtualizarEstadoVisual(bool proximo)
    {
        if (objetoRenderer != null)
        {
            Material novoMaterial = proximo
                ? materialProximo
                : materialInativo;

            if (novoMaterial != null)
                objetoRenderer.sharedMaterial = novoMaterial;
        }

        if (particulas != null)
        {
            if (proximo)
                particulas.Play();
            else
                particulas.Stop(true,
                    ParticleSystemStopBehavior.StopEmittingAndClear);
        }
    }
}
