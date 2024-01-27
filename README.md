# AZ Smart Library

Desarrollo de una aplicación web Full-Stack simplificada para la gestión de bibliotecas donde los usuarios pueden ver libros y agregar tanto libros como autores.
Se cuenta con 3 páginas, la página "Home" muestra todos los libros y sus respectivos autores, la página "Add an Author" otorga la posibilidad de agregar a un autor por su nombre, finalmente la página "Add a Book" permite al usuario agregar un libro escribiendo el nombre del libro y seleccionando a su autor de una lista desplegable de autores existentes.
Se usó ASP.NET MVC, SQL Server y Entity Framework, además fué desarrollado usando el lenguaje de programación C#, el lenguaje de marcado web HTML y sus respectivos estilos mediante el framework de CSS llamado Bootstrap.

##Pasos para configurar y ejecutar la aplicación

1. Clone este repositorio de Git en su máquina local.
2. Abra SQL Server y conéctese al servidor teniendo en cuenta los siguientes parámetros:
   2.1. En Server type seleccione Database Engine.
   2.2. Server Name puede dejarlo como viene por defecto.
   2.3.  En Authentication seleccione Windows Authentication.
3. Una vez conectado al servidor, ejecute el archivo script.sql (el cual se encuentra en la carpeta raíz del repositorio clonado) para crear e inicializar de forma local la base de datos "Library" y sus respectivas tablas "Author" y "Book" junto con sus relaciones.
4. Abra el proyecto clonado en su IDE de preferencia (se recomienda usar Visual Studio Code o Visual Studio 2022).
5. Ejecute el proyecto desde su IDE de preferencia.

## Capturas de pantalla de las principales funcionalidades de la aplicación

![Home page](https://github.com/DiegoSL26/Library-MVC/assets/64794509/023aeb4a-9d16-450b-8830-369d787a9dfb)

![Add an Author page](https://github.com/DiegoSL26/Library-MVC/assets/64794509/feacf915-b158-4714-920e-e99ea3d70fae)

![Add a Book page with the list of authors](https://github.com/DiegoSL26/Library-MVC/assets/64794509/c3ed453a-94d5-4737-88d5-911e73077b52)

## Diagrama entidad relación de la base de datos
