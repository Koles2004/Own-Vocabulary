
IF DB_ID('Vocabulary') IS NOT NULL
DROP DATABASE Vocabulary
GO

CREATE DATABASE Vocabulary
GO

USE Vocabulary
GO

CREATE TABLE Words
(
	Id bigint IDENTITY(1,1) NOT NULL PRIMARY KEY,
	EnglishWord nvarchar(100) NOT NULL,
	Translation nvarchar(100) NOT NULL,
	Known bit
);

INSERT INTO Words(EnglishWord, Translation, Known) VALUES('Hello', 'Привет', 1);
INSERT INTO Words(EnglishWord, Translation, Known) VALUES('World', 'Мир', 1);