🛍️ ASP.NET Core E-Commerce Project

This is a simple e-commerce web application built with ASP.NET Core MVC and Entity Framework Core.
It includes product listing, product details with gallery, categories, slider component, and a basic e-commerce layout.

## 🛠️ Technologies Used

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![SQLite](https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)

---

✨ Features

📄 Product listing page

🖼️ Product detail page with image gallery

🧭 Category menu

🎞️ Homepage slider (ViewComponent)

🔁 Similar products section

💾 SQLite database with Entity Framework Core

⚙️ Installation & Setup

Follow the steps below to run the project on your local machine.


1️⃣ Install dependencies

dotnet restore

This command installs all required NuGet packages for the project.

2️⃣ Create / update the database

dotnet ef database update

This will create the SQLite database file (store.db) on your machine and apply all migrations automatically.

⚠️ Note:
The database file is not included in the repository because it is ignored via .gitignore.
Every developer must create their own local database using the command above.

3️⃣ Run the application

dotnet run

Then open the URL shown in the terminal (usually something like):

https://localhost:xxxx

📂 Project Structure (Short Overview)
/Controllers
/Models
/Views
/ViewComponents
/Migrations
/wwwroot
appsettings.json
store.db   (created locally)

---

📄 License

This project is free to use and modify for learning purposes.,/
