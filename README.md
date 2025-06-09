# 📝 Todo List Web App with User Authentication

## 📚 Project Overview

This project is a **To-Do List Web Application** built using **ASP.NET Core Razor Pages**, **Entity Framework Core with SQLite**, and **ASP.NET Identity**. The primary goal is to **learn and practice** the following:

- **User Registration** and **User Sign-In**
- **User Sessions & Authentication**
- **Entity Framework Core** integration
- **Managing relational data** (users and their tasks)
- **CRUD operations** for To-Do items
- **ASP.NET Identity customisation**

This project focuses on building a full-stack web application where users can manage personal tasks in a secure, user-specific environment.

---

## ✅ Feature Checklist (Learning Goals & Steps)

### ✅ Initial Setup
- [x] Create ASP.NET Core Web Application using Razor Pages
- [x] Add SQLite and Entity Framework Core NuGet packages
- [x] Configure `AppDbContext` and register it with DI in `Program.cs`
- [x] Set up connection string for SQLite in `appsettings.json`

### ✅ Identity Setup
- [x] Install and configure ASP.NET Identity
- [x] Register Identity services with EF Core
- [x] Add authentication and authorisation middleware
- [x] Create **Register** Razor Page
- [x] Create and validate a `RegisterModel`
- [x] Handle user creation and sign-in after registration
- [ ] Create custom **Login** Razor Page
- [ ] Handle authentication and redirect on success/failure
- [ ] Add logout functionality with session clearing

### ✅ To-Do Item Management (CRUD)
- [ ] Create `ToDoModel` with fields:
  - Title
  - Description
  - CreatedDate
  - DueDate
  - Status (ToDo / In Progress / Completed)
  - UserId (FK to IdentityUser)
- [ ] Create Razor Pages for:
  - [ ] Listing all tasks
  - [ ] Creating a new task
  - [ ] Editing an existing task
  - [ ] Deleting a task
- [ ] Use `[Authorise]` attributes to protect task pages
- [ ] Ensure users only see their own tasks

### ✅ UI & UX Enhancements
- [ ] Add navigation and layout partials
- [ ] Add `_LoginPartial.cshtml` to conditionally show login/logout links
- [ ] Style the app using CSS or Tailwind (optional)
- [ ] Show task status with colors or labels

### ✅ Extras (Optional Learning Goals)
- [ ] Add Email confirmation (via fake SMTP or SendGrid for example)
- [ ] Add password reset flow
- [ ] Allow profile updates (phone, email)
- [ ] Support task priority (Low / Medium / High)
