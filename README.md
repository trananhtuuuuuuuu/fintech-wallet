# fintech-wallet

## Entities
- User: Id, Name, account, password, refreshToken, email, phoneNumber
- Wallet: Id, amount
- TransferHistory: Id, Name, OriginalWallet, DestinationWallet, Amount, Date
- ManagementInfor: Id, Name, Amount, Date, BrandName, ...





builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));












## Docker commands
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