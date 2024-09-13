 Gabriel Neves Gomes- rm552244- Front-end
 Gabriel Sampaio Gianini- rm552342- DBA
 Livia Freitas Ferreira- rm99892- Back-end
 Rafael Henrique De Mendonça- rm552422- IA
 Renato Sanches Russano Romeu- rm551325- QA

//Explicação sobre a arquitetura
Estamos utilizando a arquitetura de microservices para criar um sistema mais modular e escalável, onde cada serviço é responsável por uma funcionalidade específica e opera de forma independente. Isso nos permite escalar e atualizar cada componente de forma isolada, garantindo maior flexibilidade e eficiência no desenvolvimento e na manutenção. Com a divisão em microserviços, conseguimos melhorar a resiliência do sistema, pois a falha de um serviço não compromete o funcionamento geral, e também facilitar a adoção de novas tecnologias e práticas conforme as necessidades evoluem. Tendo em vista o escopo do projeto, o TAQUI almeja expandir para mercados além do módulo de celulares o que a arquitetura monolítica não permitiria devido a complexidade e magnitude do código que expandirá exponencialmente.

 //Design patterns utilizados
 Error Handling, DTOs (Data transfer Object), Service Layer e Repository Pattern


 //Instruções para rodar a API
 Na linha 10 do arquivo appsettings.json trocar o User ID para seu RM, e o Password para sua senha do banco Oracle.
