# Interactive 3D Environment

Protótipo desenvolvido em **Unity 6.3 LTS (6000.3.27f1)**, com `Universal Render Pipeline (URP)`.

## Objetivo

Desenvolver progressivamente um ambiente 3D que responda à proximidade do utilizador através de sinais sonoros e visuais.

## Evolução do projeto

| Fase                               | Funcionalidades                                                                                                                                |
| ---------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| **Semana 9 - Áudio e proximidade** | Ambiente 3D, movimento em primeira pessoa, música ambiente contínua e sons 3D associados a um cubo, uma esfera e uma pirâmide.                 |
| **Semana 10 - Feedback visual**    | Dois estados por objeto (`Inativo` e `Proximo`), mudança de materiais e sistemas de partículas ativados pela proximidade, preservando o áudio. |

## Estrutura do repositório

- src/Projeto Unity: [src/](src/)
- Reflexão Final/Documentação: [ReflexãoFinal.md](documentation/ReflexãoFinal.md)
- Screenshots: [screenshots/](documentation/screenshots/)

As cenas principais ficam em `src/interactive-3d-environment/Assets/Scenes/`:

- `Semana09_AudioProximity.unity` - versão de referência da Semana 9.
- `Semana10_VisualFeedback.unity` - cena atual com os materiais e efeitos visuais.

## Funcionalidades principais

- **Player:** movimento com WASD e orientação com o rato.
- **Ambiente:** plano com limites invisíveis para manter o jogador dentro da área de teste.
- **Áudio:** som ambiente contínuo e três sons espaciais controlados pela proximidade, com atenuação em função da distância.
- **Feedback visual:** materiais distintos para os estados inativo e próximo; cada objeto tem partículas com apresentação própria.

## Como executar no Unity

- **Unity 6.3 LTS:** Projeto em `src/interactive-3d-environment/`, cena principal `Assets/Scenes/Semana10_VisualFeedback.unity`.

| Ação            | Controlo           |
| --------------- | ------------------ |
| Movimentação    | `W`, `A`, `S`, `D` |
| Olhar           | Rato               |
| Libertar cursor | `Esc`              |
| Capturar cursor | Clique esquerdo    |

## Autor

- `Guilherme Andrade`
- `A045395`
- [@adr-g](https://github.com/adr-g)
