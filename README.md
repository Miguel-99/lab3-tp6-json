# lab3-tp6-json

>1. Escribir JSON 
>Cree 2 tablas de base de datos:  
>Escritor: Campos-> id(PK),apellido, nombre, dni  
>Libro: Campos->nombre, año publicación, editorial, idEscritor(FK)  
>Cargue algunos campos de prueba en ambas tablas relacionando el escritor con  
>el libro mediante sus claves (PK/FK)  
>Mediante C# realice la conexión a la base de datos, obtenga los datos y ejecute  
>la escritura en un archivo con la siguiente estructura JSON.  
```[{ 
 "id": " XXXX ", 
 "apellido": " XXXX ", 
 "nombre": " XXXX ", 
 "dni": " XXXX ", 
"libros": [{ 
  "nombre": "XXXX", 
  "anioPublicacion": " XXXX ", 
  "editorial": " XXXX " 
 }, 
{ 
  "nombre": " XXXX ", 
  "anioPublicacion": " XXXX ", 
  "editorial": " XXXX " 
 }, 
{ 
  "nombre": " XXXX ", 
  "anioPublicacion": " XXXX ", 
  "editorial": " XXXX " 
  }], 
"id": " XXXX ", 
 "apellido": " XXXX ", 
 "nombre": " XXXX ", 
 "dni": " XXXX ", 
"libros": [{ 
  "nombre": "XXXX", 
  "anioPublicacion": " XXXX ", 
  "editorial": " XXXX " 
 }, 
{ 
  "nombre": " XXXX ", 
  "anioPublicacion": " XXXX ", 
  "editorial": " XXXX " 
 }, 
{ 
  "nombre": " XXXX ", 
  "anioPublicacion": " XXXX ", 
  "editorial": " XXXX " 
  }], 
....................................... 
}] 
```

>2. Leer JSON 
>Ejecute la lectura de un JSON, obtenido desde la URL 
> 
>https://randomuser.me/api/?results=10 
> 
>Codifique las clases necesarias para mapear el JSON en los objetos correspondientes y  
>muestre por la consola los atributos  
>- First de name  
>- Last de name  
>- Username de login  
>- Password de login  

---
## Resultado escritura de json
author table:  
![imagen](https://user-images.githubusercontent.com/65373208/140625841-2e6d3c0c-ff42-45de-bf78-f6d3ea892868.png)

book table:  
![imagen](https://user-images.githubusercontent.com/65373208/140625855-1e6f5c0c-9078-48be-a334-d18de87543f2.png)

json persisted:
```
[
  {
    "Id": 1,
    "Nombre": "chope",
    "Apellido": "juan",
    "Dni": 22123123,
    "Libros": [
      {
        "Id": 1,
        "Name": "senior de las cervezas",
        "Anio_publicacion": 1999,
        "Editorial": "editorial1",
        "IdAuthor": 1
      }
    ]
  },
  {
    "Id": 2,
    "Nombre": "escamoso",
    "Apellido": "pedro",
    "Dni": 23123123,
    "Libros": [
      {
        "Id": 2,
        "Name": "natacha",
        "Anio_publicacion": 20005,
        "Editorial": "editorial2",
        "IdAuthor": 2
      },
      {
        "Id": 3,
        "Name": "arboles inmortales",
        "Anio_publicacion": 2010,
        "Editorial": "editorial3",
        "IdAuthor": 2
      }
    ]
  }
]
```

## Resultado consumisión y modelado de api

```
First name: Elias
Last name: Rasmussen
Username: blueduck174
Password: digital1
-----------------------------


First name: Annemarie
Last name: Dupuis
Username: purpleduck710
Password: gilligan
-----------------------------


First name: Lærke
Last name: Christensen
Username: purplebutterfly940
Password: hayley
-----------------------------
