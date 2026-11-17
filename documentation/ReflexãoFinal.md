# Semana 10 - Feedback visual e VFX

## Objetivo

Acrescentar dois estados visuais (**Inativo** e **Proximo**) ao cubo, à esfera e à pirâmide, sem perder a música ambiente nem os três efeitos sonoros da Semana 9.

## Solução implementada

| Objeto   | Estado inativo                           | Estado proximo                                                    |
| -------- | ---------------------------------------- | ----------------------------------------------------------------- |
| Cubo     | Material azul-escuro, sem partículas     | Material azul/ciano com emissão e partículas discretas            |
| Esfera   | Material verde-escuro, sem partículas    | Material verde mais claro e partículas suaves em redor            |
| Pirâmide | Material vermelho-escuro, sem partículas | Material vermelho mais vivo e partículas com movimento ascendente |

O `ProximityAudio` mantém a reprodução espacial existente. O `FeedbackProximidade` verifica a distância ao utilizador e, apenas quando muda o estado, troca o material e inicia ou para o Particle System. Os valores de proximidade são configurados no Inspector (durante os testes, foi utilizado o alcance de 6 unidades).

## Capturas de evidência

| Ficheiro                                                         | Conteúdo                                                       |
| ---------------------------------------------------------------- | -------------------------------------------------------------- |
| [01_environment.png](screenshots/01_environment.png)             | Cena geral                                                     |
| [02_inactive.png](screenshots/02_inactive.png)                   | Objetos em estado inativo                                      |
| [03_cube_active.png](screenshots/03_cube_active.png)             | Cubo próximo                                                   |
| [04_sphere_active.png](screenshots/04_sphere_active.png)         | Esfera próxima                                                 |
| [05_pyramid_active.png](screenshots/05_pyramid_active.png)       | Pirâmide próxima                                               |
| [06_materials.png](screenshots/06_materials.png)                 | Materiais de ambos os estados                                  |
| [07_particles.png](screenshots/07_particles.png)                 | Configuração do Particle System                                |
| [08_proximity.png](screenshots/08_proximity.png)                 | Referências dos scripts no Inspector                           |
| [09_material_settings.png](screenshots/09_material_settings.png) | Material emissivo                                              |
| [Video; Google Drive](https://drive.google.com/file/d/1MGMNs2aiQqVufHGnfUSbckA5PeCpRFJ2/view?usp=sharing)/[video_demonstracao.mp4](video_demonstracao.mp4) | Vídeo de demonstração do projeto, gravado através de uma build |

## Registo de debugging

- **Esperado:** partículas do cubo visíveis quando o utilizador se aproxima.
- **Observado:** partículas demasiado escuras ou de baixo contraste, embora a troca de material e a ativação do efeito funcionassem.
- **Causa identificada:** configuração visual do material das partículas, pouco adequada à iluminação e ao fundo da cena.
- **Correção:** material compatível com URP (`Particles/Unlit`), com transparência, modo de mistura **Alpha** e cor com maior contraste.
- **Validação:** novo teste em Play Mode; partículas passaram a ser visíveis durante a proximidade e pararam ao afastar o jogador.

## Verificação funcional

Foram testados no Editor: deslocação em primeira pessoa, limites do plano, som ambiente, sons espaciais dos três objetos e transição de materiais/partículas ao entrar e sair das zonas de proximidade. A execução fora do Editor será confirmada com uma build Windows distribuída separadamente.

## Reflexão breve

1. **Que informação transmite o feedback visual de cada objeto?**
   O feedback visual indica quando o jogador se aproxima de um objeto. Cada um tem um efeito diferente: o cubo apresenta pequenas partículas azuis que representam energia, a esfera utiliza partículas verdes suaves que sugerem movimento e a pirâmide apresenta partículas vermelhas ascendentes que transmitem uma sensação de atividade.

2. **Como a resposta visual foi integrada ao áudio?**
   O áudio apoia a localizar cada objeto, enquanto as alterações visuais confirmam a proximidade e identificam o elemento que está em foco.

3. **Quais dificuldades técnicas surgiram durante a implementação?**
   A principal dificuldade técnica foi o contraste das partículas, que foi resolvido após testar o material e o seu modo de transparência.

4. **Quais funcionalidades visuais deverão ser aprimoradas para uso futuro em VR/MR?**
   Verificar a legibilidade no headset e, se necessário, ajustar o tamanho, contraste e quantidade de partículas sem efeitos excessivos.
