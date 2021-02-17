# Building a RESTful API with ASP.NET Core 3 - Example 2

## Que es REST

REST no es un protocolo ni un estándar, **sino que se trata de un conjunto de principios de arquitectura.**
RESTful API es el sucesor de métodos anteriores como SOAP y WSDL cuya implementación y uso son un poco mas complejos y requieren mayores recursos y especificaciones al ser usados.

Para que una API se considere de **RESTful**, debe cumplir los siguientes criterios:

1. Arquitectura cliente-servidor compuesta de clientes, servidores y recursos, con la gestión de solicitudes a través de HTTP.
2. Datos que pueden ***almacenarse en caché** y **optimizan las interacciones*** entre el cliente y el servidor.
3. *Comunicación entre el cliente y el servidor sin estado*, así que no se almacena la información del cliente entre las solicitudes; cada una es independiente y está desconectada del resto. El estado de la sesión se mantiene completamente en el cliente.
4. Una interfaz uniforme entre los elementos, para que la información se transfiera de forma estandarizada.(**Links,estados de código**)

⇒ **StateLess**: Implicamos la funcionalidad de **token** para evitar que se guarde la actividad del cliente.

⇒ **Uniform Interface** ⇒ Todos los dispositivos pueden acceder a ese api.

# CACHING - Validation Model - Etags

![Validation Model](/Imatges/1.png?raw=true "Optional Title")

# Supporting Concurrency

![Supporting Concurrency](/Imatges/2.png?raw=true "Optional Title")

# HATEAOS
Ofrecer una interfaz universal. El cliente pueda moverse por la aplicación web únicamente siguiendo a los identificadores únicos URI en formato hipermedia.

![HATEAOS](/Imatges/3.png?raw=true "Optional Title")

# Shaping Data

![Shaping Data](/Imatges/4.png?raw=true "Optional Title")
