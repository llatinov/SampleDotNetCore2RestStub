# SampleDotNetCore2RestStub #

Code examples for following posts:

* <a href="http://automationrhapsody.com/build-a-rest-api-with-net-core-2-and-run-it-on-docker-linux-container/">Build a REST API with .NET Core 2 and run it on Docker Linux container</a>
* <a href="https://automationrhapsody.com/net-core-integration-testing-mock-dependencies/">.NET Core integration testing and mock dependencies</a>
* <a href="https://automationrhapsody.com/code-coverage-net-core-unit-tests-opencover/">Code coverage of .NET Core unit tests with OpenCover</a>
* <a href="https://automationrhapsody.com/net-core-code-coverage-linux-minicover/">.NET Core code coverage on Linux with MiniCover</a>

## Build ##
* Install <a href="https://www.microsoft.com/net/download/windows" target="_blank">.NET Core SDK</a>
* Open cmd.exe and navigate to project's folder.
* Build project with following command

`dotnet build`

## Run ##
Run project with following command

`dotnet run`

## Functionalities ##

There are several functionalities implemented in the stub. See linked posts for more details how to use them.

### Persons ###

Database where you can add, get or remove persons with JSON showing RESTful web services functionality described in blog post. GET endpoints are: http://localhost:5000/person/all, http://localhost:5000/person/get/{id}, http://localhost:5000/person/remove. POST endpoint is: http://localhost:5000/person/save.

### Version ###

http://localhost:5000/api/version returns a configuration value that is read from external config file.

### Secure Persons ###

http://localhost:5000/secure/person/all with Authorization header
