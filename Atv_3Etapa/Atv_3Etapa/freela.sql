create database freela;

use freela;

create table freelancer(
id_freelancer int not null primary key auto_increment,
nome varchar(80) not null,
email varchar(80) not null,
telefone char(14) not null
);

create table contratante(
id_contratante int not null primary key auto_increment,
nome varchar(80) not null,
email varchar(80) not null,
telefone char(14) NOT NULL
);

select * from freelancer;
select * from contratante;

create table servico(
id_servico int not null primary key auto_increment,
titulo varchar(50) not null,
descricao varchar(250) not null,
valor double not null
);

select * from servico;