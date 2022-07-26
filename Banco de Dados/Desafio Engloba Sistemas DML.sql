USE EnglobaSistemas;
GO


Insert Into Funcionario(Nome,CPF,RG,OrgaoEmissor,TituloEleitor,CNH,ATIVO,GESTOR)
VALUES					('Ruan Gustavo','359.467.047-24','18.373.349-6','Secretaria de segurança pública de São Paulo','723252870140','46119685357',0,0),
						('Lucas Thiago','771.528.850-01','30.851.699-0','Secretaria de segurança pública de São Paulo','665444640183','32159962511',0,0),
						('Ronaldo César','433.566.530-08','14.060.267-7','Secretaria de segurança pública de São Paulo','051552740140','88659031339',0,0);
GO

Insert Into Endereco(endereco,Numero,Complemento,Bairro,Cidade,Referencia)
Values				('Travessa Pamplona','190','','Rua Anani','Natal',''),
					('Rua Conde de Porto Alegre','178','','Novo Oriente','Maracanaú',''),
					('Rua José Carlos de Oliveira','806','','Novo Colorado','Cuiabá',''),
					('Rua Ana Nery','377','','João Eduardo I','Rio Branco','')

Go