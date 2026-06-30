PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS ImpresoraPerfilesImpresion
(
    IdImpresora INTEGER NOT NULL,
    IdPerfilImpresion INTEGER NOT NULL,
    PRIMARY KEY (IdImpresora, IdPerfilImpresion),
    FOREIGN KEY (IdImpresora) REFERENCES Impresoras (Id) ON DELETE CASCADE,
    FOREIGN KEY (IdPerfilImpresion) REFERENCES PerfilesImpresion (Id) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS ImpresoraInsumosImpresora
(
    IdImpresora INTEGER NOT NULL,
    IdInsumoImpresora INTEGER NOT NULL,
    PRIMARY KEY (IdImpresora, IdInsumoImpresora),
    FOREIGN KEY (IdImpresora) REFERENCES Impresoras (Id) ON DELETE CASCADE,
    FOREIGN KEY (IdInsumoImpresora) REFERENCES Insumos (Id)
);
