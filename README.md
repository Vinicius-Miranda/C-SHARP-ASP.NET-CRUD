# C-SHARP-ASP.NET-CRUD
C.R.U.D. C# ASP.NET WEB FORM

TABLES:

PESSOA

CREATE TABLE [dbo].[Pessoa] (
    [IdPessoa]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]             NVARCHAR (50) NULL,
    [Email]            NVARCHAR (50) NULL,
    [DataHoraCadastro] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC)
);

-----------------------------------------------------------------------------------------------------------------------------------

ENDERECO

CREATE TABLE [dbo].[Endereco] (
    [IdEndereco] INT           IDENTITY (1, 1) NOT NULL,
    [Logradouro] NVARCHAR (50) NULL,
    [Cidade]     NVARCHAR (50) NULL,
    [Estado]     NVARCHAR (50) NULL,
    [IdPessoaFK] INT           NULL,
    PRIMARY KEY CLUSTERED ([IdEndereco] ASC),
    CONSTRAINT [FK_Endereco_Endereco] FOREIGN KEY ([IdPessoaFK]) REFERENCES [dbo].[Pessoa] ([IdPessoa])
);

-----------------------------------------------------------------------------------------------------------------------------------

STORED PROCEDURES

CREATE "PESSOA" AND "ENDERECO"

CREATE PROCEDURE [dbo].[CadPessoa]
	@Nome nvarchar(50),
	@Email nvarchar(50),
	@Logradouro nvarchar(50),
	@Cidade	nvarchar(50),
	@Estado nvarchar(50)
AS
DECLARE 
	@FK int,
	@DataHora datetime

BEGIN
	begin try
		begin transaction
		set @DataHora = (select CURRENT_TIMESTAMP)

		insert into Pessoa(Nome, Email, DataHoraCadastro)
		values(@Nome, @Email, @DataHora)

		set @FK = (select IDENT_CURRENT('Pessoa'))

		insert into Endereco(Logradouro, Cidade, Estado, IdPessoaFK)
		values(@Logradouro, @Cidade, @Estado, @FK)

		commit
	end try

	begin catch
		rollback
	end catch

END

-----------------------------------------------------------------------------------------------------------------------------------

UPDATE "PESSOA" AND "ENDERECO"

CREATE PROCEDURE dbo.AtualizarPessoa
	@Id int,
	@Nome nvarchar(50),
	@Email nvarchar(50),
	@Logradouro nvarchar(50),
	@Cidade	nvarchar(50),
	@Estado nvarchar(50)
AS

BEGIN
	begin try
		begin transaction

		update Pessoa set Nome = @Nome, Email = @Email where IdPessoa = @Id
		update Endereco set Logradouro = @Logradouro, Cidade = @Cidade, Estado = @Estado where IdPessoaFK = @Id

		commit
	end try

	begin catch
		rollback
	end catch

END

-----------------------------------------------------------------------------------------------------------------------------------

DELETE "PESSOA" AND "ENDERECO"

CREATE PROCEDURE dbo.ExcluirPessoa
	@Id int 
AS
BEGIN
	begin try
		begin transaction
			delete from Endereco where IdPessoaFK = @Id
			delete from Pessoa where IdPessoa = @Id
		commit
	end try
	begin catch
		rollback
	end catch
END

-----------------------------------------------------------------------------------------------------------------------------------
