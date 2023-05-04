# BlazorServerTemplate

## Features

- Swagger UI configured for easy API documentation and testing.
- Sample Model class and controllers are provided, all organized in appropriate folders.

## Setup Instructions


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

## Screenshots

### Dashboard
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236243525-404bb84a-e7eb-41b8-aa00-1a5d9307ae1c.png">

### Swagger
<img width="1512" alt="Swagger UI" src="https://user-images.githubusercontent.com/32345320/236243073-e5987a36-dd5e-4429-9c60-9a7d42c1d35b.png">

### Counter and reactive elements
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236243683-ba1b5801-424e-40ea-9a61-21a611fd3f70.png">

### Nested Child Layouts with switching output content. Demo showing for loops in HTML
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236243640-b1ffcd32-ff9b-465e-957b-944fbe76846e.png">

### Showing data fetching, in-line editing and deletion
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236244183-bf05f97a-bb24-4fc1-b9f0-31e9f3b00c49.png">

### Creation of new data
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236244372-8b391579-269c-42d8-a81e-34b048c078c0.png">

### Configured page to upload files to blob storage
<img width="1510" alt="image" src="https://user-images.githubusercontent.com/32345320/236244449-bbccabd2-9e38-481d-b5e2-2657ffe1b5f4.png">

### Showing data fetching from a service. Data hidden because role-based authorization is shown
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236244594-4556d7ae-37c8-45db-aa71-36bd7acb5e81.png">

### Create, manage and delete roles
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236244721-eba02f3e-8c42-439e-b29f-cbf62ce05b0d.png">

### Manage your account. Example showing custom identity class (age property is added)
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236244853-3a22b4bf-31d1-4cbb-9ea6-5b07fdbd9b9f.png">

### Change your email
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236245018-20277f77-7554-4cc0-a729-72e4c3ce5fc9.png">

### Change your password
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236245051-1546128b-5fad-4bee-80dc-e8cb144009e8.png">

### App configured to work with external logins. Only API keys are required to be filled in using secret manager
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236245187-b4e240c8-d8c4-46dd-bc76-e99fc80e7f96.png">

### Two factor authentication is set up and ready to use with QR code generation also ready
<img width="1507" alt="image" src="https://user-images.githubusercontent.com/32345320/236245394-0e9de166-5101-4165-a16b-0da3033dc497.png">

### Ability to download and delete data
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236245468-f5f5aaae-3215-49db-8105-184d32e93244.png">
