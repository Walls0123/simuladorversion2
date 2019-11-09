
CREATE PROCEDURE RETISS_UnReg
@NRO_CUENTA CHAR(16)
AS
	SELECT p.Nombres, p.Apellidos, p.NroDocumento, c.NroCuenta
	FROM Cuentas  c
	INNER JOIN  Persona p ON c.Cliente = p.Id
	WHERE p.Tipo_Persona = 'CLI'
	AND c.NroCuenta = @NRO_CUENTA
