# Exercício Prático 2: O "Terminal de Suporte Proativo"

## Cenário:

Você foi contratado por uma empresa de TI para criar o Console de Diagnóstico de Rede. O sistema atual é terrível: o técnico precisa digitar comandos enormes sem errar uma letra. Se ele errar, o sistema apenas diz "Command Error" e apaga tudo.

---

## O Desafio:

Desenvolver um protótipo em C# que ajude o técnico a diagnosticar um servidor, focando em Acessibilidade e Prevenção de Erros.

---

## Requisitos da Missão:

1. Heurística #5 (Prevenção de Erros): Antes de executar uma ação crítica (como "Reiniciar Servidor"), o sistema deve pedir uma confirmação extra.
2. Heurística #6 (Reconhecimento em vez de Recordação): Em vez de o técnico ter que adivinhar o que digitar, o sistema deve exibir um "Menu de Comandos Rápidos" ou uma legenda fixa no rodapé da tela.
3. Heurística #10 (Ajuda e Documentação): Implemente um comando help ou ? que, quando digitado, mostre uma breve explicação de cada função disponível, sem sair da tela atual.
