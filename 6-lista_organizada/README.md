# Desafio de Código 6
# Aplicação Console: Organizador de Lista ©️

# 📜
---
&NewLine;
&NewLine;
&NewLine;
&NewLine;
### Para Dúvidas, Sugestões e Feedbacks entre em contato via E-mail.
### 📧 Yuri.Chaves39@hotmail.com
&NewLine;
&NewLine;
> **Objetivos do Projeto**
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.
O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.
ENTRADA:
A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.
---

&NewLine;
&NewLine;

| Exemplo de Entrada | Saída Esperada |
| ----------- | ----------- |
| 2   |   |
| carne laranja suco picles laranja picles  | carne laranja picles suco |
| laranja pera laranja pera pera | laranja pera |


&NewLine;
&NewLine;

> **Funcionamento:**

&NewLine;

A aplicação inicialmente irá solicitar um valor inteiro que o usuário deve digitar para representar o número de listas que deve verificar. Após isso o usuário deve digitar todos os itens de cada lista ==searados por espaços== e em letras ==minúsculas== e pressionar enter, a aplicação retornará a lista organizada e então, em caso de mais de uma lista, o usuário deve repetir o processo.

---

==ao final do código foi adicionado o comando ReadKey() para o usuário visualizar o retorno da aplicação antes do seu encerramento.==
