<span style="font-size: 48px;">:clipboard:</span> 
# Requisitos de teste

### Feature login

1. A página de login deve apresentar os seguintes elementos:
    1. A caixa de texto "username" vazia.
    2. A caixa de texto "password" vazia.
    3. O botão de login habilitado.
    4. Mensagem de erro "Username and password do not match.." deve ser exibida após tentativa de login com usuário e senha incorretos.
    5. Mensagem de erro "Username is required" deve ser exibida após tentativa de login com usuário e senha vazios.
    6. A página "inventory" deve ser aberta após o login com usuário e senha corretos.

### Feature Home Page - Menu

1. A página "inventory" deve apresentar os seguintes elementos:
    1. O botão de menu habilitado.
    2. Clicando no botão de menu, as seguintes opções devem ser exibidas: "All Items", "About", "Logout", "Reset App State" e o botão para fechar o menu.
    3. Clicando em "All Items" no menu, todos os itens da página "inventory" devem ser exibidos.
    4. Clicando em "About" no menu, deve ser redirecionado para a página "[https://saucelabs.com/](https://saucelabs.com/)".
    5. Clicando em "Logout" no menu, deve ser redirecionado para a página de login.
    6. Clicando em "Reset App State" no menu, o carrinho de compras deve ser esvaziado e deve ser redirecionado para a página "inventory".
    7. Ao clicar no botão de fechar o menu, os itens do menu devem ser ocultados e somente o botão do menu deve aparecer na página principal.

