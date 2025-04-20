-- Modificación de la tabla tbl_hotel
ALTER TABLE tbl_hotel
ALTER COLUMN fecha_update datetime DEFAULT GETDATE() NULL;