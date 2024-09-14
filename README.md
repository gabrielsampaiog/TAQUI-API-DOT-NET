# ![Projeto Taqui](https://i.ibb.co/0jg7twX/BANNER-TAQUI.png)

---

# SPRINT 03 - .NET

Disciplina: 
ADVANCED BUSINESS DEVELOPMENT WITH .NET

Professor: 
THIAGO KELLER

Entrega: 
Desenvolver uma API utilizando ASP.NET Core Web API, aplicando princípios de arquitetura de software, design patterns, técnicas de documentação, testes e integração com banco de dados.

Explicação da arquitetura:
Estamos adotando uma arquitetura de microservices para criar um sistema mais modular e escalável, onde cada serviço é responsável por uma funcionalidade específica e opera de forma independente. Isso nos permite escalar e atualizar componentes de maneira isolada, garantindo maior flexibilidade e eficiência tanto no desenvolvimento quanto na manutenção. A segmentação em microserviços também aumenta a resiliência do sistema, pois a falha de um serviço não compromete o funcionamento global. Além disso, facilita a incorporação de novas tecnologias e práticas à medida que as necessidades evoluem. Considerando o escopo do projeto, o TAQUI visa expandir para além do módulo de celulares, algo que seria inviável em uma arquitetura monolítica, devido à complexidade crescente e à magnificação do código com a expansão.

Design patterns utilizados Error Handling, DTOs (Data transfer Object), Service Layer e Repository Pattern

Instruções de uso: Trocar usuário e senha no arquivo appsettings.json e rodar o comanto Update-database no terminal dentro do projeto.

```json
{
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "OracleFIAP": "Data Source=oracle.fiap.com.br:1521/orcl;User ID=rm552342;Password=010605;"
    }
}

```
---

# Projeto TAQUI

Desenvolver um ambiente autossustentável que se concentre em analisar e fornecer insights com base no comportamento em tempo real dos consumidores é crucial. Priorizamos entender cada indivíduo em sua singularidade, em vez de agrupá-los em categorias genéricas. Conhecer a fundo a jornada atual e o histórico de uma pessoa, como John Doe, é mais valioso do que simplesmente rotulá-lo com características demográficas como gênero, orientação sexual, classe social, cor ou estado civil.

Diariamente, somos bombardeados por mais de 5 mil marcas diferentes***, através de uma variedade de canais de comunicação, alguns mais intrusivos que outros. Em média, uma pessoa percebe cerca de 153 anúncios entre os 362 aos quais é exposta diariamente. Destes, apenas cerca de 12 têm potencial para gerar engajamento e permanecer na memória do consumidor. ***

Há formas de comunicação mais intrusivas, onde dados pessoais são inseridos em sistemas, como números de telefone, e-mails ou qualquer cadastro que retenha informações identificadoras. SMS, MMS, notificações push, e-mails, chamadas telefônicas, WhatsApp, entre outros, são os principais canais utilizados pelas marcas para impactar os consumidores. É comum recebermos dezenas de ligações e mensagens de texto indesejadas por mês.

Diante desse cenário, como podemos verdadeiramente compreender um consumidor, sabendo quando, como, por que e o que recomendar a ele?

Nosso foco é entender o consumidor de forma individualizada, criando um sistema de recomendação eficaz. Através de uma análise de dados aprofundada, fornecemos insights valiosos para as empresas parceiras da Plusoft.

Aqui vão algumas estruturas fundamentais do nosso sistema:
Aprimorar algoritmos avançados para analisar grandes conjuntos de dados e identificar padrões de comportamento individual de maneira precisa e eficaz.

Garantir a precisão das recomendações, considerando não apenas os interesses expressos pelos usuários, mas também seus históricos de atividades e contexto atual, para oferecer sugestões relevantes e oportunas.

Implementar medidas robustas para proteger a privacidade e segurança dos dados dos usuários em todas as fases de coleta, processamento e análise, seguindo rigorosamente os padrões da Lei Geral da Proteção de Dados (LGPD).

Promover a conscientização das empresas sobre a importância estratégica de adotar estratégias de marketing personalizadas e centradas no usuário. Isso implica em abandonar o modelo tradicional de publicidade em massa e priorizar a criação de experiências relevantes e significativas para os consumidores, visando estabelecer conexões autênticas e duradouras com o público-alvo.

#### Fonte: 50 Estatísticas de Marketing Digital para 2024 (leadster.com.br)
---

## Pitch

[![Assista ao Pitch](https://i.ibb.co/DVRpqxq/taqui-imagem-tela-video-2.png)](https://www.youtube.com/playlist?list=PLnsC4Y30EcL7rDCMiPKU8FRtReYc_HDMP)

Assista ao vídeo do pitch para entender a proposta e a visão geral do projeto.

---

## Objetivo da Solução

Este projeto foi desenvolvido com os seguintes objetivos:

### Solução & Tecnologia
O sistema TAQUI oferece uma solução essencial para empresas que buscam se destacar e prosperar no mercado competitivo de hoje. Ao investir em nossa tecnologia de recomendação inteligente, você pode aprimorar suas estratégias de marketing de forma significativa.

### Alto impacto
Com o TAQUI, você maximiza a eficiência de suas campanhas, garantindo mensagens altamente relevantes para seu público-alvo. Isso aumenta as chances de conversão e fortalece o relacionamento com os clientes, gerando impacto com qualidade.

### Análise de dados
Além disso, ao aproveitar os dados fornecidos pelo sistema, você toma decisões orientadas por dados, baseadas em insights valiosos sobre tendências e comportamentos do consumidor. Isso resulta em uma melhor experiência do cliente e impulsiona o crescimento e a competitividade.

### Competitividade
Ao adotar o sistema TAQUI, você garante uma vantagem competitiva significativa, preparando-se para os desafios do mercado e alcançando sucesso a longo prazo.

---

## Entregas

Aqui você pode listar as entregas principais realizadas ao longo do projeto, descrevendo o progresso e resultados atingidos.

### Status de Entregas por Disciplina

| **Nome da Disciplina**                                       | **Data**       | **Status**        | **✔️** |
| ------------------------------------------------------------ | -------------- | ----------------- | ------ |
| Advanced Business Development with .NET                       | 16/09/2024     | Concluído         | ✅     |
| Compliance, Quality Assurance e Tests                        | 16/09/2024     | Em andamento      | 🔄     |
| DevOps Tools e Cloud Computing                               | 16/09/2024      | Não iniciado      | ❌     |
| Disruptive Architectures - IoT, IOB e Generated AI           | 16/09/2024      | Não iniciado      | ❌     |
| Java Advanced                                               | 16/09/2024      | Em andamento      | 🔄     |
| Mastering Relational and Non-Relational Database             | 16/09/2024      | Concluído         | ✅     |
| Mobile Application Development                               | 16/09/2024      | Em andamento      | 🔄     |

---

## Fotos do Projeto

Aqui estão algumas imagens do protótipo do smartphone desenvolvido:

<p align="center">
  <img src="https://i.ibb.co/31PR25G/215.png" alt="Imagem 1" width="30%" />
  <img src="https://i.ibb.co/zh7Q7DL/205.png" alt="Imagem 2" width="30%" />
  <img src="https://i.ibb.co/L9GZJL2/211.png" alt="Imagem 3" width="30%" />
</p>

---

## Equipe

Apresentação dos integrantes da equipe de desenvolvimento e suas responsabilidades no projeto:

- 2TDSPM Gabriel Sampaio RM 552342 - Banco de dados / C#
- 2TDSPM Gabriel Neves RM 552244 - React Native (Front End)
- 2TDSPM Livia Freitas RM 99892 - API Java
- 2TDSAV Rafael Mendonça RM 552422 - IA
- 2TDSPM Renato Romeu RM 551325 - DevOps, QA, UX, Business
  
---

## Links e Documentos Complementares

Aqui estão alguns links e documentos complementares para quem deseja explorar mais o projeto:

- [Link 1](https://www.figma.com/proto/GbHko9nmws9NPugbske524/TAQUI?node-id=75-2690&node-type=canvas&t=dseKhQZ0fE2nCp5Y-1&scaling=scale-down&content-scaling=fixed&page-id=62%3A2196&starting-point-node-id=75%3A2690) - Protótipo Figma
- [Link 2](https://drive.google.com/file/d/1174rHO_FRglp7t4-tU1j1UCGLTgB9j19/view?usp=sharing) - Documentação
- [Link 2](https://www.youtube.com/playlist?list=PLnsC4Y30EcL7rDCMiPKU8FRtReYc_HDMP) - Youtube

---

## Orientações de Uso

Aqui estão as orientações para uso correto do projeto:

1. Clone do repositório oficial:
   ```bash
   git clone https://github.com/RenatoRussano/TAQUISPRINT03.git

Orientações gerais do produto final serão lançadas em breve.
