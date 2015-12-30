
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
	Translation nvarchar(100) NOT NULL
);

INSERT INTO Words(EnglishWord, Translation) VALUES('Hello', 'Привет');
INSERT INTO Words(EnglishWord, Translation) VALUES('World', 'Мир');