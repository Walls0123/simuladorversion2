CREATE Procedure [dbo].[MovimientoTipoCambioInsert]
(
@MontoE decimal(12,4),
@MonedaE varchar(50),
@MontoS decimal(12,4),
@MonedaS varchar(50),
@Usuario varchar(50)
)
AS
BEGIN
begin try 
	begin tran xtran
		Declare	@Entrada int = 4,
			@Salida int = 5,
			@Fecha_Creacion date = getdate(),
			@ID_TurnoUsuario int = (select ID from TurnoUsuario where ID_Usuario = (select Id from Persona where Nombres+' '+Apellidos = @Usuario))
			insert into MovimientosVentanilla (Monto,Moneda,ID_TurnoUsuario,ID_TipoMovimiento,Fecha_Creacion,Usuario_Creador)
			values (@MontoE,@MonedaE,@ID_TurnoUsuario,@Entrada,@Fecha_Creacion,@Usuario)
			insert into MovimientosVentanilla (Monto,Moneda,ID_TurnoUsuario,ID_TipoMovimiento,Fecha_Creacion,Usuario_Creador)
			values (@MontoS,@MonedaS,@ID_TurnoUsuario,@Salida,@Fecha_Creacion,@Usuario)
			  
	commit tran xtran
end try
BEGIN CATCH
	rollback tran xtran  
END CATCH;
END



select * from TipoMovimiento