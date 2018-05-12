
docker build -t webapi-dev . -f .\SkiaSharpWebApi\Dockerfile

docker run --rm -p 80:80 webapi-dev
