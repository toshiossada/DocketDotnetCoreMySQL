# DocketDotnetCoreMySQL
Para executar os containers executar os comandos no Docker CLI
    docker build -f .\Dockerfile.multi -t multi_mvc .
    docker-compose -f docker-compose-dev.yml -p dev up -d
Para Destruir os containers executar o comando abiaxo no Docker Cli
    docker-compose -f docker-compose-dev.yml -p dev down -v