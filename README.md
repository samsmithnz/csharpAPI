# csharpAPI

## Overview

This repository contains a .NET C# WebAPI that provides public holiday information for a given country. The WebAPI accepts a country and year as input and returns a list of public holidays for that country and year.

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
   GET /api/publicholidays/{country}/{year}
   ```

   Replace `{country}` with the name of the country and `{year}` with the year you want to get public holidays for.

## Example

To get public holidays for the United States in 2023, make a GET request to:
```
GET /api/publicholidays/UnitedStates/2023
```

The response will be a JSON array containing the public holidays for the specified country and year.

## Dependencies

- .NET 8 or later
- Visual Studio 2019 or later

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
