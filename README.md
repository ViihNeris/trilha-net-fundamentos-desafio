# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO. ==> Continue lendo para ver a solução da DEV.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Proposta
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

<br>

## Solução da Dev 👩🏻‍💻🟣
Como dito acima, o código contava com instruções comentadas para o auxílio do desenvolvimento da solução. Consegui concluir este desafio com êxito e lhe apresentarei a seguir:
<br>

### Definindo Preço Inicial e Por Hora: ⏳
![image](https://user-images.githubusercontent.com/93789218/207660296-8cb3e041-85ba-41d0-bc97-bd4e3045dbb4.png)

### Cadastrando Veículos: 🚗
![image](https://user-images.githubusercontent.com/93789218/207660582-b4901370-db81-4a76-897e-167f815d6e77.png)
![image](https://user-images.githubusercontent.com/93789218/207662002-0c5b8c43-fa1c-4dc1-a1eb-2213d6bd13b7.png)

### Listando Veículos 🚙
- Caso não exista veículos estacionados:

![image](https://user-images.githubusercontent.com/93789218/207661615-128f5d85-3abc-41d8-a733-33053b690390.png)

- Caso exista veículos estacionados:

![image](https://user-images.githubusercontent.com/93789218/207660957-410fcb49-2252-4acf-a45f-beab53df5a30.png)

### Removendo Veículos 🚯
- Caso não encontrado: 

![image](https://user-images.githubusercontent.com/93789218/207661201-f4c80e0c-f458-4e39-8ff2-1b4fbff9f96e.png)

- Caso encontrado: 

![image](https://user-images.githubusercontent.com/93789218/207661330-e074aef5-b16b-4253-8886-6d27f2432275.png)

### Saindo do Programa 🚪

![image](https://user-images.githubusercontent.com/93789218/207661826-de96f584-9342-45c6-8b29-23c0affb4677.png)

<br>

## Obrigada! ✅
Acompanhe mais projetos meus em https://github.com/ViihNeris 😉💜👩🏻‍💻


