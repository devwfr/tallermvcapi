# Taller de MVC - API

**AES - PICA 2019**
Presentado por:  **Wilson Eduardo Forero Rocha**

Ejecutar: dotnet run
[https://localhost:5001/](https://localhost:5001/)

Credenciales de acceso en archivo **appsetting.json**

    "UsuarioAcceso":
     {
    "usuario": "test",
    "password": "1234"
      }

Endpoint ApiRest:
[https://localhost:5001/api/rest](https://localhost:5001/api/rest)

Request **Json**

    {
     "nombre": "Wilson",
     "direccion": "Chia",
     "telefono": "3212722217",
     "email": "forero-wilson@javeriana.edu.co"
    }

Request **xml**

    <Contacto
     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
     xmlns:xsd="http://www.w3.org/2001/XMLSchema">
	     <Nombre>Wilson</Nombre>
	     <Direccion>Chia</Direccion>
	     <Telefono>3212722217</Telefono>
	     <Email>forero-wilson@javeriana.edu.co</Email>
     </Contacto>


> **Nota:** Modificar headers.
