# Semana 10 - Feedback visual e VFX

## Objetivo

Acrescentar dois estados visuais (**Inativo** e **Proximo**) ao cubo, à esfera e à pirâmide, sem perder a música ambiente nem os três efeitos sonoros da Semana 9.

## Solução implementada

| Objeto   | Estado inativo                           | Estado próximo                                                    |
| -------- | ---------------------------------------- | ----------------------------------------------------------------- |
| Cubo     | Material azul-escuro, sem partículas     | Material azul/ciano com emissão e partículas discretas            |
| Esfera   | Material verde-escuro, sem partículas    | Material verde mais claro e partículas suaves em redor            |
| Pirâmide | Material vermelho-escuro, sem partículas | Material vermelho mais vivo e partículas com movimento ascendente |

O `ProximityAudio` mantém a reprodução espacial existente. O `FeedbackProximidade` verifica a distância ao utilizador e, apenas quando muda o estado, troca o material e inicia ou para o Particle System. Os valores de proximidade são configurados no Inspector (durante os testes, foi utilizado o alcance de 6 unidades).

## Capturas de evidência

| Ficheiro | Conteúdo |
| --- | --- |
| [01_environment.png](screenshots/01_environment.png) | Cena geral |
| [02_inactive.png](screenshots/02_inactive.png) | Objetos em estado inativo |
| [03_cube_active.png](screenshots/03_cube_active.png) | Cubo próximo |
| [04_sphere_active.png](screenshots/04_sphere_active.png) | Esfera próxima |
| [05_pyramid_active.png](screenshots/05_pyramid_active.png) | Pirâmide próxima |
| [06_materials.png](screenshots/06_materials.png) | Materiais de ambos os estados |
| [07_particles.png](screenshots/07_particles.png) | Configuração do Particle System |
| [08_proximity.png](screenshots/08_proximity.png) | Referências dos scripts no Inspector |
| [09_material_settings.png](screenshots/09_material_settings.png) | Material emissivo |
