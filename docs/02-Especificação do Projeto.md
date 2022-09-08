# Especificações do Projeto


Haja vista, que atualmente o usuário interessado em acompanhar processos jurídicos se depara com a falta de informações realcionadas à estes. Dessa forma, o projeto busca desenvolver uma aplicação web que contenha dados quanto aos procedimentos dos processos e o progresso desses

Assim, neste documento serão abordadas as definições de persona, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto utilizando técnicas de obtenção de dados, como questionários online, para compreender de forma específica nosso usuário e suas necessidades.

## Personas

1 - Advogado - Aquele que acompanha o caso. Precisa de informações e acessos as atualizações do processo.
Exemplo: João Carlos é advogado e está acompanhando o processo de Luiz Mendes, que está sendo acusado de não pagar a pensão alimentícia dos filhos. Luiz Mendes não possui computador em casa, por isso João Carlos que acessa todas as informações e, posteriormente, entra em contato com Luiz pelo telefone e passa as atualizações.
Para tanto, o advogado irá precisar acessar essas informações. Provavelmente por meio de um código de acesso que apenas o advogado tem acesso.

2 – Réu – Aquele que é o mais interessado no andamento do processo. É a figura principal. Precisa ter o acesso para saber o andamento do seu processo.
Exemplo: Luiz Mendes está sendo processado pela ex-esposa por não pagar pensão alimentícia para os filhos. Com isso, possui um código de acesso para acompanhar o andamento do seu processo, inclusive para saber quando e se precisará ir até o Fórum ou entregar alguma documentação complementar.

3 – Assessor/Juiz – Aqueles que precisam ter acesso integral ao processo para saber o andamento para fins judiciais, para a tomada de decisões bem como o histórico de todo o processo.
Exemplo: Tadeu Farias é assessor do juiz Júlio. Com isso, precisa ter acesso a todo o histórico e atualizações do processo para deixa o juiz informado. Bem como analisar eventuais contratempos e saber exatamente em que momento deverá ter a interferência do juiz.

4 – Familiar/ Terceiro – Aqueles que não possuem vínculo no processo, mas que de alguma forma precisam ter informações. Ocorre no caso que o réu esteja incapacitado de acompanhar o processo, e com isso, passar as informações para o réu.
Exemplo: Maria é irmã de Luiz Mendes, que é réu do processo. Como Luiz Mendes se encontra aprisionado, Maria que acompanha todas as atualizações do processo.

5 –Desenvolvedores – São aqueles que conseguem fazer melhorias nos sistemas para que ocorra a evolução e manutenção do mesmo.
Exemplo: José é desenvolvedor de sistemas e presta suporte para o sistema UTI PROCESSUAL. Com isso, precisa ter acesso as funcionalidades para realizar as atividades.

6 – Digitador ou similar – Aquele que incluir, altera e modifita os processos conforma as atualizações.Exemplo: Mariana é a pessoa responsável por incluir os processos e manter os mesmos atualizados.

## Histórias de Usuários

Com base na análise das personas foram identificadas as seguintes histórias de usuários:

Advogados

• Como advogado, precisa registrar todos os resultados de audiências e atualizações dos casos para enviar ao fórum/comarca.

• Como Advogado, desejo salvar o documento em um arquivo para que os clientes possam abri-lo e consultar as atualizações.

• Como Advogado, desejo exibir na tela principal um relatório para que possa revisar todas as informações e requisitos do processo em uma única exibição.

• Como Advogado, quero encontrar palavras - chave para que possa identificar e manipular os processos que contêm as palavras-chave pesquisadas.

• Como Advogado, desejo imprimir uma visualização do documento para que eu possa revisar os processos sem a necessidade de executar a ferramenta.

Réu

• Como réu, preciso consultar as atualizações do meu processo, para saber qual foi a decisão tomada pelo juiz.

Juiz/Assessor

• Como Juiz, preciso receber as atualizações dos processos e informações dos advogados e delegados, para tomar a decisão correta e no tempo certo.

• Como assessor, desejo salvar o documento em um arquivo para criar pastas por processo.

• Como assessor, desejo anexar imagens e outros documentos aos processos para que eu possa ter maior controle das pendências.

• Como juiz, quero ordenar os processos por um atributo personalizado escolhido para que eu possa exibir o processo classificando por prioridade, crime, tipo de sentença, prazo de resposta, etc.

• Como assessor, desejo imprimir uma visualização do documento para que eu possa revisar os requisitos sem a necessidade de executar a ferramenta.

• Como juiz/assessor, desejo gerar um relatório de rastreabilidade para que eu possa analisar os prazos e o impacto dos processos sem resposta.

Familiar/ Terceiro

• Como familiar/terceiro, preciso consultar as atualizações do processo, para saber qual foi a decisão tomada pelo juiz e informar ao parente(réu)

Desenvolvedores

• Como desenvolvedor preciso manter o sistema em ordem e atualizado, para evitar perdas de informações e prazos de respostas por parte dos envolvido

Digitador ou similar

• Como digitador preciso registrar as informações no sistema para enviar as atualizações dos processos para as pessoas responsáveis.

• Digitador , desejo salvar automaticamente minhas alterações para não perdê-las se a ferramenta for encerrada inesperadamente antes de fechar um arquivo.

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| USUÁRIOS/CADASTRO |                                                                                                                                                                                                                  |
| ----------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ID                | Descrição do Requisito                                                                                                                                                                                           |
| RF-01             | O sistema permitirá que usuários pesquisem e acessem informações sobre os processos. |
| RF-02             | Os usuários cadastrado na caterogia de admin deverão informar: nome, login, senha, data de nascimento, endereço, e-mail, CEP, bairro, cidade, estado e CNA (Cadastro Nacional de Advogados). |
| RF-04             | O sistema permitirá que os administradores façam alterações em seus dados cadastrais.                                                                                                                                   |

| LOGIN |                                                                                                                                                                                            |
| ----- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| ID    | Descrição do Requisito                                                                                                                                                                     |
| RF-05 | O sistema permitirá o acesso dos usuários através do login e senha.                                                                                                                        |
| RF-06 | Autenticação de usuários cadastrados no sistema, sendo esses: Advogados, Juizes/Acessores, Digitadores e Réus permitindo o acesso e realização de operações em diferente áreas do sistema. |

| OPERAÇÕES DO USUÁRIO/ADVOGADO |                                                                                                                                                              |
| ----------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| ID                            | Descrição do Requisito                                                                                                                                       |
| RF-07                         | O usuário advogado, poderá registrar e gerenciar os documentos do sistema, fazendo alterações, atualizações de múltiplos processos.                          |
| RF-08                         | O usuário advogado, poderá registrar resultados e atualizações das audiências, podendo também compartilhar essas informações com o Forum/Comarca via sistema |
| RF-09                         | O usuário advogado, terá em uma tela, onde pode facilmente encontrar os dados e requisitos dos processos, em uma única exibição.                             |
| RF-10                         | O usuário advogado, poderá filtrar os diferentes processos por tipos, sendo os tipos palavras chaves para cada categoria de processo.                        |
| RF-11                         | O usuário advogado, poderá solicitar uma impressão dos arquivos cadastrados no sistema.                                                                      |

| OPERAÇÕES DO USUÁRIO/JUIZ/ACESSOR |                                                                                                                                                                                                  |
| --------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| RF-12                             | O usuário Juiz/Acessor, terá acesso a um dashboard contendo atualizações dos processos e informações dos advogados e delegados. Para a tomada de decisões com base em prioridades e data limite. |
| RF-13                             | O usuário Juiz/Acessor, salvará e criará as pastas dos processos                                                                                                                                 |
| RF-14                             | O usuário Juiz/Acessor, irá anexar imagens e outros documentos aos processos, para assim ter maios controle das pendências                                                                       |
| RF-15                             | O usuário Juiz/Acessor, poderá atribuir aos processos classificações de acordo com prioridade, crime, tipo de sentença, prazo de resposta, etc...                                                |
| RF-16                             | O usuário Juiz/Acessor, poderá solicitar uma impressão dos arquivos cadastrados no sistema.                                                                                                      |
| RF-17                             | O usuário Juiz/Acessor, irá gerar relatórios automáticos que informem prazos e os impactos dos processos sem respota.                                                                            |

| OPERAÇÕES DO USUÁRIO/RÉU/FAMILIA E TERCEIROS |                                                                                                                  |
| -------------------------------------------- | ---------------------------------------------------------------------------------------------------------------- |
| RF-18                                        | O usuário Réu, Poderá visualizar as informações e possíveis atualizações dos processos atrelados a este usuário. |

| OPERAÇÕES DO USUÁRIO/DESENVOLVEDOR |                                                                                                                        |
| ---------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| RF-19                              | O usuário Desenvolvedor, Terá acesso à todas às operações já mencionada, com a finalidade de manter o sistema em ordem |

### Requisitos não Funcionais

| OPERAÇÕES DO USUÁRIO/RÉU/FAMILIAR E TERCEIROS |                                                                      |
| --------------------------------------------- | -------------------------------------------------------------------- |
| RNF-01                                        | A interface deve ser agradável e de fácil utilização                 |
| RNF-02                                        | As alterações feitas no sistema deverão serem salvas automaticamente |
| RNF-03                                        | O aplicativo deve consumir poucos recursos do navegador              |
| RNF-04                                        | O sistema deve ser responsivo para uso em smartphones                |

## Restrições

01: Este sistema deverá ser acessado apenas por pessoas maiores de 18 anos.

02: No sistema conterá uma página com acesso permitido apenas para juízes e advogados do Fórum.

03: O sistema voltará ao início após um tempo de inatividade.

04: Este sistema só poderá ser alterado por pessoas autorizadas.

05: A pagina inicial do sistema (Login) só aceitará o número do CPF sem pontos.
