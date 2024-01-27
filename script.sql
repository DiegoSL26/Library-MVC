CREATE DATABASE Library;

USE Library;

CREATE TABLE Author (
	id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	authorName VARCHAR(255) NOT NULL
)

CREATE TABLE Book (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	title VARCHAR(255) NOT NULL,
	authorID INT FOREIGN KEY REFERENCES Author(id)
	ON DELETE CASCADE
    ON UPDATE CASCADE
)

insert into Author values ('Mario Mendoza');
insert into Book values ('La melancolia de los feos', 1);

select * from Author;

select * from Book;

DROP TABLE Book;
DROP TABLE Author;
DROP DATABASE Library;
