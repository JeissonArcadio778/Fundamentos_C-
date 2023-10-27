# ¿Qué es? Plataforma de desarrollo gratuita. Pasa codigo C# a codigo de máquina

Versiones: 

2002 - Lanzamiento
2014 - .Net Core
2020 - .Net 5+ (Recomenda usar). No es necesario emigrar.
2021 - .Net 6.0

Usuarios y Desarrolladores. 

Lenguajes compartibles:  c#, f#, visual basic. 

Desarrollo:

	- Aplicaciones de consola
	- Aplicaciones Web
	- Aplicaciones Móviles
	- Aplicaciones de escritorio
	- Juego
	- Aplicaciones nativas de la nube
	- IoT

Implementaciones: 

CLR: common Language Runtime:

Componente basico. Lee todo el código escrito en .Net. 

# Biblioteca: 
Es el archivo ejecutable que contiene la lógica de una aplicación. Esta esta compuesta de clases y métodos. 

## namespace: 
Cumple con la funcionalidad de organizar e identificar las clases que contienen las bibliotecas

# Metodos: 


## Static:

Se declara para no evitar que se creen instancias de la clase para usar el método. Para llamarlo, se usa el nombre de la clase que contiene ese método. 

Existen dos tipos de llamado de metodos: 

Miembros static y miembros de instancia.

Diferencia: los miembros de static pertenecen a la clase y los miembros de instancia pertenecen a los objectos. 

¿En qué afecta? No es necesario crear una instancia para usar un método de una clase con static. 

### Desventajas: 

	- No puede llamar a otros métodos de la clase, a menos que sean static
	- No se puede usar this
	- Imposible acceder a los miembros de la clase, como los campos, a menos que también sean static. 
	- Practicamente perdemos todas las ventajas de la programación orientada a objetos. 
	
Para hacer un llamado de un método static desde otro contexto, es necesario usar el nombre la clase que contiene ese método. 


Car.TestStatic("El main con el nombre de la clase."); 

Una instancia no puede llamar un método static. 