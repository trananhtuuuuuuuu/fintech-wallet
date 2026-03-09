public class FirstController
{
  
}


/*
docker run -d \
  --name wallet-web \
  -e POSTGRES_DB=wallet_db \
  -e POSTGRES_USER=postgres \
  -e POSTGRES_PASSWORD=123456 \
  -p 5500:5432 \
  -v wallet-data:/var/lib/postgresql/data \
  postgres:16
*/