# README PROTOTIPO
## MANUAL DE USO
### - Controles
Los controles dentro del museo consisten en el uso de un mando de videojuegos (recomendado uno de Play Station 4), los movimientos del personaje se llevarán a cabo mediante el joystick izquierdo, mientras que la cámara se moverá haciendo uso del joystick derecho. El resto de opciones están indicadas dentro del museo, aunque son las siguientes (siguiendo la ubicación de un mando de PS4):
  - La 'X' abre la información de los cuadros.
  - El '□' cierra los menús o los vídeos que se abran.
  - El '△' reproduce los videos una vez se ha abierto la información de los cuadros.
  - El '◯' marca la opción deseada por el jugador para el cuestionario a modo de respuesta.
### - Cuadros
Además de contemplar el cuadro, el usuario tiene acceso a información sobre el cuadro que esté mirando. Para acceder a esta información deberá acercarse al cuadro y al mirarlo, aparecerá un cuadro de texto debajo del cuadro, en él se especifica que pulsando el botón espacio se abrirá una ventana delante del cuadro con dicha información. 

![Cuadro_marcado](https://github.com/AdriSG12/Interfaces-Inteligentes/assets/57297807/d723f164-2e24-4aba-979e-45fb5d755e52)

Para cerrar esa ventana bastará con dejar de mirar a ese cuadro o pulsar el botón escape. 

![Interfaz](https://github.com/AdriSG12/Interfaces-Inteligentes/assets/57297807/7d0ae4cc-b0ae-4c65-a666-68c3aa429a54)

Algunos cuadros tienen disponible un video en 360 grados. Para ver los videos de los cuadros que tengan disponible esta opción hay que abrir la ventana de información del cuadro y pulsar el botón espacio como se indicará en la parte inferior de la ventana de información.

![Cuadro_video](https://github.com/AdriSG12/Interfaces-Inteligentes/assets/57297807/3ce8b719-e2d1-4f4c-9c2a-bfec563be107)

### - Cambiar de piso
El museo dispone de dos pisos, para subir y bajar las escaleras el usuario solo deberá colocarse sobre los teletransportes del piso actual para subir o bajar de piso.
## HITOS DE PROGRAMACIÓN
### - Videos 360º
Los videos en 360º es el principal atractivo del museo, su desarrollo fue bastante tedioso debido a la busqueda de propios videos, para que tuvieran relación con cada cuadro, la grabación del video debía ser concretamente en 360º para que al establecerlo como material de una esfera este se viera sin cortes o incongruencias. 
Las principales dificulates a la hora de programar fueron las incompatibilidades entre cámaras, ya que dentro de cada esfera se coloca una camara que actuará como usuario. Por ello, se optó porque todos los videos estuvieran desactivados hasta que un usuario decidiera acceder a ellos y al salir se desactiva, mientras se reproduce el video la cámara del usuario también queda desactivada. 
### - Cuestionario
Se ha implementado un cuestionario a modo de adición para los usuarios, y que no solo puedan consultar la información de los cuadros, tener experiencias inmersivas y aprender, sino evaluar los conocimientos adquiridos por medio de una prueba. Para ello deben acercarse al televisor de la planta 0 y seguir sus instrucciones.
### - Interfaz de los cuadros
Para la interfaz de los cuadros el usuario cuenta con un Box Collider que cuando este colisiona con un cuadro se activa la opción de abrir la venta de información, se mantendrá mientras el usuario no deje de mirar el cuadro. Ocurre lo mismo para la ventana de información una vez abierta. 
## ASPECTOS DESTACABLES
Dentro del proyecto se han trabajado muchos contenidos trabajados en la asignatura y otros nuevos, los principales a resaltar serían:
- Los 'face tracking' o seguimiento de movimiento de cabeza para el movimiento de las cámaras (este ha sido implementado dentro de los vídeos 360º).
- Los propios vídeos 360º, que ha supuesto un gran reto no solo reproducirlos, sino disponer de ellos y permitir el movimiento una vez se iniciado el video.
- El uso de eventos y delegados, que han sido de gran utilidad a la hora de programar elementos como el cuestionario. 
## GIF DE EJECUCIÓN

https://github.com/AdriSG12/Interfaces-Inteligentes/assets/57297807/48e89397-9aa2-4144-b063-28783cef6d2d

## ACTA DE TRABAJO
|TAREAS|ASIGNACIÓN|
|------|----------|
|Recopilación Videos 360º| En grupo|
|Recopilación obras| En grupo|
|Recopilación datos de obras | En grupo|
|Programación Videos 360º| Adrián|
|Estructura museo| Jorge
|Programación jugador| Gabriel|
|Interfaz de las obras| Jorge|
|Cuestionario| Jorge y Grabriel |
|Interacción jugador con obras y interfaces flotantes | Adrián|

## PRESENTACIÓN
https://docs.google.com/presentation/d/1uwi5DzHhffHO7aCI-IRr6cC7fTt4h2V7c_XjptJwouo/edit?usp=sharing


