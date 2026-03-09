create database if not exists VertexSgbd;

use VertexSgbd;

create table if not exists Cliente
(
cd_Cliente int primary key auto_increment,
nm_Cliente varchar(100) not null,
ds_Email varchar(100) not null,
no_Cpf char(14) null unique,
no_Cnpj char(18) null unique,
nm_Logradouro varchar(100) not null,
no_Logradouro varchar(5) not null,
ds_Complemento varchar(20) null,
nm_bairro varchar(50) not null,
nm_Cidade varchar(60) not null,
sg_UF varchar(2) not null,
no_CEP char(10) not null
);

create table if not exists Telefone
(
cd_Cliente int,
no_Telefone char(11),
primary key(cd_Cliente, no_Telefone),
foreign key(cd_Cliente) references Cliente(cd_Cliente)
);

create table if not exists Atendente
(
cd_Atendente int primary key auto_increment,
ds_Login varchar(20) not null,
ds_Senha char(8) not null,
nm_Atendente varchar(100) not null
);



