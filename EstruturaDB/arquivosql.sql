create database dbagenda
use dbagenda
create table tbusuarios (
nome varchar (50) not null,
usuario varchar(40) primary key,
telefone varchar (15),
senha varchar (20) not null
);

create table tbcategoria (
id_categoria int auto_increment primary key,
categoria varchar (50) not null
);







    
	