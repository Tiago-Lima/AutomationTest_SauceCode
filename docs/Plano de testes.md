# Plano de Testes

## Plano de Testes - Automação de Testes com Selenium e SpecFlow

### Objetivo

O objetivo deste plano de teste é garantir que as funcionalidades de login e menu do sistema sejam testadas de forma automatizada usando o framework Selenium em conjunto com SpecFlow, visando validar os requisitos definidos.

### Escopo

O escopo deste plano de teste abrange os casos de teste automatizados de **interface WEB** para as funcionalidades de login e menu, utilizando o framework Selenium e a linguagem C# com o uso do SpecFlow para a escrita dos cenários em linguagem natural.

### Ambiente de Teste

O ambiente de teste consistirá em:

- Sistema operacional: **Windows 10/11**
- Navegadores suportados: **Google Chrome *(Versão 114.0.5735.91)***
- Ferramentas:
    - **Visual Studio 2019 ou posterior**
    - **Selenium WebDriver *(Versão 85.0.0)***
    - **SpecFlow *(Versão 3.9.74)***

### Casos de Teste

1. Verificação dos elementos na página de login:
    - Verificar se a caixa de texto "username" está vazia por padrão.
    - Verificar se a caixa de texto "password" está vazia por padrão.
    - Verificar se o botão de login está habilitado para interação.
2. Validação de login com credenciais corretas:
    - Informar um usuário válido e uma senha válida.
    - Clicar no botão de login.
    - Verificar se a página "inventory" é exibida corretamente.
3. Validação de login com credenciais incorretas:
    - Informar um usuário inválido e/ou uma senha inválida.
    - Clicar no botão de login.
    - Verificar se a mensagem de erro "Username and password do not match" é exibida corretamente.
4. Validação de login com campos vazios:
    - Deixar os campos de usuário e senha vazios.
    - Clicar no botão de login.
    - Verificar se a mensagem de erro "Username is required" é exibida corretamente.
5. Verificação dos elementos na página "inventory":
    - Verificar se o botão de menu está habilitado para interação.
6. Validação das opções do menu:
    - Clicar no botão de menu.
    - Verificar se as seguintes opções são exibidas: "All Items", "About", "Logout", "Reset App State" e o botão para fechar o menu.
7. Ação de clicar em "All Items" no menu:
    - Clicar em "All Items" no menu.
    - Verificar se todos os itens da página "inventory" são exibidos corretamente.
8. Ação de clicar em "About" no menu:
    - Clicar em "About" no menu.
    - Verificar se é redirecionado corretamente para a página "[https://saucelabs.com/](https://saucelabs.com/)".
9. Ação de clicar em "Logout" no menu:
    - Clicar em "Logout" no menu.
    - Verificar se é redirecionado corretamente para a página de login.
10. Ação de clicar em "Reset App State" no menu:
    - Clicar em "Reset App State" no menu.
    - Verificar se o carrinho de compras é esvaziado corretamente.
    - Verificar se é redirecionado corretamente para a página "inventory".
11. Ação de clicar no botão de fechar o menu:
    - Clicar no botão de fechar o menu.
    - Verificar se os itens do menu são ocultados corretamente, permanecendo somente o botão do menu visível na página principal.

### Plano de Execução

1. Preparação:
    - Configurar o ambiente de teste com todas as ferramentas e dependências necessárias.
    - Configurar a estrutura do projeto de automação com Selenium e SpecFlow.
    - Definir os dados de teste necessários, como usuários válidos e inválidos.

ir os dados de teste necessários, como usuários válidos e inválidos.

1. Implementação dos Casos de Teste:
    - Escrever os cenários de teste utilizando a sintaxe do SpecFlow.
    - Implementar as etapas dos testes em código C# usando o Selenium WebDriver.
2. Execução dos Testes:
    - Executar os casos de teste automatizados no ambiente de teste configurado.
    - Registrar os resultados dos testes, incluindo falhas e capturas de tela, se necessário.
3. Análise dos Resultados:
    - Analisar os resultados dos testes automatizados.
    - Identificar e documentar os problemas encontrados.
4. Correção de Problemas:
    - Reproduzir manualmente os problemas identificados.
    - Registrar e priorizar os problemas para correção.
5. Reteste:
    - Realizar o reteste dos casos de teste automatizados.
    - Verificar se os problemas identificados foram corrigidos com sucesso.