docker build -t debug-net-containers --file Dockerfile-dev .

docker run --name debug-net-containers -d debug-net-containers 