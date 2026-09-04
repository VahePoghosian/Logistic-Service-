# Logistic Service 🚚

<div align="left">
  <img src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" alt=".NET" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Entity_Framework-0078D4?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="Entity Framework" />
  <img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white" alt="Docker" />
</div>

<br>

> A robust **Backend Web API** built with modern C# and .NET Core technologies, designed to streamline and manage logistics, shipments, and supply chain operations.

## 📖 About The Project

**Logistic-Service** is a scalable backend application tailored for the logistics industry. It provides the core infrastructure needed to manage delivery fleets, track shipment statuses in real-time, and handle complex relational data using **Entity Framework Core**. Designed with clean architecture principles, this service is ready to be integrated into larger enterprise systems or microservice architectures.

### ✨ Key Features
*   **Shipment Management:** Full CRUD operations for creating, updating, and tracking cargo and deliveries.
*   **Status Tracking:** Real-time endpoint updates for shipment lifecycle (e.g., *Pending, In Transit, Delivered*).
*   **Relational Data Integrity:** Built on Entity Framework Core to manage complex relationships between vehicles, routes, and shipments.
*   **RESTful Architecture:** Clean, well-documented, and standard HTTP API endpoints.
*   **Containerized Ready:** Fully equipped with Docker support for isolated and consistent deployment environments.

---

## 🚀 Getting Started

Follow these instructions to configure and run the logistics service on your local development machine.

### Prerequisites

*   [.NET 8.0 SDK](https://dotnet.microsoft.com/download) (or your targeted version)
*   SQL Server (or your preferred relational database)
*   [Docker Desktop](https://www.docker.com/products/docker-desktop) *(optional, for containerized execution)*

### Installation

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/VahePoghosian/Logistic-Service-.git](https://github.com/VahePoghosian/Logistic-Service-.git)
    cd Logistic-Service-
    ```

2.  **Configure the Database Connection:**
    Open the `appsettings.json` file and update your SQL connection string:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER;Database=LogisticDb;Trusted_Connection=True;TrustServerCertificate=True;"
    }
    ```

3.  **Apply Entity Framework Migrations:**
    ```bash
    dotnet ef database update
    ```

4.  **Run the application:**
    ```bash
    dotnet run
    ```
    *The API documentation (Swagger) will typically be available at `https://localhost:5001/swagger`.*

---

## 📡 API Endpoints (Example)

Below is an overview of standard operations handled by this service. *(Adjust these to match your actual implementation).*

| HTTP Method | Endpoint | Description |
| :--- | :--- | :--- |
| `GET` | `/api/shipments` | Retrieves a list of all active shipments |
| `GET` | `/api/shipments/{id}` | Retrieves detailed tracking info for a specific shipment |
| `POST` | `/api/shipments` | Registers a new shipment into the system |
| `PUT` | `/api/shipments/{id}/status`| Updates the current status (e.g., to *In Transit*) |
| `GET` | `/api/fleet` | Retrieves all available delivery vehicles |

---

## 🐳 Docker Deployment

To spin up the service in an isolated container, run the following Docker commands:

```bash
# Build the image
docker build -t logistic-service .

# Run the container
docker run -d -p 8080:80 --name my-logistic-api logistic-service
