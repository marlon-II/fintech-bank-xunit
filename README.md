# fintech-bank-xunit# FintechBank - xUnit

Projeto da disciplina de Garantia da Qualidade de Software. A ideia é simular duas regras de negócio de um banco (conta corrente e empréstimo) e testar tudo com testes unitários parametrizados usando xUnit.

## Requisitos

- .NET 10 SDK
- Git

Para ver se o .NET está instalado:

```bash
dotnet --version
```

## Estrutura

```text
FintechBank/
├── FintechBank.sln
├── FintechBank.App/
│   ├── ContaCorrenteService.cs
│   └── EmprestimoService.cs
├── FintechBank.Tests/
│   ├── ContaCorrenteServiceTests.cs
│   └── EmprestimoServiceTests.cs
├── .gitignore
├── LICENSE
└── README.md
```

## Regras de negócio

### ContaCorrenteService

**CalcularTaxaManutencao(saldo, clienteEspecial)**

- Saldo maior ou igual a R$ 5.000,00 ou cliente especial: isento (R$ 0,00)
- Saldo de R$ 1.000,00 até R$ 4.999,99: R$ 12,50
- Saldo abaixo de R$ 1.000,00: R$ 25,00

**PodeRealizarSaque(saldo, limiteChequeEspecial, valorSaque)**

Retorna `true` somente se o valor do saque for menor ou igual ao saldo somado ao limite do cheque especial.

### EmprestimoService

**CalcularValorParcela(valorTotal, parcelas, scoreCredito)**

Aplica os juros de acordo com o score e divide pelo número de parcelas:

- Score 700 ou mais: 5% de juros
- Score de 500 a 699: 12% de juros
- Score abaixo de 500: 20% de juros

Por exemplo, R$ 10.000,00 em 10 parcelas com score 800 vira R$ 10.500,00 no total, ou seja, parcelas de R$ 1.050,00. Se o número de parcelas for zero ou negativo, o método retorna 0.

**AprovarEmprestimo(rendaMensal, valorParcela)**

O empréstimo é aprovado se a parcela for no máximo 30% da renda mensal.

## Como clonar e compilar

```bash
git clone https://github.com/<seu-usuario>/fintech-bank-xunit.git
cd fintech-bank-xunit
dotnet build
```

## Como rodar os testes

Na pasta onde está o arquivo `.sln`:

```bash
dotnet test
```

Todos os testes das duas classes devem passar.

## Sobre os testes

Os testes usam `[Theory]` e `[InlineData]` do xUnit. Com o `[Theory]` o mesmo método de teste roda várias vezes, e cada `[InlineData]` é um conjunto de valores (entradas e resultado esperado). Assim dá pra testar vários cenários sem repetir código.

**ContaCorrenteServiceTests**

- `CalcularTaxaManutencao`: saldo alto, cliente especial, saldo intermediário e saldo baixo
- `PodeRealizarSaque`: saque dentro do limite e saque acima do limite

**EmprestimoServiceTests**

- `CalcularValorParcela`: score alto, médio e baixo
- `AprovarEmprestimo`: parcela igual a 30% da renda (aprova) e acima de 30% (recusa)

## Licença

MIT. Veja o arquivo [LICENSE](LICENSE).

## Alunos

Caio Cesar Paiva de Almeida 

Caio Ferreira Menezes 

Marlon Andrade Bartoli 
