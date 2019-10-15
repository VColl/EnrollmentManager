# Gerenciador de Matrícula

## Conteúdo

- [Gerenciador de Matrícula](#gerenciador-de-matr%c3%adcula)
  - [Conteúdo](#conte%c3%bado)
  - [Requerimentos](#requerimentos)
  - [Descrição dos Projetos](#descri%c3%a7%c3%a3o-dos-projetos)
  - [Manual do Usuário](#manual-do-usu%c3%a1rio)

## Requerimentos

- .Net Framework 4.7.2
    
- .Net Core 2.2

## Descrição dos Projetos

| Nome | Descrição |
|------|-----------|
| **EnrollmentManager.Business (.Net Standard 2.0)** | Contém a lógica de negócio da aplicação, i.e., as classes de cálculo, como o conversor para hexadecimal e o calculador de dígito de verificação. |
| **EnrollmentManager.InterfaceBusiness (.Net Standard 2.0)** | Contém a lógica da interface da aplicação. Este é o projeto responsável por controlar o que ocorre durante a interação do usuário com a aplicação. |
| **EnrollmentManager.WinFormsApp (.Net Framework 4.7.2)** | A aplicação desktop para Windows. Este projeto contém apenas a camada de interface de usuário, regida pelo projeto EnrollmentManager.InterfaceBusiness. |
| **EnrollmentManager.Business.Tests (.Net Core 2.2)** | Contém os testes referêntes ao projeto EnrollmentManager.Business. |
| **EnrollmentManager.InterfaceBusiness.Tests (.Net Core 2.2)** | Contém os testes referêntes ao projeto EnrollmentManager.InterfaceBusiness. |

## Manual do Usuário

### Geração de Matrículas com Dígito Verificador

  O arquivo de entrada deve conter as matrículas sem o DV separadas por linha. Para gerar o arquivo de saída, das matrículas com DV, basta inserir os endereços dos arquivos de entrada e saída nos locais indicados e clicar em "Gerar".

### Verificação de Matrículas

  O arquivo de entrada deve conter as matrículas, com DV, a serem verificadas separadas por linha. Para gerar o arquivo de saída, com as matrículas verificadas, basta inserir os endereços dos arquivos de entrada e saída nos locais indicados e clicar em "Verificar".

### Configurações Adicionais

  O arquivo de configuração do sistema, App.config (que é compilado para EnrollmentManager.WinFormsApp.exe.config), possui algumas configurações adicionais na tag appSettings.

``` config
    <appSettings>
        <add key="ValidIndicator" value="Verdadeiro" />
        <add key="InvalidIndicator" value="Falso" />
        <add key="InvalidLineFormatIndicator" value="Formato Inválido" />
        <add key="IgnoreInvalidLinesIndicator" value="false" />
    </appSettings>
```
- **ValidIndicator:** Indicador exibido ao lado de uma matrícula válida no arquivo de saída da verificação.

- **InvalidIndicator:** Indicador exibido ao lado de uma matrícula inválida no arquivo de saída da verificação.

- **InvalidLineFormatIndicator:** Indicador exibido no arquivo de saída da geração de matrículas com DV, ao lado de uma matrícula inválida. Isto ocorre quando a matrícula presente na linha correspondente no arquivo de entrada não possui o formato correto de 4 caracteres numéricos.

- **IgnoreInvalidLinesIndicator:** Quando true, indica que, durante a geração de matrículas com DV, as linhas com formato incorreto serão ignoradas.
