# 💳 Sistema Bancário Console

Este é um projeto simples de um sistema bancário criado em C# usando .NET Framework, com aplicação de **5 padrões de projeto (Design Patterns). O objetivo é demonstrar a implementação prática de conceitos fundamentais de arquitetura de software.

---

## 🚀 Funcionalidades Principais

- Criar contas bancárias (Corrente ou Poupança).
- Realizar depósitos, saques e transferências.
- Calcular taxas sobre operações financeiras.
- Notificar alterações de saldo.
- Gerenciar contas bancárias em uma estrutura centralizada.

## ⚙️ Execução do Sistema

- dotnet run.
- Após isso, é só ir escolher de acordo com o que deseja. 
- Criar conta (Corrente ou Poupança) ... É só seguir conforme os sistemas vai solicitando.
- Realizar depósitos, saques e transferências. Após essas operações, já aparecerá o saldo da conta atualizado, e terá a opção também para SAIR, opção que encerra o programa.

---

## 🎨 Padrões de Projeto Implementados

### 1. Singleton 🔒

- O que faz:  
  Garante que apenas uma instância da classe Banco seja criada durante o ciclo de vida do programa.

- Aplicação no projeto:  
  A classe Banco centraliza o gerenciamento de todas as contas bancárias criadas, permitindo acesso unificado.

---

### 2. Factory Method 🏭

- O que faz:  
  Encapsula a criação de objetos, permitindo que subclasses decidam qual tipo específico de objeto criar.

- Aplicação no projeto:  
  As classes ContaCorrenteFactory e ContaPoupancaFactory permitem criar diferentes tipos de contas bancárias, simplificando a lógica de inicialização.

---

### 3. Strategy 🧩

- O que faz:  
  Define uma família de algoritmos (estratégias) intercambiáveis em tempo de execução.

- Aplicação no projeto:  
  Classes como TaxaFixa e TaxaPorcentagem calculam diferentes tipos de taxas de forma flexível e extensível.

---

### 4. Observer 👀

- O que faz:  
  Notifica automaticamente objetos inscritos sobre mudanças no estado de outro objeto.

- Aplicação no projeto:  
  O NotificadorSaldo informa o usuário sobre atualizações de saldo na conta bancária, gerenciado pelo GerenciadorObservadores.

---

### 5. Command 🎮

- O que faz:  
  Encapsula solicitações em objetos, permitindo maior flexibilidade para executar ou armazenar operações.

- Aplicação no projeto:  
  As classes OperacaoDeposito e OperacaoSaque encapsulam as operações bancárias, proporcionando uma execução uniforme e organizada.

  ### Nome dos integrantes 🧑

  - Carlos Eduardo Pereira de Oliveira
  - Daniel Marques de Melos Asiático