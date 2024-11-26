create database dbagenda;
use dbagenda;
create table tbusuarios (
nome varchar (50) not null,
usuario varchar(40) primary key,
telefone varchar (15),
senha varchar (20) not null
);

create table tbcategoria (
id_categoria int auto_increment primary key,
categoria varchar (50) not null,
usuario varchar (50) not null
);

delimiter $$
create trigger trInsertCategoria
BEFORE 
INSERT
ON tbcategoria
FOR EACH ROW
BEGIN
SET NEW.usuario = current_user();
END;
$$

create table tblog (
id_log int auto_increment primary key,
usuario varchar (40),
dataehora timestamp not null,
descricao varchar (70)
); 

delimiter $$

create trigger trLogDeleteCategoria
after
delete
on tbcategoria
for each row
begin
	insert into tblog
    (usuario, dataehora, descricao)
    values
    (user(),
    current_timestamp(),
    concat('A categoria', old.categoria, 'foi excluída')
    );
end;
$$