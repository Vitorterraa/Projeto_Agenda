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
categoria varchar (50) not null
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
    (usuario, data, descricao)
    values
    (user(),
    current_timestamp(),
    concat('A categoria', old.categoria, 'foi excluída')
    );
end;
$$


delimiter $$
create trigger trLogUpdateCategoria
after
update
on tbcategoria
for each row
begin
	insert into tblog
    (usuario, data, descricao)
    values
    (user(),
    current_timestamp(),
    concat('A categoria', new.categoria, 'foi alterada')
    );
end;
$$


delimiter $$
create trigger trLogInsertCategoria
after
insert
on tbcategoria
for each row
begin
	insert into tblog
    (usuario, data, descricao)
    values
    (user(),
    current_timestamp(),
    concat('A categoria', new.categoria, 'foi inserida')
    );
end;
$$