# Algoritmos de Búsqueda en C#

## Introducción

Este proyecto implementa distintos métodos de búsqueda en arreglos de enteros, permitiendo al usuario probar su rendimiento y funcionamiento a través de un menú interactivo por consola. Además, se incluye una implementación básica de una tabla Hash que permite almacenar y consultar valores por clave.

### Métodos de búsqueda implementados:

- Búsqueda Secuencial (no ordenada)
- Búsqueda Secuencial Ordenada
- Búsqueda Binaria
- Inserción y búsqueda en Tabla Hash

## Instalación y Ejecución

### Requisitos
- .NET SDK 6.0 o superior

### Instrucciones

1. Clonar el repositorio:
   bash
   git clone https://github.com/tu-usuario/algoritmos-busqueda-cs.git
   cd algoritmos-busqueda-cs
   

2. Compilar y ejecutar:
   bash
   dotnet run
   

## Estructura del Código


/algoritmos-busqueda-cs
│
├── Program.cs        // Menú principal de interacción con el usuario
├── Search.cs         // Implementaciones de búsqueda secuencial y binaria
├── Hash.cs           // Implementación de tabla hash con inserción y búsqueda por clave
└── README.md         // Documentación del proyecto


### Descripción de archivos

- Program.cs  
  Contiene el flujo principal del programa: presenta el menú, recoge datos del usuario, y coordina las llamadas a los métodos de búsqueda o hash.

- Search.cs  
  Implementa:
  - UnorderedLinear: búsqueda secuencial clásica en cualquier arreglo.
  - OrderedLinear: búsqueda secuencial más eficiente en arreglos ordenados.
  - Binary: búsqueda binaria en arreglos previamente ordenados.

- Hash.cs  
  Define una tabla hash simple que:
  - Usa módulo como función hash (key % size)
  - Inserta pares clave-valor
  - Permite consultar por clave
  - Muestra el estado de la tabla con colisiones tratadas mediante listas.

## Análisis de Rendimiento

A continuación se muestran ejemplos de rendimiento de los distintos métodos usando arreglos de distintos tamaños y orden:

| Tamaño del Arreglo | Búsqueda Secuencial | Búsqueda Ordenada | Búsqueda Binaria |
|--------------------|---------------------|--------------------|------------------|
| 10 elementos       | Muy rápida          | Muy rápida         | Muy rápida       |
| 100 elementos      | Rápida              | Rápida             | Muy rápida       |
| 1000 elementos     | Lenta               | Regular            | Rápida           |
| 10,000 elementos   | Muy lenta           | Lenta              | Rápida           |

Nota: Los tiempos de búsqueda se midieron empíricamente usando Stopwatch en pruebas manuales.

## Conclusiones

- Búsqueda Secuencial No Ordenada: útil para arreglos pequeños o no ordenados, pero poco eficiente en gran escala.
- Búsqueda Secuencial Ordenada: mejora ligeramente la eficiencia si los datos están ordenados.
- Búsqueda Binaria: la opción más eficiente para arreglos grandes y ordenados (O(log n)).
- Tabla Hash: útil para accesos rápidos por clave, aunque su eficiencia depende del tamaño de la tabla y la dispersión de claves.
