drop database if exists Klaer;
create database Klaer;
use Klaer;

Create table cliente(
IDCliente int auto_increment,
DNI int,
NomyApe varchar(30),
Tel varchar(12),
Domicilio varchar(50),
constraint PK_cliente primary key (IDCliente)
);


insert into cliente values
("",37930595, "Pedro Benitez", "11 23477760", "Bermudez 447"),
("",41499234, "Paula Valerio", "11 14280492", "Freancisco Beiro 1090"),
("",42492952, "Juan Hungaro", "11 35303464", "Cortina 224"),
("",38601288, "Ana Machetti", "11 66243598", "Martin Fierro 1790"),
("",36423306, "Sofia Zafiro", "11 56236654", "Lascano 4120"),
("",45263287, "Ramiro Orlandez", "11 16100443", "Oporto 356"),
("",46299252, "Macarena Rodriguez", "11 72569092", "Marcos Sastre 1017"),
("",44505535, "Tamara Fernandez", "11 71186437", "Av Segurola 1717"),
("",45985847, "Olivia Delgado", "11 60791308", "Av Beiro 2350"),
("",36928305, "Marcos Fuentes", "11 06482437", "Nazarre 1827"),
("",41975881, "Jose Tevez", "11 27629563", "Pedro Lozano 224"),
("",40475179, "Ignacio Romero ","11 66877388", "Simbron 1024"),
("",45419339, "Tomas Paez", "11 19637474", "Tinogasta 327"),
("",36106018, "Nazarena Garcia", "11 10331398", "San Blas 2413"),
("",44187320, "Rocio Chavez", "11 68111058", "Av Alvarez Jonte 4512");


Create table items(
IDProducto int auto_increment,
tipo varchar(20),
precio int,
cantidad int,
constraint PK_items primary key (IDProducto)
);

insert into items values
("","Zapatilla",10000,7),
("","Remera",700,5),
("","Zapato",12000,3),
("","Chomba",10000,3),
("","Camisa",1200,4),
("","Jean",3000,4),
("","Joggin",2500,1),
("","Short de jean",1400,5),
("","Tacon",8000,2),
("","Vestido",2000,6);

create table pedidos(
IDPedido int auto_increment,
IDcliente int,
constraint PK_pedidos primary key (IDPedido),
constraint FK_pedidos_cliente foreign key(IDCliente) references cliente(IDCliente)
);

/*
insert into pedidos values
("",1),
("",2),
("",3),
("",4),
("",5),
("",6),
("",7),
("",8),
("",9),
("",10);
*/

Create table detalle (
IdDetalle int not null auto_increment,
IdPedido int not null,
IdProducto int not null,
Cantidad int,
Constraint pk_detalle Primary Key(IdDetalle),
Constraint fk_DetallePedidio foreign key (idPedido) references Pedidos(IDPedido),
Constraint fk_DetalleProducto foreign key (idProducto) references Items(IDProducto)
);

create table recibo(
IDRecibo int auto_increment,
NroPedido int,
MetodoPago varchar(10),
cantidad int,
fecha date,
FechaMax date,
constraint PK_recibo primary key (IDRecibo),
constraint FK_recibo_pedidos foreign key (NroPedido) references pedidos(IDPedido)
);
/*
insert into recibo values
("",1,"Credito",2,"2021-11-10","2021/11/25"),
("",2,"Debito",1,"2021-11-10","2021/11/25"),
("",3,"Credito",3,"2021-11-11","2021/11/26"),
("",4,"Credito",1,"2021/11/13","2021/11/27"),
("",5,"Credito",1,"2021/11/13","2021/11/28"),
("",6,"Debito",2,"2021/11/14","2021/11/29"),
("",7,"Credito",1,"2021/11/14","2021/11/29"),
("",8,"Credito",1,"2021/11/15","2021/11/30"),
("",9,"Debito",2,"2021/11/15","2021/11/30"),
("",10,"Debito",3,"2021/11/15","2021/11/30");
*/
create table devolucion(
IDDevo int auto_increment,
NroRecibo int,
Motivo varchar(50),
Fecha date,
constraint PK_devolucion primary key (IDDevo),
constraint FK_devolucion_recibo foreign key(NroRecibo) references recibo(IDRecibo)
);


