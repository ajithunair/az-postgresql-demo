# Azure PostgreSQL API

A production-style ASP.NET Core 8 Web API demonstrating modern cloud-native development practices using Azure, PostgreSQL, Docker, Identity, JWT Authentication, CI/CD, and Azure Key Vault.

## Overview

This project showcases the design, development, containerization, deployment, and secure operation of a RESTful API built with ASP.NET Core 8 and PostgreSQL.

The application implements authentication and authorization using ASP.NET Identity and JWT Bearer Tokens, follows modern API development practices, and is deployed to Microsoft Azure using a fully automated CI/CD pipeline.

---

## Key Features

### Authentication & Authorization

* ASP.NET Core Identity
* JWT Bearer Authentication
* Role-Based Authorization
* Secure password hashing and token generation

### Data Management

* Entity Framework Core 8
* PostgreSQL Database
* EF Core Migrations
* Repository-friendly architecture

### API Features

* RESTful API Design
* Pagination
* Filtering
* Sorting
* Swagger / OpenAPI Documentation

### Security

* Azure Key Vault integration
* Secure secret management
* JWT secret stored outside source control
* Database connection strings stored securely
* Environment-based configuration

### Containerization

* Dockerized ASP.NET Core API
* Multi-stage Docker builds
* Docker Compose local development environment
* PostgreSQL containerized for development

### Cloud Deployment

* Azure App Service (Linux Container)
* Azure Container Registry (ACR)
* Azure Database for PostgreSQL Flexible Server
* Azure Key Vault

### DevOps

* Azure DevOps Repositories
* Azure Pipelines CI/CD
* Automated Build & Deployment
* Docker Image Versioning
* Build Metadata Injection

---

## Architecture

```text
Developer
    │
    ▼
Azure DevOps Repository
    │
    ▼
Azure Pipeline
    │
    ├── Build
    ├── Test
    ├── Docker Build
    └── Push Image
    │
    ▼
Azure Container Registry
    │
    ▼
Azure App Service (Linux Container)
    │
    ▼
ASP.NET Core 8 API
    │
    ├── Azure Key Vault
    │       ├── JWT Secret
    │       ├── Database Connection String
    │       └── API Keys
    │
    ▼
Azure Database for PostgreSQL
```

---

## Technology Stack

| Category           | Technology               |
| ------------------ | ------------------------ |
| Backend            | ASP.NET Core 8           |
| Language           | C#                       |
| ORM                | Entity Framework Core 8  |
| Database           | PostgreSQL               |
| Authentication     | ASP.NET Identity + JWT   |
| Containerization   | Docker                   |
| Local Development  | Docker Compose           |
| Cloud Platform     | Microsoft Azure          |
| Container Registry | Azure Container Registry |
| Hosting            | Azure App Service        |
| Secrets Management | Azure Key Vault          |
| CI/CD              | Azure DevOps Pipelines   |
| Documentation      | Swagger / OpenAPI        |

---

## Local Development

### Prerequisites

* .NET 8 SDK
* Docker Desktop
* PostgreSQL (optional)

### Run with Docker Compose

```bash
docker compose up --build
```

### Run API

```bash
dotnet run
```

---

## Security Considerations

This project follows secure cloud development practices:

* Secrets are stored in Azure Key Vault
* No production secrets are committed to source control
* JWT signing keys are externally managed
* Database credentials are secured using Azure-managed services
* Environment-specific configuration is supported

---

## CI/CD Pipeline

The deployment pipeline automatically:

1. Builds the ASP.NET Core application
2. Runs validation checks
3. Builds Docker images
4. Pushes images to Azure Container Registry
5. Deploys the latest image to Azure App Service

This enables repeatable and automated deployments directly from source control.

---

## Future Enhancements

* Refresh Token Support
* Application Insights Monitoring
* Health Checks
* Serilog Structured Logging
* Terraform / Bicep Infrastructure as Code
* Integration Testing
* Kubernetes Deployment

---

## Author

Ajith Nair

Cloud-Native .NET Developer | Azure | Docker | PostgreSQL | DevOps
