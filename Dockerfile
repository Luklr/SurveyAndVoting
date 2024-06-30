FROM postgres:13

# Puedes configurar variables de entorno aqu� o en el docker-compose.yml
ENV POSTGRES_DB=survey_and_voting
ENV POSTGRES_USER=admin
ENV POSTGRES_PASSWORD=admin

# Copia un archivo SQL de inicializaci�n si lo necesitas
# COPY init.sql /docker-entrypoint-initdb.d/

# Exponemos el puerto 5432
EXPOSE 5432