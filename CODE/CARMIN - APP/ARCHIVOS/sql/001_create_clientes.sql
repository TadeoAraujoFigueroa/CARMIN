PRAGMA foreign_keys = ON;

CREATE TABLE IF NOT EXISTS Clientes
(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    Telefono TEXT NULL,
    Direccion TEXT NULL
);
