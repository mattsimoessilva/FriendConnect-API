# FriendConnect-API

## Description
FriendConnect-API is a RESTful API built with ASP.NET Core, designed to manage and connect friends. It provides endpoints for creating, retrieving, updating, and deleting 'Friend' resources. This API forms the backbone of the FriendConnect application, enabling users to manage their connections efficiently and effectively.

## Getting Started

### Prerequisites
- .NET Core 3.1 or later
- An IDE such as Visual Studio or VS Code

### Installation
1. Clone the repository
```bash
git clone https://github.com/username/FriendConnect-API.git
```
2. Navigate to the project directory
```bash
cd FriendConnect-API
```
3. Restore the packages
```bash
dotnet restore
```
4. Build the project
```bash
dotnet build
```
5. Run the project
```bash
dotnet run
```

## Usage
The API exposes the following endpoints:

- `GET /api/friend`: Retrieves a list of all friends.
- `GET /api/friend/{id}`: Retrieves a friend by ID.
- `POST /api/friend`: Creates a new friend.
- `PUT /api/friend/{id}`: Updates a friend by ID.
- `DELETE /api/friend/{id}`: Deletes a friend by ID.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
