# Securing Microservices with IdentityServer4, OAuth2 and OpenID.

In this repository, you will see that how to secure microservices with using **standalone Identity Server 4** and backing with **Ocelot API Gateway**. And API applications with using **OAuth 2 and OpenID Connect** in IdentityServer4.

![Overall Picture of Repository](https://user-images.githubusercontent.com/1147445/97865027-991b7200-1d1a-11eb-927e-3f5580a7f5b5.png)

### Movies.API
First of all, we are going to develop **Movies.API** project and protect this API resources with **IdentityServer4 OAuth 2.0 implementation**. Generate **JWT Token** with client_credentials from IdentityServer4 and will use this token for securing Movies.API protected resources.

### Identity Server
Also, we are going to develop centralized standalone **Authentication Server** and **Identity Provider** with implementing IdentityServer4 package and the name of microservice is Identity Server.
Identity Server4 is an open source framework which implements **OpenId Connect and OAuth2 protocols** for .Net Core.
With Identity Server, we can provide authentication and access control for our web applications or Web APIs from a single point between applications or on a user basis.

### Ocelot API Gateway
Lastly, we are going to develop **Ocelot API Gateway** and make secure protected API resources over the Ocelot API Gateway with transferring **JWT web tokens**.
Once the client has a bearer token it will call the API endpoint which is fronted by Ocelot. Ocelot is working as a reverse proxy.
After Ocelot reroutes the request to the internal API, it will present the token to Identity Server in the **authorization pipeline**. If the client is authorized the request will be processed and a list of movies will be sent back to the client.

Also over these picture, we have also apply the **claim based authentications**.
