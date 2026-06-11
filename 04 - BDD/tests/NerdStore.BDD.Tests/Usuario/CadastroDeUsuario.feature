Feature: Usuário - Cadastro
	Como um visitante da loja
	Eu desejo me cadastrar como usuário
	Paraque eu possa realizar compras na loja

Scenario: Cadastro de usuário com sucesso
Given Que o visitante está acessando o site da loja
When Ele clicar em registrar
And Preencher os dados do formulario
	| dados					|
	| E-mail				|
	| Senha					|
	| Confirmação de Senha	|
And Clincar no botão registrar
Then Ele será redirecionado para a vitrine
And Uma saudação com seu e-mail será exibida no menu superior

Scenario: Cadastro com senha sem maiusculas
Given Que o visitante está acessando o site da loja
When Ele clicar em registrar
And Preencher os dados do formulario com uma senha sem maiusculas
	| dados					|
	| E-mail				|
	| Senha					|
	| Confirmação de Senha	|
And Clincar no botão registrar
Then Ele receberá uma mensagem de erro que a senha precisa conter uma letra maiuscula

Scenario: Cadastro com senha sem caractere especial
Given Que o visitante está acessando o site da loja
When Ele clicar em registrar
And Preencher os dados do formulario com uma senha sem caractere especial
	| dados                |
	| E-mail               |
	| Senha                |
	| Confirmação de Senha |
And Clincar no botão registrar
Then Ele receberá uma mensagem de erro que a senha precisa conter um caractere especial