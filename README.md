# Bomberos Voluntarios 🧑‍🚒
<p align="center">

<img src="ProyectoBomberos2\Resources\BomberosLogo1.png" alt="logo" height ="500" width = "550">

</p>

Se desarrollo un software a medida para los Bomberos voluntarios de San Vicente que necesitaban un sistema con el fin de despapelizar y descontinuar el uso de cuadernos para el registro de sus tramites internos.

## Caracteristicas

Con el sistema se logro:

- Gestión de entradas y salidas.
- Registro de tareas de los bomberos, suboficiales y jefes.
- Roles de usuarios.
- Incorporar zona de administración solo accesible para suboficiales y jefes.
- Gestión de Áreas del cuartel donde se podrá controlar la asistencia de los bomberos al Área y la institución como también el registro de las tareas realizadas.
- Control de puntajes por asistencias.
- Registro de horas cumplida en el cuartel.
- Dar de alta nuevos usuarios con área y jerarquía
- Asignación de áreas especificas a bomberos.
- Registro de asistencia de bomberos a emergencias.

## Pantallas

### Inicio

En la pantalla de inicio todos los miembros del cuartel deberán ingresar su numero de identificación para ingresar al sistema.

![Inicio](assets\inicio.png "Inicio")

Una vez que el usuario ingresa la identificación podra ingresar al sistema y registrar: su hora de entrada, salida y la tarea que realizo.

![Inicio](assets\inicio-2.png "Inicio")

![Inicio](assets\firma.png "Inicio")
> Ejemplo de firma: registrar hora de ingreso al cuartel.

![Inicio](assets\tarea.png "Inicio")
> Registro de tarea realizada en el cuartel.

### Administración

El área de administración puede ser solo accedida por los suboficiales y jefes del cuartel, cada usuario cuenta con una jerarquía y si ingresa un identificador de un usuario que no es de jerarquía superior el acceso será denegado.

![Administración](assets\admin.png "Administración")
Una vez que se ingresa al área de administración el administrador podrá gestionar las áreas del cuartel, dar de alta usuarios y asignar áreas a los bomberos.

![Administración](assets\admin-2.png "Administración")

#### Gestión de Áreas

En esta sección el administrador gestiona las áreas del cuartel; controla la asistencia al área, asistencia a la institución y las tareas del área realizadas por los bomberos.

![Areas](assets\areas.png "Areas")

![Areas](assets\asis-area.png "Areas")
> Asistencia al área.

![Areas](assets\asis-insti.png "Areas")
> Asistencia a la Institución.

![Areas](assets\tarea-area.png "Areas")
> Registro de tareas realizadas por areas.

#### Dar de alta usuarios

Acá el administrador puede dar de alta un nuevo usuario asignándole un área del cuartel y su jerarquía.

![Areas](assets\alta.png "Areas")

Una vez que se registra un nuevo usuario se genera automáticamente un identificador para que el nuevo usuario pueda acceder al sistema cuando quiera marcar su hora de entrada, salida y registrar las tareas que realizo en el cuartel.

![Areas](assets\alta-2.png "Areas")

#### Asignar área a bomberos
En esta sección el administrador puede asignar un bombero a un área especifica del cuartel, para buscar al bombero se busca por su identificador y se selecciona el nueva área donde va a desempeñar sus actividades.

![Areas](assets\asignar.png "Areas")

![Areas](assets\asignar-2.png "Areas")

> Mensaje de confirmaciòn: el bombero fue cambiado de área. 

## Tecnologias utilizadas
![.NET Windows Forms](https://img.shields.io/badge/.net%20Windows%20Forms-5C2D91?style=for-the-badge&logo=.net&logoColor=5C2D91&labelColor=white)
![C#](https://img.shields.io/badge/csharp-purple?style=for-the-badge&logo=sharp&logoColor=purple&labelColor=white)
![SQLite](https://img.shields.io/badge/sql:%20mssql-003B57?style=for-the-badge&logo=sqlite&logoColor=003B57&labelColor=white)