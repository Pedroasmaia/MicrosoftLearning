# Descrever conceitos de segurança e conformidade

🌐[Documentação](https://learn.microsoft.com/pt-br/training/modules/describe-security-concepts-methodologies/)

- [Descrever conceitos de segurança e conformidade](#descrever-conceitos-de-segurança-e-conformidade)
  - [Modelo de responsabilidade compartilhada](#modelo-de-responsabilidade-compartilhada)
  - [Defesa em profundidade](#defesa-em-profundidade)
  - [CIA : Confiabilidade, Integridade e Disponibilidade](#cia--confiabilidade-integridade-e-disponibilidade)
  - [Confiança Zero](#confiança-zero)
    - [Princípios](#princípios)
    - [Seis pilares fundamentais](#seis-pilares-fundamentais)
  - [Criptografia e Hash](#criptografia-e-hash)
    - [Criptografia para Dados em Repouso](#criptografia-para-dados-em-repouso)
    - [Criptografia TLS](#criptografia-tls)
    - [Hash](#hash)
  - [Conceitos de conformidade:](#conceitos-de-conformidade)

## Modelo de responsabilidade compartilhada

- Em nuvens publicas a responsabilidade pela segurança e compartilhada entre o cliente e o provedor.
- As responsabilidade variam dependendo de onde a carga de trabalho está hospedada:
  - PaaS (Plataform as a Service)
  - SaaS (Software as a Service)
  - IaaS (Infrastructure as a Service)
  - Datacenter Local

Diagrama que mostra as responsabilidades de acordo com o modelo de serviço contratado:

<center>
<figure>
<img src="https://github.com/Pedroasmaia/microsoftlearning/blob/b385f1d366c82f698e752e065972c76edd1e97e3/Descrever conceitos de segurança e conformidade/3-shared-responsibility-model.jpg">
<figcaption>Imagem retirada da documentação, traduzida pelo autor do resumo.</figcaption>
</figure>
</center>

- Responsabilidades:
  - **Datacenters Locais:** O Cliente é totalmente responsável pela segurança.
  - **IaaS:** É o que mais requer gerenciamento pela parte do cliente, que é responsável por _tudo_ menos a segurança física.
  - **PaaS:** O Foco do PaaS é disponibilizar serviços para criação, teste e implantação rápidas, então o provedor fica responsável pelo Hardware e Sistema Operacional, enquanto o cliente se preocupa apenas com a _segurança do aplicativo desenvolvido_.
  - **SaaS:** É o Software geralmente licenciado fornecido pelo provedor, logo ele cuida de tudo e o cliente se preocupa apenas com os _Dados_ inseridos, _Contas de Acesso_ e _Dispositivos_.

Em todos os tipos de implantação o **Cliente** é responsável por proteger os **dados**, **identidades** e **dispositivos**.

## Defesa em profundidade

Uma estrategia de Defesa em profundidade é utilizar _camadas_ para impedir o ataque de avançar, contando que caso uma camada falhe, outra impedira.

Essas camadas podem incluir:

- **Segurança Física:** Um exemplo é impedir que pessoas não autorizadas acessem o datacenter.
- **Identidade e Acesso:** Não basta ter a senha para o acesso, a conta realmente é de quem esta logando? Multi Fator e condições de acesso são exemplos dessa camada.
- **Segurança por Perímetro:** Delimitar nossa rede e a internet, alguns exemplos são: Firewall de borda, WAF e Proxy.
- **Segurança de Rede:** Segmentação de rede, e controle de acessos a rede, como impedir que ambientes diferentes se comuniquem.
- **Computação:** Proteção de acessos nas máquinas, com o foco sendo o sistema operacional. Lidar com o Bloqueio de portas é um exemplo.
- **Aplicação:** Saber que o aplicativo esta seguro e livre de vulnerabilidades.
- **Dados:** Gerenciar acessos e controle de informações de clientes e seus negócios.

<center>
<figure>
<img src="https://github.com/Pedroasmaia/microsoftlearning/blob/23835fd0d025302a07c1d1216e65b7a242a7275c/Descrever conceitos de segurança e conformidade/2-defense-depth.png">
<figcaption>Imagem retirada da documentação.</figcaption>
</figure>
</center>

## CIA : Confiabilidade, Integridade e Disponibilidade

<center>
<figure>
<img src="https://github.com/Pedroasmaia/microsoftlearning/blob/23835fd0d025302a07c1d1216e65b7a242a7275c/Descrever conceitos de segurança e conformidade/4-confidentiality-integrity-availability.png">
<figcaption>Imagem retirada da documentação.</figcaption>
</figure>
</center>

- **Confiabilidade:** É a necessidade de manter informações em sigilo, e é a parte mais visível de toda a segurança, todo mundo percebe a necessidade de se manter senhas, dados e outros segredos bem guardados.
- **Integridade:** A confiança de que os dados armazenados não foram alterados. Quando armazenamos dados em um banco ou enviamos um email, precisamos que essa informação esteja disponível exatamente igual quando escrevemos. Quando criptografamos algo, temos que obter a mesma mensagem ao descriptografar.
- **Disponibilidade:** É garantir que os dados vão estar disponíveis quando forem necessários e de forma entendível. Suponhamos que eu fiz um deposito no valor de R$25,00 essa informação é salva em forma de um _ID_, quando eu realizar a consulta do meu saldo, preciso que essa informação esteja demonstrada em Reais, e não com caracteres aleatórios.

Os atacantes(Crackers) tem o objetivo de ferir um ou mais destes pontos, para causar algum dano a vitima.

## Confiança Zero

<center>

_Não confie em ninguém e verifique tudo_

</center>

Digamos que essa frase é o norte dessa politica de segurança, que trata tudo que esta em contato com a internet como não confiável. Na pratica não podemos mais confiar que apenas uma senha valide o usuário, portanto é seguro que ativemos o MFA (Multi Fator de Autenticação). E ao invés de liberar todo o sistema para o usuario, liberamos acesso apenas aos recursos e dados que ele realmente precisa.

### Princípios

- **Verificação Explicita:** Sempre autentique com a maioria de dados possíveis. Exemplo: Identidade do Usuário, Dispositivo, Local, Horário de Trabalho.
- **Privilegio Mínimo:** Analise o melhor cenário de liberações se baseando em risco, proteção de dados e produtividade.
- **Pressuposição de Violação:** Use a criptografia para proteger dados e use a análise para obter visibilidade, detectar ameaças e melhorar sua segurança.

### Seis pilares fundamentais

- **Identidades:** É tudo que realiza uma autenticação, que quando realizada deve ser forte e seguir o principio de privilegio mínimo.
- **Dispositivos:** Grande movimentação de dados, devem estar em conformidade e íntegros.
- **Aplicativos:** Tudo que trata os dados, Incluindo Licenciamento, Permissionamento. As vezes é chamado TI de Sombra.
- **Dados:** Quase toda os esforços de segurança são para a proteção desse pilar, os dados devem estar categorizados, classificados e criptografados de acordo com seus atributos.
- **Infraestrutura:** Representa um vetor de ameaça. Gerenciar permissões e realizar monitoramento para identificar ataques e ameaças.
- **Redes:** devem ser segmentadas, incluindo microsegmentação, criptografia de ponta a ponta e monitoramento.

<center>
<figure>
<img src="https://github.com/Pedroasmaia/microsoftlearning/blob/23835fd0d025302a07c1d1216e65b7a242a7275c/Descrever conceitos de segurança e conformidade/2-zero-trust-pillars-v2.png">
<figcaption>Imagem retirada da documentação.</figcaption>
</figure>
</center>

## Criptografia e Hash

**Criptografia** é uma forma de tornar dados confidenciais ou valiosos ilegíveis para pessoas não autorizadas. E para ter acesso a esses dados criptografados precisamos de descriptografar usando uma **Chave Secreta**. Existem duas formas do processo de criptografia acontecer:

- **Criptografia simétrica:** Utiliza a mesma chave(padrão) para criptografar e descriptografar os dados.
- **Criptografia assimétrica:** Usa um par de chaves, publicas e privadas. Você precisa das duas chaves para poder descriptografar o que foi enviado.
- Esse tipo é usado no protocolo HTTPS e soluções de assinatura eletrônica.

<center>
<figure>
<img scr="https://learn.microsoft.com/pt-br/training/wwl-sci/describe-security-concepts-methodologies/media/6-encryption.png"></img>
<figcaption>Imagem retirada da documentação.</figcaption>
</figure>
</center>

### Criptografia para Dados em Repouso

Dados inativos são armazenados em dispositivos físicos, indiferente de como eles estão armazenados, é importante criptografar para garantir que eles não sejam lidos sem as chaves necessarias para descriptografá-los.

### Criptografia TLS

É criptografar os dados que se movem entre camadas da rede, como pela internet ou rede privada. HTTPs é um exemplo, ele nos protege de observadores externos em nossa rede.

### Hash

Hash é um identificador exclusivo de um dado. O Algoritimo converto o texto em um valor único:

```sha1
senha = deba0172511d5701d964202f4e5de698d5e07c67
```

Normalmente é usado para armazenar senhas, e diferente da criptografia, não é descriptografado. Os Crackers usam *Ataques de dicionario* para descobrir o hash e assim por consequencia, a senha do usuário. Por isso normalmente as senhas contem um "sal" que é a adição de um valor aleatório de comprimento fixo.

## Conceitos de conformidade:

- **Residencias de Dados:** São os locais físicos onde os dados podem ser armazenado e como podem ser tratados e/ou transferidos.
- **Soberania de Dados:** Os dados estão sujeitos a às leis e regulamentos de país/região em que são tratados, mantidos e/ou coletados. Podendo ser aplicadas diferentes leis em se coletado em um e tratado em outro.
- **Privacidade de Dados:** Fornecer Aviso e ser transparente sobre a coleta, tratamento e compartilhamento, agindo sempre de acordo com as leis vigentes.



