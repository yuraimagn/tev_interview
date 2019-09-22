--PREGUNTA 1
select * from clientes order by nom_cliente;
--PREGUNTA 2
select * from clientes where loc_cliente = 'Madrid';
--PREGUNTA 3
select * from clientes where cp_cliente between 41000 and 41999;
--PREGUNTA 4
select * from clientes where cod_cliente < 10 or nom_cliente like 'A%';
--PREGUNTA 5
select loc_cliente, count(*) as cant_clientes from clientes group by loc_cliente;
--PREGUNTA 6
delete from clientes where nom_cliente like 'Z%' and nom_cliente like '%Z';
--PREGUNTA 7
update clientes set cp_cliente = 28001 where loc_cliente = 'Madrid';
select * from clientes; --verificación del update
--PREGUNTA 8
select c.*, v.importe from clientes as c inner join ventas as v on c.cod_cliente = v.cod_cliente where v.import <> 0;
--PREGUNTA 9
select c.*, ifnull(v.importe,0) as importe from clientes as c left join ventas as v on c.cod_cliente = v.cod_cliente;
--PREGUNTA 10
update ventas set importe = 0 where exists (select * from clientes where clientes.cod_cliente = importe.cod_cliente and nom_cliente like '%a%');
select c.*, v.importe from clientes as c inner join ventas as v on c.cod_cliente = v.cod_cliente; --Verificación del update	