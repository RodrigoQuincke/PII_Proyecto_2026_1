# PII_Proyecto_2026_1# PII_Proyecto_2026_1

## Integrantes

- Santiago Abella
- Rodrigo García
- Rodrigo Quinke
- Gerónimo Sosa

---

## Descripción del proyecto

Sistema de recomendaciones implementado como chatbot. Permite registrar usuarios, gestionar un catálogo de contenido, registrar interacciones y generar recomendaciones personalizadas usando distintas estrategias.

El motor de recomendación está desacoplado del dominio, trabajando con abstracciones (`IContent`, `IRecommendationStrategy`, `IRecommendationFilter`, `IRecommendationSorter`) para que pueda reutilizarse con cualquier tipo de contenido sin modificaciones.

---

## Tablero Trello

[Link al tablero](https://trello.com/b/mRfUaY1R)

---

## Notas del equipo

### Desafíos

El mayor desafío de esta entrega fue el modelado inicial de las clases. No era difícil escribir el código en sí, sino entender qué clases tenían que existir, qué responsabilidad le correspondía a cada una y cómo tenían que relacionarse entre sí para que todo tuviera sentido con la consigna.

Al principio teníamos la lógica bastante mezclada: nos costó ubicar y entender algunos métodos y como funcionaban algunas cosas. 

El Facade también nos generó complicaciones al principio. Entendíamos la idea general, pero costó decidir exactamente qué tenía que mostrar y qué tenía que ocultar.

### Qué aprendimos

El proyecto nos ayudó a seguir internalizando en como funciona la programación orientado a objetos. No tanto la sintaxis de C#, que ya la veníamos manejando, sino el proceso de diseño: cómo partir de un problema, identificar las clases, asignarles responsabilidades y hacer que colaboren sin acoplarse demasiado.


### Recursos que usamos

- Usamos Claude (IA) para pulir algunos métodos donde no teníamos claro cómo escribirlos en C#, principalmente en las estrategias de recomendación y los filtros
