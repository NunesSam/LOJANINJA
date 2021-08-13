# LOJANINJA Teste

Use AVALACAO

Create Table Clientes
(
	Id uniqueidentifier primary key,
	Nome varchar(120) not null,
	Email varchar(20) not null,
	Aldeia varchar(100) not null		
)

ALTER TABLE CLIENTES
ADD CONSTRAINT UNIQUE_CLIENTES_EMAIL
UNIQUE (Email)


Create Table Produtos
(
	Id uniqueidentifier primary key,
	Descricao varchar(100) not null,
	Valor DECIMAL(5,2) not null		
)

Create Table Cadastro
(
	Número INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Data DateTime NOT NULL, 
	ProdutoId INT FOREIGN KEY REFERENCES Produtos(id),
	ClienteId INT FOREIGN KEY REFERENCES Produtos(id),
	Valor DECIMAL(5,2) not null	,
	Desconto DECIMAL(5,2) not null,
	ValorTotal (DECIMAL(5,2) not null	
)

