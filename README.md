# BlazorServerTemplate

## Features

- Swagger UI configured for easy API documentation and testing.
- Sample Model class and controllers are provided, all organized in appropriate folders.

## Screenshots
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236243525-404bb84a-e7eb-41b8-aa00-1a5d9307ae1c.png">
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236243683-ba1b5801-424e-40ea-9a61-21a611fd3f70.png">
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236243640-b1ffcd32-ff9b-465e-957b-944fbe76846e.png">
<img width="1512" alt="Swagger UI" src="https://user-images.githubusercontent.com/32345320/236243073-e5987a36-dd5e-4429-9c60-9a7d42c1d35b.png">


[Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-7.0)
dotnet user-secrets set "Authentication:Google:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Google:ClientSecret" "<client-secret>"

[Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins?view=aspnetcore-7.0)
dotnet user-secrets set "Authentication:Facebook:AppId" "<app-id>"
dotnet user-secrets set "Authentication:Facebook:AppSecret" "<app-secret>"

[Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-7.0)
dotnet user-secrets set "Authentication:Microsoft:ClientId" "<client-id>"
dotnet user-secrets set "Authentication:Microsoft:ClientSecret" "<client-secret>"

[Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/twitter-logins?view=aspnetcore-7.0).
dotnet user-secrets set "Authentication:Twitter:ConsumerAPIKey" "<consumer-api-key>"
dotnet user-secrets set "Authentication:Twitter:ConsumerSecret" "<consumer-secret>"

[Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-7.0&tabs=visual-studio).
dotnet user-secrets set "SendGridKey" "<key>"
