# Contact List

Desenvolvimento de uma API de uma lista de contatos usando C# Web com ASP.NET e um banco de dados SQL Server

---------------------------------------

## Documentação da API


![GET](https://placehold.co/70x30/3d76bf/white/?text=GET&font=Montserrat) `/contact`

Retorna a lista de todos os contatos

***Request***
    http://localhost:port/contact

***Response***  `200`

    [
	    {
    		"contactId": 1,
		    "name": "Maria Alves",
		    "email": "maria.alves@betrybe.com",
		    "phoneNumber": "11 999999999"
	    } ...
    ]

---------------------------------------    

![POST](https://placehold.co/70x30/3dbf94/white/?text=POST&font=Montserrat) `/contact`

Insere um novo contato

***Request***
    http://localhost:port/contact

	{
		"Name":"Diogo Silva",
	    "Email":"diogo.silva@betrybe.com",
	    "PhoneNumber":"11 999999959"
	}

***Response***  `201`

	{
		"contactId": 2,
		"name": "Diogo Silva",
		"email": "diogo.silva@betrybe.com",
		"phoneNumber": "11 999999959"
	}
 
--------------------------------------- 

![PUT](https://placehold.co/70x30/7e3dbf/white/?text=PUT&font=Montserrat) `/contact`

Edita as informações de um contato

***Request***
    http://localhost:port/contact

	{
		"contactId": 2,
		"name": "Diogo Silva",
		"email": "diogo.silva@betrybe.com",
		"phoneNumber": "11 999999959"
	}

***Response***  `200`

	{
		"contactId": 2,
		"name": "Diogo Silva",
		"email": "diogo.silva@betrybe.com",
		"phoneNumber": "11 999999959"
	}
 
--------------------------------------- 

![DELETE](https://placehold.co/70x30/bf3d3d/white/?text=DELETE&font=Montserrat) `/contact/{id}`

Deleta um contato

***Request***
    http://localhost:port/contact/2

***Response***  `204`
 
--------------------------------------- 

