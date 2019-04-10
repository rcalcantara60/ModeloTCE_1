#language: pt-br

Funcionalidade: Gerenciamento dos paises
				Eu, enquanto usuário quero gerenciar o cadastro de 
				paises no sistema

Cenário: Inserção de novo pais
Dado que o nome do pais seja 'CHILE'
E a REGION_ID sejá 3
Quando eu salvar
Entao a validação deve ser verdadeira
