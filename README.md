# 🍔 FoodAppAPI

A RESTful Web API built using **ASP.NET Core** that allows users to manage food items with **secure JWT-based authentication**.
This project demonstrates backend development concepts including **Entity Framework Core, Dependency Injection, Middleware, and Authentication**.

---

## 🚀 Features

* ✅ CRUD operations for Food items (Create, Read, Update, Delete)
* 🔐 JWT Authentication & Authorization
* 🗄️ Database integration using Entity Framework Core
* 🔄 Middleware-based request pipeline
* ⚙️ Dependency Injection for clean architecture
* 📡 RESTful API design with proper HTTP methods
* 📄 Swagger UI for API testing

---

## 🛠️ Tech Stack

* **Backend:** ASP.NET Core Web API
* **Language:** C#
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **Authentication:** JWT (JSON Web Token)
* **Tools:** Swagger / Postman

---

## 📂 Project Structure

```
FoodAppAPI/
│
├── Controllers/      → Handles API requests
├── Models/           → Defines data entities
├── Data/             → DbContext & DB configuration
├── Program.cs        → Middleware & service configuration
├── appsettings.json  → Configuration (Connection strings, JWT)
```

---

## 🔐 Authentication (JWT)

This API uses **JWT (JSON Web Token)** for secure authentication.

### 🔁 Authentication Flow

1. User logs in with credentials
2. Server validates user
3. Server generates JWT token
4. Client stores token
5. Client sends token in header:

   ```
   Authorization: Bearer <token>
   ```
6. Middleware validates token before allowing access

---

## 📡 API Endpoints

### 🟢 Food Endpoints

| Method | Endpoint       | Description        |
| ------ | -------------- | ------------------ |
| GET    | /api/food      | Get all food items |
| GET    | /api/food/{id} | Get food by ID     |
| POST   | /api/food      | Add new food       |
| PUT    | /api/food/{id} | Update food        |
| DELETE | /api/food/{id} | Delete food        |

---

## 🔁 API Flow (Internal Working)

1. Client sends HTTP request
2. Request passes through middleware pipeline
3. Routing maps request to controller
4. Controller uses **DbContext (via DI)**
5. Entity Framework Core executes SQL query
6. Database returns data
7. Response sent back as JSON

---

## ⚙️ How to Run the Project

1. Clone the repository:

   ```
   git clone https://github.com/jagadeeshkumar1023/FoodAppAPI.git
   ```

2. Open in Visual Studio / VS Code

3. Update connection string in `appsettings.json`

4. Run migrations:

   ```
   Add-Migration InitialCreate
   Update-Database
   ```

5. Run the project

6. Open Swagger:

   ```
   https://localhost:<port>/swagger
   ```

---

## 🧪 Sample Request & Response

### Request (POST /api/food)

```json
{
  "name": "Burger",
  "price": 120
}
```

### Response

```json
{
  "id": 1,
  "name": "Burger",
  "price": 120
}
```

---

## 🧠 Key Concepts Implemented

* Dependency Injection (DI)
* Middleware Pipeline
* Entity Framework Core (ORM)
* JWT Authentication & Authorization
* REST API Design Principles
* Model Binding & Validation

---

## 📌 Future Improvements

* Add Service Layer (Separation of concerns)
* Implement DTOs (Data Transfer Objects)
* Add Global Exception Handling
* Integrate Logging (Serilog / NLog)
* Add Role-based Authorization

---

## 👨‍💻 Author

**Jagadeesh Kumar**

---

## ⭐ Notes

This project is built for learning and demonstrating backend development skills using ASP.NET Core Web API.
