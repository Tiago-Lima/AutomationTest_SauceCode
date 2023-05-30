Feature: Pagina de login
	Verifica se a página de login está funcionando conforme o esperado

@loginPageDisplayed
Scenario: Verifica se a pagina de login esta carregando
	Given Dado que o navegador seja aberto no site
	Then Entao a pagina de login deve ser exibida

@UsernameFieldDisplayedAndEmpty
Scenario: Verifica se o campo username e exibido e esta vazio 
	Given Dado que o navegador seja aberto no site
	Then Entao o campo username deve ser exibido vazio

@PasswordFieldDisplayedAndEmpty
Scenario: Verifica se o campo password e exibido e esta vazio
	Given Dado que o navegador seja aberto no site
	Then Entao o campo password deve ser exibido vazio

@LoginButtonDisplayedAndEnabled
Scenario: Verifica se o botao de login e exibido e esta habilitado
	Given Dado que o navegador seja aberto no site
	Then Entao o botao de login deve ser exibido e estar habilitado

@ErrorLoginAndPasswordIncorrect
Scenario: Verifica se a mensagem de erro para login e password invalido aparece corretamente
	Given Dado que o navegador seja aberto no site
	And E o campo login e password sao invalidos
	When Quando o botao de login for pressionado
	Then Entao deve ser exibido a mensagem de erro correta
