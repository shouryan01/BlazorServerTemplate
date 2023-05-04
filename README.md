# BlazorServerTemplate

## Features

- Animated Splash Screen
- Third-party service to log in (Facebook, Twitter, Google, Microsoft)
- Email Verification Service
- Auto-navigate to sign in/log in page if not authenticated from home screen
- Swagger UI configured for easy API documentation and testing
- Counter and reactive variable
- Nested child layouts with conditional output component
- Sample Model class and controllers (GET, POST, PUT, DELETE) are provided, all organized in appropriate folders and corresponding UI element
- File upload to blob storage is configured
- Role-based authorization is provdided with a GUI implementation to manage roles

## Setup Instructions

- [Download and install .NET framework](https://dotnet.microsoft.com/en-us/download). This will also install the .NET Cli.
- To run the development server enter "dotnet watch" in the terminal. This option is for cross-platform development using VS Code. Alternatively, you can also click the .sln file included to open the project in Visual Studio. This also works for both Mac and Windows but the preferred method for cross-platform development is VS Code with the .NET Cli.

Here are setup instructions for login providers:

- [Google Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/google-logins?view=aspnetcore-7.0)
    - dotnet user-secrets set "Authentication:Google:ClientId" "client-id"
    - dotnet user-secrets set "Authentication:Google:ClientSecret" "client-secret"

- [Facebook Setup Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins?view=aspnetcore-7.0)
    - dotnet user-secrets set "Authentication:Facebook:AppId" "app-id"
    - dotnet user-secrets set "Authentication:Facebook:AppSecret" "app-secret"

- [Microsoft Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/microsoft-logins?view=aspnetcore-7.0)
    - dotnet user-secrets set "Authentication:Microsoft:ClientId" "client-id"
    - dotnet user-secrets set "Authentication:Microsoft:ClientSecret" "client-secret"

- [Twitter Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/social/twitter-logins?view=aspnetcore-7.0).
    - dotnet user-secrets set "Authentication:Twitter:ConsumerAPIKey" "consumer-api-key"
    - dotnet user-secrets set "Authentication:Twitter:ConsumerSecret" "consumer-secret"

- [Twilio Sendgrid Instructions](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/accconfirm?view=aspnetcore-7.0&tabs=visual-studio).
    - dotnet user-secrets set "SendGridKey" "key"

## Project Instructions 

- You will need to rename the project from BlazorServerTemplate to one of your own choosing. You can easily do this by using the built-in tool to refactor all occurances of a symbol. Make sure this also updates the namespaces of all the files as well.
- You will need to change the splash screen to something else of your choosing.
- If you do not plan on using the external login providers, please comment them out in Program.cs
- The custom user class is located in BlazorServerTemplate.Data and is titled BlazorUser. It includes additional fields such as Age and Address, which are both optional. When you register as a new user, you are prompted to enter your age. This is something else that you should customize as per the requirements of your app.
- To change the registration fields and/or the fields in the account management page, you need to edit Index.cshtml and Index.cshtml.cs in Areas/Identity/Pages/Account/Manage and Register.cshtml and Register.cshtml.cs in Areas/Identity/Pages/Account
- BlazorServerTemplate.Shared contains the NavMenu.razor file, which is how the sidebar links are rendered.
- To find the files for the pages themselves, look in the BlazorServerTemplate.Pages folder.
- You can visit "/swagger" to access swagger for your APIs.
- "/counter" will show you how to use reactive elements and variables
- "child-layout-example" will show you how to use child elements and conditionally rendered outlets
    - Page 1 will show you how to use for loops in HTML
    - Page 2 will show you how to fetch data from the database and render it in a table, along with edit and delete functionalities.
    - Page 3 will allow you to POST data to the database.
- "/upload-to-blob-storage" shows you a demo of how you can upload files to blob storage. Of course, you will need to supply it with your own blob storage connection string.
- Speaking of which, to change database providers from SqlLite to use SqlServer, just provide the connection string in appsettings.json and uncomment the lines from Program.cs
- "/manage-roles" shows you how to have role-based authorization. You can create, assign and delete roles from here. "/fetchdata" has an example of this in action.
- Two factor authentication has been set up. Simply scan the QR code from the account page.
- Areas/Identity contains the files from scaffolding identity.
- The Data folder contains the Controllers, Models, Migrations and Services folders as well as the ApplicationDbContext file.
- Pages are in the "Pages" folder. "Shared" contains the layouts for pages.

## Screenshots

### Animated Splash Screen
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236258134-4a1aa03a-bb08-4501-b693-37d0061b015b.png">

### Log In Screen
<img width="1510" alt="image" src="https://user-images.githubusercontent.com/32345320/236258391-5a5918d6-b1d5-43dd-bc54-a0667d3a39f7.png">

### Register Screen
<img width="1512" alt="image" src="https://user-images.githubusercontent.com/32345320/236258663-fae36d52-1579-41fd-82b1-d52f50aac18f.png">

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
