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

@MenuItemAboutClick
Scenario: Verifica se ao clicar no item About do menu ocorre o redirecionamento para a secao About
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
And E o Menu for acionado
And E a opcao About for clicada
Then Entao a pagina da secao sobre deve ser carregada

@MenuItemLogoutClick
Scenario: Verifica se ao clicar no item Logout do menu ocorre o redirecionamento para a pagina de login
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
And E o Menu for acionado
And E a opcao Logout for clicada
Then Entao deve retornar para a pagina de login