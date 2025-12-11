🛍️ ASP.NET Core E-Commerce Project

This is a simple e-commerce web application built with **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite**.  
It includes product listing, product detail pages with image galleries, categories, sliders, and a basic e-commerce layout.

---

## 🛠️ Technologies Used
<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET_Core-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge&logo=.net&logoColor=white" />
  <img src="https://img.shields.io/badge/SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white" />
  <img src="https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white" />
  <img src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white" />
  <img src="https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white" />
</p>

---

✨ Features

📄 Product listing page

🖼️ Product detail page with image gallery

🧭 Category menu

🎞️ Homepage slider (ViewComponent)

🔁 Similar products section

💾 SQLite database with Entity Framework Core

---

## ⚙️ Installation & Setup

```
1️⃣ Install Dependencies
--------------------------------
dotnet restore



2️⃣ Create or Update the Database
--------------------------------
dotnet ef database update
# This creates the SQLite database (store.db) on your machine
# The database file is ignored via .gitignore
# Each developer must generate their own database locally



3️⃣ Run the Application
--------------------------------
dotnet run
# Then open the URL shown in terminal (example):
# https://localhost:xxxx
```

---

## 📁 Project Structure (Short Overview)

```
/Controllers
/Models
/Views
/ViewComponents
/Migrations
/wwwroot
appsettings.json
store.db (created locally)
```

## 🖼️ Screenshots

### 🏠 Homepage
<img src="screenshots/homepage.png" width="900"/>

### 📄 Product Detail Page
<img src="screenshots/product-detail.png" width="900"/>

### 📋 Product List Page
<img src="screenshots/product-list.png" width="900"/>

