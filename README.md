# Survey and voting system

## Software requirement specification

Documentation about the functionality of the system:
https://docs.google.com/document/d/1DcqqZb902GnhSwpJ06fGiHFjB6X8TfoROY0YA3XtJBs/edit

## Installation and execution

- ```git clone <url-repo>```
- ```cd project-name```
- ```cp .env.example .env``` # Edit ```.env``` with your values
- ```docker-compose up --build```
- ```dotnet restore ```
- ```dotnet ef database update```