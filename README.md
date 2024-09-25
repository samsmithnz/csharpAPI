# csharpAPI

## Overview

This repository contains a .NET C# WebAPI that provides public holiday information for a given country. The WebAPI accepts a country as input and returns a list of public holidays for that country.

## How to Use

1. Clone the repository:
   ```
   git clone https://github.com/samsmithnz/csharpAPI.git
   cd csharpAPI
   ```

2. Open the solution in Visual Studio:
   ```
   csharpAPI.sln
   ```

3. Build the solution.

4. Run the WebAPI.

5. Use a tool like Postman or cURL to make a GET request to the following endpoint:
   ```
   GET /api/publicholidays/{country}
   ```

   Replace `{country}` with the name of the country you want to get public holidays for.

## Example

To get public holidays for the United States, make a GET request to:
```
GET /api/publicholidays/UnitedStates
```

The response will be a JSON array containing the public holidays for the specified country.

## Dependencies

- .NET Core 3.1 or later
- Visual Studio 2019 or later

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
