# ITLab
Laboratory managing system

### Default user
* login: `admin`
* password: `Pa$$word1243`


## Run system locally from Docker images
Requirements

- Docker

1. Pull services images
```bash
docker-compose pull
```
2. Run services
```bash
docker-compose up
```


## Run development environment
Requirements

- .Net Core 3.1
- Node.js 12.18.2+
- Go 1.12+
- JDK 11+
- Docker


1. Build all services
```
.\build.ps1
or
./build.sh
```
2. Build docker images
```bash
docker-compose build
```
3. Run services
```bash
docker-compose up -d
```
General site will be available on [http://127.0.0.1.xip.io:5500](http://127.0.0.1.xip.io:5500)
> Default user: email="`admin@test.com`" password="`password`"
## Architecture
### Current
![Architecture (current)](docs/img/CurrentArchitecture.png)
### To be
![Architecture (to be)](docs/img/ToBeArchitecture.png)
