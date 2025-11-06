# ⚡ Minimal API Deep Dive

A practical project built with **ASP.NET Core Minimal API** to explore and apply real-world REST concepts — including HTTP methods, status codes, content negotiation, pagination, file handling, redirection, and custom middleware — all implemented through lightweight **endpoint mappings** instead of controllers.

---

## 🚀 Project Overview

This project demonstrates how to design and structure a **RESTful API using Minimal APIs** in .NET.  
It simulates an in-memory `ProductRepository` with related `ProductReview` data, showing how to implement routes, validation, and layered architecture **without using MVC Controllers**.

All endpoints are grouped inside `ProductEndpoints`, following clean modularization practices using `IEndpointRouteBuilder` extensions.

---

## 🧩 Features

✅ Full CRUD for `Product` using `MapGet`, `MapPost`, `MapPut`, `MapPatch`, and `MapDelete`  
✅ Nested routes for `ProductReview`  
✅ Proper handling of HTTP methods (GET, POST, PUT, PATCH, DELETE, OPTIONS, HEAD)  
✅ Pagination and filtering using query parameters  
✅ Proper use of HTTP status codes (`200`, `201`, `204`, `400`, `404`, `409`, `500`, etc.)  
✅ File upload & download (with MIME type support)  
✅ CSV export using `Results.File()` and `Results.PhysicalFile()`  
✅ Temporary & permanent redirects with `Results.Redirect()`  
✅ `Accepted (202)` async process simulation  
✅ Endpoint grouping via extension methods for maintainability  

---

## 📦 Technologies

- **.NET 9 / ASP.NET Core Minimal API**
- **C#**
- **In-memory Repository Pattern**
- **JSON Patch**
- **Results API (Typed and Untyped)**
- **IResult-based responses**

---

## 🧪 Testing with `.http` Files

The project includes a `.http` file to **simulate and trace HTTP requests** directly from **Visual Studio** or **VS Code**.

You can use it to test endpoints, view responses, and understand how each request flows through the **Minimal API pipeline**.

---
### 🧾 Example: `.http`

### Get paged products
GET {{baseUrl}}/api/products?page=1&pageSize=5

---


## 📁 Project Structure


```text
MinimalApiDeepDive/
│
├── Endpoints/
│   └── ProductEndpoints.cs
│
│
├── Models/
│   ├── Product.cs
│   ├── ProductReview.cs
│   │
│   ├── Requests/
│   │   ├── CreateProductRequest.cs
│   │   ├── UpdateProductRequest.cs
│   │   └── CreateProductReviewRequest.cs
│   │
│   └── Responses/
│       ├── ProductResponse.cs
│       ├── ProductReviewResponse.cs
│       └── PagedResult.cs
│
├── Repositories/
│   └── ProductRepository.cs
│
└── Program.cs

