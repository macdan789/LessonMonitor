**Docker** - is a containerization platform, meaning that it enables you to package your applications into images and run them as "containers" on any platform that can run Docker.

In scope of OOP paradigme: **images** are like *classes* and **containers** like *instances of classes*.

1. Create Dockerfile for our application
2. Procces Dockerfile through Docker Engine, which will build Docker Image based on our file
3. Take our finished Docker Image

Now we can create multiple Docker Containers for our Image on different OS.

**.dockerignore** - tells Docker Engine which certain files ignore while building Docker Image (for example: bin/ obj/ folders)

To build docker image run (flag -t = tag or name for our image):
`docker build -t docker_accout_id/app_name:version .`

usefull docs: https://docs.docker.com/samples/dotnetcore/

usefull commands:
1. `docker images` = list images on your machine
2. `docker ps (-a)` = list containers on your machine
3. `docker run (flag -p for port mapping) (flag -d = run container in detached mode, in background) name_of_image` = run container based on some image
4. `docker stop container_id` = stop running container
5. `docker rm/rmi` = rm - remove containers, rmi - remove images
6. `docker push/pull` = push/pull images to from docker hub

![Ways of project infrastructure](/docker-theory/one.jpg "Ways of project infrastructure")

![From dockerfile to docker image](/docker-theory/two.jpg "From dockerfile to docker image")