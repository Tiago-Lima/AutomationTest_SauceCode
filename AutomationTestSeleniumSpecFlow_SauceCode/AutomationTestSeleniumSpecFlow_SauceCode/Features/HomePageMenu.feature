﻿Feature: Menu dropdown da Home Page
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

@MenuItemAllItensClick
Scenario: Verifica se ao clicar no item All itens do menu ocorre o redirecionamento para a pagina home e exibe os itens a venda
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
And E o Menu for acionado
And E a opcao All itens for clicada
Then Entao deve mostrar a home page com todos os itens

@MenuResetItemClick
Scenario: Verifica se ao clicar no item Reset App State do menu ocorre o redirecionamento para a pagina home e esvazia os itens do carrinho
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
And E o Menu for acionado
And E a opcao Reset App State for clicada
Then Entao deve mostrar a home page e esvaziar o carrinho

@CloseMenuButtonClick
Scenario: Ao clicar no botão de fechar o menu, os itens do menu devem ser ocultados e somente o botão do menu deve aparecer na página principal.
Given Dado que o navegador seja aberto no site
And E o usuario esteja logado
When Quando A HomePage estiver carregada
And E o Menu for acionado
And E o botao de fechar o menu for clicado
Then Entao os itens devem ser ocultados e o botao de menu deve ser exibido habilitado na pagina principal 