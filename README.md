# Country Details API

This is a simple web API built using **ASP.NET Core 8.0** that provides information about countries and their mobile operators based on phone numbers.

## Features
- Accepts a phone number and detects the country code.
- Returns country details, including name, ISO code, and mobile operators.
- Uses an in-memory database for demonstration purposes.

## Technologies Used
- **Framework**: ASP.NET Core 8.0
- **Dependency Injection**: Built-in DI for managing services and repositories.
- **Swagger/OpenAPI**: For API documentation and testing.

## Setup Instructions

### Prerequisites
- Install [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0).
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

### Steps to Run the Application
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository.git
   ```
   ```bash
   cd your-repository
   ```
2. Restore the dependencies:
    ```bash
    dotnet restore
    ```
3. Run the application:
    ```bash
    dotnet run
    ```
4. Open your browser and navigate to:
    http://localhost:5022/swagger/index.html

**API Endpoints**
| **Method** | **Endpoint** | **Description**
| --- | --- | --- |
| GET| /api/Country?phoneNumber={phoneNumber} | Detects country and returns details based on phone number. |

**Example API Request**

**Request**
```bash
GET https://localhost:5022/api/Country?phoneNumber=2348033432323
```
**Response**

{
  "number": "2348033432323",
  "country": {
    "countryCode": "234",
    "name": "Nigeria",
    "countryIso": "NG",
    "countryDetails": [
      {
        "operator": "Airtel Nigeria",
        "operatorCode": "ANG"
        },
        {
        "operator": "MTN Nigeria",
        "operatorCode": "MTN NG"
        },
        {
        "operator": "9Mobile Nigeria",
        "operatorCode": "ETN"
        },
        {
        "operator": "Globacom Nigeria",
        "operatorCode": "GLO NG"
      }
    ]
  }
}


