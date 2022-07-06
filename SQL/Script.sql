


create database db_n5
go
use db_n5
go
create table Permissions(
Id integer identity primary key,
NombreEmpleado text not null,
ApellidoEmpleado Text not null,
TipoPermiso integer not null,
FechaPermiso date not null,
Estado int not null
)
go

create table PermissionTypes(
Id integer identity primary key,
Descripcion text not null,
Estado int not null
)
go

ALTER TABLE Permissions
ADD FOREIGN KEY (TipoPermiso) REFERENCES PermissionTypes(Id);

go
insert into [Permission].[PermissionTypes] values ('Nuevo',1)
insert into [Permission].[PermissionTypes] values ('Editar',1)
insert into [Permission].[PermissionTypes] values ('Eliminar',1)
insert into [Permission].Permissions values ('Diego Alexis','Gil Munoz',1,getdate(),1);
insert into [Permission].Permissions values ('Ibrahim','Bonilla Challo',1,getdate(),1);



select *
from [Permission].Permissions