create database CrudApi
use CrudApi

create table Producto(
 id_Producto int identity(1,1) primary key not null,
 nombre varchar(100) not null,
 descripcion varchar(100) not null,
 precio decimal not null,
 porcentaje_impuesto decimal not null
)

select * from Producto

insert into Producto values
('Xiaomi Redmi Note 8','Telefono celular',9500,18),
('Xiaomi Redmi Note 9','Telefono celular',11500,18)




Postman Shortcuts
//Get Productos
 https://url/api/product/5
 https://url/api/product


//Post Productos

{
    "nombre":"Alcatel A40",
    "descripcion":"Una Piedra de un milenio",
    "precio":"400",
    "porcentaje_impuesto":"18"
}

//Put Productos

{
    "id_Producto":"7",
    "nombre":"Alcatel A50",
    "descripcion":"Uno de los telefonos de Viva",
    "precio":"4000",
    "porcentaje_impuesto":"18"
}


//Delete Productos

https://url/api/product/5