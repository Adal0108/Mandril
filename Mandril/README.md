# MandrilAPI - Estado actual del proyecto

## Descripci�n
Este proyecto es una API REST desarrollada en ASP.NET Core (.NET 8) para gestionar informaci�n de mandriles y sus habilidades. 

## Estructura principal
- **Modelos:** Mandril, Habilidad
- **Servicio:** MandrilDataStore (almacenamiento en memoria, patr�n Singleton)
- **Controlador:** MandrilController (endpoints GET implementados)
- **Configuraci�n:** Swagger habilitado para pruebas y documentaci�n autom�tica

## Estado actual
- La API permite consultar todos los mandriles y obtener uno por su Id.
- Los datos se almacenan en memoria, no hay persistencia en base de datos.
- No se han implementado operaciones de creaci�n, edici�n ni borrado (POST, PUT, DELETE).
- No se utiliza ning�n framework adicional como ABP.
- No hay autenticaci�n ni autorizaci�n avanzada.

## Siguientes pasos sugeridos
- Implementar endpoints para crear, editar y eliminar mandriles.
- Agregar persistencia con base de datos (por ejemplo, Entity Framework Core).
- Mejorar validaciones y manejo de errores.
- Agregar autenticaci�n/autorizaci�n si es necesario.
- Documentar los modelos y servicios con comentarios XML.

## Contacto
Para dudas o sugerencias, crea un issue en el repositorio.
