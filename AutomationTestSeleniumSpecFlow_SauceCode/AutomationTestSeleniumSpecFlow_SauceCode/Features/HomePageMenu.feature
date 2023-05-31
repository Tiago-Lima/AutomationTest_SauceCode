Feature: Menu dropdown da Home Page
Verifica se o menu está funcionando conforme o esperado

@MenuButtonDisplayedAndEnabled
Scenario: Verifica se o batao de menu e exibido e esta habilitado
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
Then Entao o botao de menu deve ser exibido habilitado

@MenuItensDisplayedAndEnabled
Scenario: Verifica se os itens do menu sao exibidos habilitados
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
And E o Menu for acionado
Then Entao os itens devem aparecer habilitados