
CREATE PROCEDURE PERSSS_UnTodos
@NRO_DOCUMENTO VARCHAR(15) = NULL
AS 
SELECT NroDocumento, Apellidos, Nombres
FROM Persona
WHERE NroDocumento LIKE ISNULL(@NRO_DOCUMENTO + '%', NroDocumento)



sp_helptext RetirosInsert

CREATE PROC [dbo].[RetirosInsert]
	@Monto DECIMAL(12,4),
	@NroCuenta char(16),
	@Clave int,
	@doi char(17),
	@Usuario varchar(50)
AS BEGIN
	if exists (select Ta.Password from Tarjetas Ta where Ta.Password = @Clave)
		begin
			if @Monto < (Select cu.SaldoDisponible from Cuentas Cu where Cu.NroCuenta = @NroCuenta)
				begin
					update Cuentas
					set SaldoDisponible = SaldoDisponible - @Monto					
					where NroCuenta = @NroCuenta
					--------------------------------------------------------
					declare @ID_TurnoUsuario int = (select ID from TurnoUsuario where ID_Usuario = (select Id from Persona where Nombres+' '+Apellidos = @Usuario))	
					insert into MovimientosVentanilla (ID_Cuenta,Monto,Moneda,ID_TurnoUsuario,ID_TipoMovimiento,Usuario_Creador,DOI)
					values (@NroCuenta,@Monto,(select TM.Nombre from Cuentas C inner join TipoMoneda TM on C.TipoMoneda = TM.ID where C.NroCuenta = @NroCuenta),@ID_TurnoUsuario,2,@Usuario,@doi)
			end
			else
				begin
					raiserror('No cuenta con saldo suficiente para realizar la operacion',16,1)
			end
	end
	else
		begin
		 raiserror('La calve es incorrecta',16,1)
	end
end