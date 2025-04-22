create database instituto_criativo;
use instituto_criativo;

CREATE TABLE users(
	id int auto_increment primary key,
    name varchar(255) not null,
    tipo varchar(255) not null,
    telefone numeric(11) not null,
    cpf varchar(11) not null,
   	email varchar(255) not null unique,
	password varchar(255) not null
);

create table eventos(
	id int auto_increment primary key,
    nome varchar(255) not null,
    tipo varchar(255) not null,
    descricao varchar(255) not null,
    dataI date not null,
    horaI time not null,
    horaF time not null,
    cep numeric(8) not null,
    logradouro varchar(255) not null,
    numero varchar(255) not null,
    bairro varchar(255) not null,
    cidade varchar(255) not null,
    capacidade numeric(10) not null,
    responsavel varchar(255) not null
);

create table images(
	id int auto_increment primary key,
    filename varchar(255) not null,
    filepath varchar(255) not null,
    uploaded_at timestamp default current_timestamp
);

ALTER TABLE eventos 
ADD COLUMN imagemId INT NULL,
ADD CONSTRAINT fk_imagem FOREIGN KEY (imagemId) REFERENCES images(id);

select * from users;
select * from images;
select * from eventos;


drop table eventos;