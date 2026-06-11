Feature: Usuário - Login
	Como um usuario
	Eu desejo realizar o login
	Para que eu possa acessar as demais funcionalidades


Scenario: Realizar login com sucesso
	Given Que o visitante está acessando o site da loja
	When Ele clicar em login
	And Preencher os dados do formulário de login
		| dados  |
		| E-mail |
		| Senha  |
	And Clicar no botão login
	Then Ele será redirecionado para a vitrine
	And Uma saudação com seu e-mail será exibida no menu superior