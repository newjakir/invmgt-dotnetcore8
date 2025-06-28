# Inventory Management (.NET Core 8 + MySQL)

This is a sample Inventory Management Web Application built with ASP.NET Core 8 (MVC), Entity Framework Core, and MySQL.

---

## 🚀 Getting Started

### 🧾 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- MySQL Server installed and running
- Git installed

---

### 📥 Clone the Repository

```bash
git clone https://github.com/newjakir/invmgt-dotnetcore8.git
cd invmgt-dotnetcore8
```

---

### 🔧 Install EF Core CLI Tool

```bash
dotnet tool install --global dotnet-ef
```

If needed, add the tool path to your shell profile (macOS/Linux):

```bash
export PATH="$PATH:$HOME/.dotnet/tools"
```

---

### 📦 Install Required NuGet Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.13
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.13
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.3
```

---

### ⚙️ Configure MySQL Connection

Update the `appsettings.json` file with your MySQL credentials:

```json
"ConnectionStrings": {
  "Default": "server=localhost;port=3306;database=inv_mgt_db;user=dotnetuser;password=YourPassword123!"
}
```

---

### 🛠️ Run EF Core Migrations

1. **Create initial schema:**

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

2. **Add seed data (optional):**

```bash
dotnet ef migrations add SeedProducts
dotnet ef database update
```

---

### ▶️ Run the Project

```bash
dotnet run
```

By default, the app runs at:

- http://localhost:5201

Open the URL http://localhost:5201 in your browser to get HomePage.
Hit http://localhost:5201/api/products to get the project list.

---

## 🧾 Project Structure

```
InvMgt/
├── Controllers/
├── Models/
├── Views/
├── Data/ (AppDbContext)
├── Migrations/
├── appsettings.json
└── Program.cs
```

---

## ✅ Features

- ASP.NET Core 8 MVC architecture
- Entity Framework Core Code First
- MySQL database integration
- Seed sample product data

---

## 🧪 Tips

- If `dotnet ef` isn’t recognized, make sure `~/.dotnet/tools` is in your `PATH`.
- Use MySQL Workbench or DBeaver to visually browse your data.
- The seeded products will appear via any `ProductsController` endpoint you create.

---

## 📄 License

MIT © Md. Jakir Hossain
