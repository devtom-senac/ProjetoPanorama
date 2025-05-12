CREATE TABLE pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
	nome_cliente VARCHAR(150) NOT NULL,
    telefone VARCHAR(11) NULL,
    data_entrega DATETIME NOT NULL,
	preco DECIMAL(10, 2) NOT NULL ,
    pagamento VARCHAR(30) NOT NULL,
    situacao VARCHAR(30) NOT NULL
);

