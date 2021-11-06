# lab3-tp6-json

>1- Escribir JSON 
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

>2- Leer JSON 
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

