Feature: Pedido - Adicionar Item ao Carrinho
	Como um usuário
	Eu desejo colocar um item no carrinho
	Para que eu possa comprá-lo posteriormente

Scenario: Adicionar item com sucesso a um novo pedido
	Given Que um produto esteja na vitrine
	And Esteja disponível em estoque
	And O usuario esteja logado
	When O usuário adicionar uma unidadeo ao carrinho
	Then O usuário sera redirecionado ao resumo da compra
	And O valor total do pedido será exatamente o valor do item adicionado

Scenario: Adicionar items acima do limite
	Given Que um produto esteja na vitrine
	And Esteja disponível em estoque
	And O usuario esteja logado
	When O usuário adicionar um item acima da quantidade maxima permitida
	Then REcebera uma mensagem de erro mencionando que foi ultrapassada a quantidade limite


Scenario: Adicionar item já existente no carrinho
	Given Que um produto esteja na vitrine
	And Esteja disponível em estoque
	And O usuario esteja logado
	And O mesmo produto já tenha sido adicionado ao carrinho anteriormente
	When O usuário adicionar uma unidade ao carrinho
	Then O usuario será redirecionado ao resumo da compra
	And A quantidade de itens daquele produto terá sido acrescida emn uma unidade a mais
	And O valor total do pedido será a multiplicação da quantidade de itens pelo valor unitário

Scenario: Adicionar item já existente onde soma ultrapassa limite máximo
	Given O usuario esteja logado
	And Que um produto esteja na vitrine
	And Esteja disponivel no estoque
	And O mesmo produto já tenha sido adicionado ao carrinho anteriormente
	When O usuário adicionar a quantidade máxima permitida ao carrinho
	Then Receberá uma mensagem de erro mencionando que foi ultrapassada a quantidade limite