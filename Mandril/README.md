# MandrilAPI - Estado actual del proyecto

## Descripción
Este proyecto es una API REST desarrollada en ASP.NET Core (.NET 8) para gestionar información de mandriles y sus habilidades. 

## Estructura principal
- **Modelos:** Mandril, Habilidad
- **Servicio:** MandrilDataStore (almacenamiento en memoria, patrón Singleton)
- **Controlador:** MandrilController (endpoints GET implementados)
- **Configuración:** Swagger habilitado para pruebas y documentación automática

## Estado actual
- La API permite consultar todos los mandriles y obtener uno por su Id.
- Los datos se almacenan en memoria, no hay persistencia en base de datos.
- No se han implementado operaciones de creación, edición ni borrado (POST, PUT, DELETE).
- No se utiliza ningún framework adicional como ABP.
- No hay autenticación ni autorización avanzada.

## Siguientes pasos sugeridos
- Implementar endpoints para crear, editar y eliminar mandriles.
- Agregar persistencia con base de datos (por ejemplo, Entity Framework Core).
- Mejorar validaciones y manejo de errores.
- Agregar autenticación/autorización si es necesario.
- Documentar los modelos y servicios con comentarios XML.

## Contacto
Para dudas o sugerencias, crea un issue en el repositorio.
