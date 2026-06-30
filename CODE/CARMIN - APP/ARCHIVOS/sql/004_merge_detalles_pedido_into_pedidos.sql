PRAGMA foreign_keys = OFF;

CREATE TABLE PedidosNueva
(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    IdCliente INTEGER NOT NULL,
    IdPresupuesto INTEGER NOT NULL,
    Estado TEXT NOT NULL,
    EstadoDePago TEXT NOT NULL,
    FechaDeEntrega TEXT NOT NULL,
    Importe NUMERIC NOT NULL,
    TiempoTotalDeProduccion NUMERIC NOT NULL,
    FOREIGN KEY (IdCliente) REFERENCES Clientes (Id),
    FOREIGN KEY (IdPresupuesto) REFERENCES Presupuestos (Id)
);

INSERT INTO PedidosNueva
    (Id, Nombre, IdCliente, IdPresupuesto, Estado, EstadoDePago, FechaDeEntrega, Importe, TiempoTotalDeProduccion)
SELECT
    p.Id,
    p.Nombre,
    p.IdCliente,
    p.IdPresupuesto,
    COALESCE(dp.Estado, 'ENCARGADO'),
    COALESCE(dp.EstadoDePago, 'PENDIENTE'),
    COALESCE(dp.FechaDeEntrega, CURRENT_TIMESTAMP),
    COALESCE(dp.Importe, 0),
    COALESCE(dp.TiempoTotalDeProduccion, 0)
FROM Pedidos p
LEFT JOIN DetallesPedido dp ON dp.Id = p.Id;

DROP TABLE DetallesPedido;
DROP TABLE Pedidos;
ALTER TABLE PedidosNueva RENAME TO Pedidos;

PRAGMA foreign_keys = ON;
