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
insert into Author values ('JK Rowling');
insert into Author values ('Gabriel Garcia Marquez');
insert into Author values ('Stephen King');
insert into Author values ('Santiago Gamboa');

insert into Book values ('La melancolía de los feos', 1);
insert into Book values ('Harry Potter', 2);
insert into Book values ('Cien años de soledad', 3);
insert into Book values ('It', 4);
insert into Book values ('Perder es cuestión de método', 5);