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

![Validation Model](https://storage.cloudconvert.com/tasks/a7c1ede7-11a9-474f-af08-f1a38617a688/1.png?AWSAccessKeyId=cloudconvert-production&Expires=1611853268&Signature=NqZvrOp52J06CCaW61uLLa4HMns%3D&response-content-disposition=inline%3B%20filename%3D%221.png%22&response-content-type=image%2Fpng)

# Supporting Concurrency

![Supporting Concurrency](https://storage.cloudconvert.com/tasks/b1197cde-d478-44cf-8d94-77123c0103f0/2.png?AWSAccessKeyId=cloudconvert-production&Expires=1611853276&Signature=%2FV%2B6SaBogKlpwaAynP7uiLv3Rog%3D&response-content-disposition=inline%3B%20filename%3D%222.png%22&response-content-type=image%2Fpng)

# HATEAOS
Ofrecer una interfaz universal. El cliente pueda moverse por la aplicación web únicamente siguiendo a los identificadores únicos URI en formato hipermedia.

![HATEAOS](https://storage.cloudconvert.com/tasks/72af824f-97ba-4399-9fb4-594538acc784/4.png?AWSAccessKeyId=cloudconvert-production&Expires=1611853276&Signature=Au4nl9FbaaKEP90E6QouzgELjIU%3D&response-content-disposition=inline%3B%20filename%3D%224.png%22&response-content-type=image%2Fpng)

# Shaping Data

![Shaping Data](https://storage.cloudconvert.com/tasks/9ad4aec8-b070-444c-a790-74324c2d1277/3.png?AWSAccessKeyId=cloudconvert-production&Expires=1611853271&Signature=jVPgc4Da3T8DHyvcI5r8q7TVFGI%3D&response-content-disposition=inline%3B%20filename%3D%223.png%22&response-content-type=image%2Fpng)
