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

![Validation Model](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/50dc05d0-fd4d-45c2-b4ae-88985b56a320/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAT73L2G45O3KS52Y5%2F20210120%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20210120T161219Z&X-Amz-Expires=86400&X-Amz-Signature=8ecf03fe4823d6e7770ece5e25b434ae7486697449b312b9ce05db8590ab3fe7&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22)

# Supporting Concurrency

![Supporting Concurrency](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/1b715481-697d-4481-a44b-8203700d774e/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAT73L2G45O3KS52Y5%2F20210120%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20210120T161316Z&X-Amz-Expires=86400&X-Amz-Signature=788fe7137799f28df4fdf1aaa49470c9577791368a29d93e466981ec0a29c1ee&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22)

# HATEAOS
Ofrecer una interfaz universal. El cliente pueda moverse por la aplicación web únicamente siguiendo a los identificadores únicos URI en formato hipermedia.

![HATEAOS](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/34e93eff-1e47-48a8-95eb-0ced0d1e4e91/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAT73L2G45O3KS52Y5%2F20210120%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20210120T161449Z&X-Amz-Expires=86400&X-Amz-Signature=f43b0fe34a9fde29cf4baee191fff7204c28cca760144b4aaf85307804f620d7&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22)

# Shaping Data

![Shaping Data](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/4717bc8f-4b64-4643-a30e-e1cf5c9321d1/Untitled.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAT73L2G45O3KS52Y5%2F20210120%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20210120T161959Z&X-Amz-Expires=86400&X-Amz-Signature=b5643f9d82a6e17d41dd2c32c60c28d2d90a219bb067750faa6163a1420b1886&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Untitled.png%22)
