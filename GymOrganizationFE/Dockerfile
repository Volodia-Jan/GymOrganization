FROM node:20.9.0 AS build
WORKDIR /app

COPY package.json package-lock.json ./
RUN npm install

COPY . ./
RUN npm run build

FROM nginx:alpine
COPY --from=build /app/dist/your-app-name /usr/share/nginx/html
