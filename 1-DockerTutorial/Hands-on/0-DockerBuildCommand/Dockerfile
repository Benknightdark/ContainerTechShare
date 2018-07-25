FROM nginx:alpine as BaseImage

RUN rm -rf /usr/share/nginx/html/*
COPY default.conf /etc/nginx/conf.d/default.conf
COPY  /dist/DockerNG /usr/share/nginx/html
EXPOSE  80
