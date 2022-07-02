using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL{
public class Contexto: DbContext
{
    public DbSet<Coins> Coins{get; set;}

    public Contexto(DbContextOptions<Contexto> options) : base(options){
    }

     protected override void OnModelCreating(ModelBuilder modelBuilder){
       
        modelBuilder.Entity<Coins>().HasData(
            
                new Coins(){
                    MonedaId = 1,
                    Descripcion = "Bitcoin",
                    Valor = 23000,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Bitcoin.svg/1024px-Bitcoin.svg.png"
                },
                new Coins(){
                    MonedaId = 2,
                    Descripcion = "Ethereum",
                    Valor = 1233,
                    ImageUrl = "https://e7.pngegg.com/pngimages/471/910/png-clipart-ethereum-classic-computer-icons-cryptocurrency-symbol-symbol-miscellaneous-blue.png"
                },
                new Coins(){
                    MonedaId = 3,
                    Descripcion = "Solana",
                    Valor = 41.98,
                    ImageUrl = "https://cryptologos.cc/logos/solana-sol-logo.png"
                },
                new Coins(){
                    MonedaId = 4,
                    Descripcion = "Binance",
                    Valor = 17.97,
                    ImageUrl = "https://w7.pngwing.com/pngs/286/459/png-transparent-binance-cryptocurrency-exchange-coin-trade-coin-thumbnail.png"
                },
                new Coins(){
                    MonedaId = 5,
                    Descripcion = "Shiba Inu",
                    Valor = 0.000012 ,
                    ImageUrl = "https://w7.pngwing.com/pngs/929/384/png-transparent-shib-coin-shib-coin-logo-shiba-token-thumbnail.png"
                },
                new Coins(){
                    MonedaId = 6,
                    Descripcion = "Cardano",
                    Valor = 0.50,
                    ImageUrl = "https://w7.pngwing.com/pngs/844/873/png-transparent-cardano-zug-cryptocurrency-blockchain-ethereum-bitcoin-wallet-thumbnail.png"
                },new Coins(){
                    MonedaId = 7,
                    Descripcion = "Uniswap",
                    Valor = 50245,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Uniswap_Logo.svg/1026px-Uniswap_Logo.svg.png"
                },
                new Coins(){
                    MonedaId = 8,
                    Descripcion = "Chainlink",
                    Valor = 7.23,
                    ImageUrl = "https://cryptologos.cc/logos/chainlink-link-logo.png"
                },
                new Coins(){
                    MonedaId = 9,
                    Descripcion = "Ripple",
                    Valor = 036671,
                    ImageUrl = "https://flyclipart.com/thumb2/ripple-xrp-icon-242793.png"
                },
                new Coins(){
                    MonedaId = 10,
                    Descripcion = "Bitcoin Cash",
                    Valor = 117.47,
                    ImageUrl = "https://logodownload.org/wp-content/uploads/2021/01/bitcoin-cash-logo-5.png"
                }
            );
        }
    }
}