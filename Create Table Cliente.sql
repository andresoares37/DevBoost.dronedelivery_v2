USE DroneDelivery

GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] NOT NULL,
	[Nome] [varchar](60) NOT NULL,
	[Latitude] [decimal](12, 9) NOT NULL,
	[Longitude] [decimal](12, 9) NOT NULL,
	[PedidoId][uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
, CONSTRAINT FK_Pedido FOREIGN KEY (PedidoId)
        REFERENCES Pedido (Id)
) 